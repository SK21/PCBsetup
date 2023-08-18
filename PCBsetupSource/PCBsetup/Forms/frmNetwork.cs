using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmNetwork : Form
    {
        public frmMain mf;
        private const byte cByteCount = 10;
        private const byte HeaderHi = 126;
        private const byte HeaderLo = 147;
        private bool FormEdited;
        private PGN32402 Info;
        private byte InfoID;
        private bool Initializing;

        public frmNetwork(frmMain CalledFrom)
        {
            InitializeComponent();
            mf = CalledFrom;
            Info = new PGN32402(this);
        }

        public void ParseByteData(byte[] Data)
        {
            if (Data[0] == HeaderLo && Data[1] == HeaderHi
                && Data.Length >= cByteCount && mf.Tls.GoodCRC(Data))
            {
                string Mes = "\r\n";

                InfoID = Data[2];
                switch (InfoID)
                {
                    case 0:
                        // subnet
                        Mes += "Module type: " + Data[2].ToString();
                        Mes += ", Module ID: " + Data[3].ToString();
                        Mes += ", Address: " + Data[5].ToString() + "." + Data[6].ToString() + "." + Data[7].ToString();
                        break;

                    case 1:
                        // Ino ID
                        Mes += "Ino ID: ";
                        UInt16 ID = (ushort)(Data[3] | Data[4] << 8);
                        Mes += ID.ToString();
                        break;
                }
                tbModuleInfo.AppendText(Mes);
            }
        }

        public void ParseStringData(string[] Data)
        {
            byte Len = (byte)Data.Length;
            byte[] BD = new byte[Len];
            byte tmp;
            for (int i = 0; i < Len; i++)
            {
                if (byte.TryParse(Data[i], out tmp)) BD[i] = tmp;
            }
            ParseByteData(BD);
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            if (!FormEdited)
            {
                this.Close();
            }
            else
            {
                // save settings
                mf.UDPmodulesConfig.EthernetEP = cbEthernet.Text;
                mf.Tls.SaveProperty("EthernetEP", cbEthernet.Text);

                SetButtons(false);
                UpdateForm();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateForm();
            SetButtons(false);
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            tbModuleInfo.AppendText("\r\n Sending module info request ...");
            try
            {
                Info.Send(0);   // subnet
                Info.Send(1);   // ino id
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("frmNetwork/btnRescan_Click  " + ex.Message);
            }
            UpdateForm();
        }

        // from AGIO/FormUDP
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] NewIP = { 148, 126, 192, 168, 1, 0 };
            IPEndPoint epModuleSet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 28800);
            IPAddress IP;
            string[] data;

            if (IPAddress.TryParse(mf.UDPmodulesConfig.EthernetEP, out IP))
            {
                data = mf.UDPmodulesConfig.EthernetEP.Split('.');
                NewIP[2] = byte.Parse(data[0]);
                NewIP[3] = byte.Parse(data[1]);
                NewIP[4] = byte.Parse(data[2]);
                NewIP[5] = mf.Tls.CRC(NewIP, 5);

                //loop thru all interfaces
                foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.Supports(NetworkInterfaceComponent.IPv4) && nic.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (var info in nic.GetIPProperties().UnicastAddresses)
                        {
                            // Only InterNetwork and not loopback which have a subnetmask
                            if (info.Address.AddressFamily == AddressFamily.InterNetwork &&
                                !IPAddress.IsLoopback(info.Address) &&
                                info.IPv4Mask != null)
                            {
                                Socket scanSocket;
                                try
                                {
                                    if (nic.OperationalStatus == OperationalStatus.Up
                                        && info.IPv4Mask != null)
                                    {
                                        scanSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                                        scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
                                        scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                                        scanSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontRoute, true);

                                        try
                                        {
                                            scanSocket.Bind(new IPEndPoint(info.Address, 9999));
                                            scanSocket.SendTo(NewIP, 0, NewIP.Length, SocketFlags.None, epModuleSet);
                                        }
                                        catch (Exception ex)
                                        {
                                            mf.Tls.WriteErrorLog("frmNework/btnSend_Click/Bind error " + ex.Message);
                                        }

                                        scanSocket.Dispose();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    mf.Tls.WriteErrorLog("frmNework/btnSend_Click/nic loop error " + ex.Message);
                                }
                            }
                        }
                    }
                }
                tbModuleInfo.AppendText("\r\nNew Subnet address sent to modules.");
            }
            else
            {
                tbModuleInfo.AppendText("\r\nNew Subnet address not sent.");
            }
        }

        private void btnSend_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Send subnet setting to modules.";

            mf.Tls.ShowHelp(Message, this.Text, 3000);
            hlpevent.Handled = true;
        }

        private void btnSetEthernet_Click(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void frmNetwork_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmNetwork_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);

            this.BackColor = Properties.Settings.Default.DayColour;

            foreach (Control c in this.Controls)
            {
                c.ForeColor = Color.Black;
            }

            UpdateForm();
            SetButtons(false);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            mf.Tls.DrawGroupBox(box, e.Graphics, this.BackColor, Color.Black, Color.Blue);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            mf.Tls.DrawGroupBox(box, e.Graphics, this.BackColor, Color.Black, Color.Blue);
        }

        private void LoadCombo()
        {
            // https://stackoverflow.com/questions/6803073/get-local-ip-address
            try
            {
                cbEthernet.Items.Clear();
                foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet && item.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                cbEthernet.Items.Add(ip.Address.ToString());
                            }
                        }
                    }
                }
                cbEthernet.SelectedIndex = cbEthernet.FindString(SubAddress(mf.UDPmodulesConfig.EthernetEP));
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("frmWifi/LoadCombo " + ex.Message);
            }
        }

        private void SetButtons(bool Edited)
        {
            if (!Initializing)
            {
                if (Edited)
                {
                    btnCancel.Enabled = true;
                    bntOK.Image = Properties.Resources.Save;
                    btnRescan.Enabled = false;
                    btnSend.Enabled = false;
                }
                else
                {
                    btnCancel.Enabled = false;
                    bntOK.Image = Properties.Resources.bntOK_Image;
                    btnRescan.Enabled = true;
                    btnSend.Enabled = true;
                }

                FormEdited = Edited;
            }
        }

        private string SubAddress(string Address)
        {
            IPAddress IP;
            string[] data;
            string Result = "";

            if (IPAddress.TryParse(Address, out IP))
            {
                data = Address.Split('.');
                Result = data[0] + "." + data[1] + "." + data[2];
            }
            return Result;
        }

        private void UpdateForm()
        {
            Initializing = true;
            lbEthernet.Text = "Selected subnet:  " + mf.UDPmodulesConfig.EthernetEP;
            LoadCombo();
            Initializing = false;
        }
    }
}