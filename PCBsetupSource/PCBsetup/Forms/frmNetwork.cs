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
        private const byte cByteCount = 7;
        private const byte HeaderHi = 126;
        private const byte HeaderLo = 46;
        private bool FormEdited;
        private PGN32303 Info;
        private byte InfoID;
        private bool Initializing;

        public frmNetwork(frmMain CalledFrom)
        {
            InitializeComponent();
            mf = CalledFrom;
            Info = new PGN32303(this);
        }

        public void ParseByteData(byte[] Data)
        {
            if (Data[0] == HeaderLo && Data[1] == HeaderHi
                && Data.Length >= cByteCount && mf.Tls.GoodCRC(Data))
            {
                string Mes = "\r\n";

                // Ino ID
                Mes += "Ino ID: ";
                UInt16 ID = (ushort)(Data[2] | Data[3] << 8);
                Mes += ID.ToString() + "\r\n";

                byte Status = Data[4];
                if (mf.Tls.BitRead(Status, 0))
                {
                    Mes += "IMU connected.\r\n";
                }
                else
                {
                    Mes += "IMU not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 1))
                {
                    Mes += "ADS1115 connected.\r\n";
                }
                else
                {
                    Mes += "ADS1115 not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 2))
                {
                    Mes += "Relay controller connected.\r\n";
                }
                else
                {
                    Mes += "Relay controller not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 3))
                {
                    Mes += "Steer switch on.\r\n";
                }
                else
                {
                    Mes += "Steer switch off.\r\n";
                }

                if (mf.Tls.BitRead(Status, 4))
                {
                    Mes += "AOG connected.\r\n";
                }
                else
                {
                    Mes += "AOG not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 5))
                {
                    Mes += "GPS receiver connected.\r\n";
                }
                else
                {
                    Mes += "GPS receiver not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 6))
                {
                    Mes += "Ntrip connected.\r\n";
                }
                else
                {
                    Mes += "Ntrip not connected.\r\n";
                }

                if (mf.Tls.BitRead(Status, 7))
                {
                    Mes += "Ethernet connected.\r\n";
                }
                else
                {
                    Mes += "Ethernet not connected.\r\n";
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
                Info.Send();
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("frmNetwork/btnRescan_Click  " + ex.Message);
            }
            UpdateForm();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            PGN32503 SetSubnet = new PGN32503(mf);
            if (SetSubnet.Send(mf.UDPmodulesConfig.EthernetEP))
            {
                tbModuleInfo.AppendText("\r\n New Subnet address sent.");
            }
            else
            {
                tbModuleInfo.AppendText("\r\n New Subnet address not sent.");
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
                Result = data[0] + "." + data[1] + "." + data[2] + ".";
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