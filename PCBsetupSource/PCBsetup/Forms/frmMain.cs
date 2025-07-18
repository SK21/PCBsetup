using PCBsetup.Classes;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public enum ModuleTypes
    {
        Teensy_AutoSteer,
        Teensy_Rate,
        Nano_Rate,
        Nano_SwitchBox,
        ESP_Rate
    }

    public enum UploadResult
    {
        Completed,
        Failed,
        Sync_Error,
        Time_Out
    }

    public partial class frmMain : Form
    {
        public SerialComm CommPort;
        public clsDownloader Dlr;
        public clsTools Tls;
        public frmFWTeensyNetwork TN;
        public UDPComm UDPmodules;
        public UDPComm UDPupdate;
        public clsVersionChecker VC;
        private byte cModule = 0;
        private string cSelectedPortName;
        private string cSubnet = "192.168.1.1";
        private int PortID = 1;

        public frmMain()
        {
            InitializeComponent();
            Tls = new clsTools(this);
            CommPort = new SerialComm(this, PortID);
            CommPort.ModuleConnected += CommPort_ModuleConnected;
            UDPmodules = new UDPComm(this, 29500, 28888, 9250, "UDPmodules");
            UDPupdate = new UDPComm(this, 29000, 29100, 9350, "UDPupdate");
            VC = new clsVersionChecker(this);
            Dlr = new clsDownloader(this);
        }

        public int ConnectionType
        { get { return tbType.SelectedIndex; } }

        public byte ModuleSelected
        { get { return cModule; } }

        public string Subnet
        {
            get { return cSubnet; }
            set
            {
                if (IPAddress.TryParse(value, out IPAddress IP))
                {
                    cSubnet = IP.ToString();
                    Tls.SaveProperty("SubNet", cSubnet);
                }
            }
        }

        public bool OpenComm()
        {
            CommPort.SCportName = TrimPortName(cboPort1.Text);
            CommPort.SCportBaud = 38400;
            CommPort.Open();
            return CommPort.IsOpen();
        }

        public string SelectedPortName()
        {
            return cSelectedPortName;
        }

        private void btnConnect1_Click_1(object sender, EventArgs e)
        {
            if (btnConnect1.Text == Languages.Lang.lgConnect)
            {
                if (!OpenComm()) Tls.ShowHelp("Could not open comm port.", this.Text, 3000);
            }
            else
            {
                CommPort.Close();
            }
            UpdateForm();
        }

        private void btnFirmware_Click(object sender, EventArgs e)
        {
            switch (cModule)
            {
                case 0:
                    // Teensy AutoSteer
                    Form tmp = new frmFWTeensySerial(this, 0);
                    tmp.ShowDialog();
                    break;

                case 1:
                    // Teensy Rate
                    Form tmp1 = new frmFWTeensySerial(this, 1);
                    tmp1.ShowDialog();
                    break;

                case 2:
                    // Nano Rate
                    Form tmp2 = new frmFWNanoRate(this);
                    tmp2.ShowDialog();
                    break;

                case 3:
                    // Nano SwitchBox
                    Form tmp3 = new frmFWNanoSwitchBox(this);
                    tmp3.ShowDialog();
                    break;

                case 4:
                    // esp32 rate
                    Form tmp4 = new frmFWESP32(this);
                    CommPort.Close();   // needs to be closed for esptool to connect
                    tmp4.ShowDialog();
                    break;
            }
        }

        private void btnFirmware_Click_1(object sender, EventArgs e)
        {
            switch (cModule)
            {
                case 0:
                    // Teensy AutoSteer
                    TN = new frmFWTeensyNetwork(this, 0);
                    TN.ShowDialog();
                    break;

                case 1:
                    // Teensy Rate
                    TN = new frmFWTeensyNetwork(this, 1);
                    TN.ShowDialog();
                    break;
            }
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            LoadPortsCombo();
            UpdateForm();
        }

        private void btnSendSubnet_Click(object sender, EventArgs e)
        {
            PGN32503 SetSubnet = new PGN32503(this);
            if (SetSubnet.Send(Subnet))
            {
                Tls.ShowHelp("New Subnet address sent.", "Subnet", 10000);
            }
            else
            {
                Tls.ShowHelp("New Subnet address not sent.", "Subnet", 10000);
            }
        }

        private void btnSendSubnet_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Send subnet address to modules.";

            Tls.ShowHelp(Message, "Subnet");
            hlpevent.Handled = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            switch (cModule)
            {
                case 0:
                    // Teensy AutoSteer
                    Form tmp = new frmSetTeensySteer(this);
                    tmp.ShowDialog();
                    break;

                case 3:
                    // Nano SwitchBox
                    Form tmp3 = new frmSetNanoSwitchbox(this);
                    tmp3.ShowDialog();
                    break;
            }
        }

        private async void btnUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                await VC.Update();
                await Dlr.Download();
                Tls.ShowHelp("Files downloaded.", "Help", 5000);
            }
            catch (Exception ex)
            {
                Tls.ShowHelp("Failed to update.  " + ex.Message, "Help", 5000, true);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fs = Application.OpenForms["frmMonitor"];

            if (fs == null)
            {
                Form frm = new frmMonitor(this);
                frm.Show();
            }
            else
            {
                fs.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void cbEthernet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subnet = cbEthernet.Text;
            UpdateForm(false);
        }

        private void cbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tls.SaveProperty("Module", cbModule.SelectedIndex.ToString());
            cModule = (byte)cbModule.SelectedIndex;
            SetButtons();
        }

        private void cboPort1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "List of connected serial ports.";

            Tls.ShowHelp(Message, this.Text);
            hlpevent.Handled = true;
        }

        private void cboPort1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cSelectedPortName = TrimPortName(cboPort1.SelectedItem.ToString());
        }

        private void CommPort_ModuleConnected(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Tls.SaveFormData(this);
            }
            UDPmodules.Close();
            UDPupdate.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Tls.PrevInstance())
            {
                Tls.ShowHelp(Languages.Lang.lgAlreadyRunning, "Help", 3000);
                this.Close();
            }

            Tls.LoadFormData(this);
            LoadSettings();
            SetDayMode();
            SetButtons();

            UDPmodules.NetworkEP = Subnet;
            UDPmodules.StartUDPServer();
            if (!UDPmodules.IsUDPSendConnected)
            {
                Tls.ShowHelp("UDPmodules failed to start.", "", 3000, true, true);
            }

            UDPupdate.NetworkEP = Subnet;
            UDPupdate.StartUDPServer();
            if (!UDPupdate.IsUDPSendConnected)
            {
                Tls.ShowHelp("UDPupdate failed to start.", "", 3000, true, true);
            }
            this.Text = "PCBsetup [Version " + Tls.AppVersion() + " - " + Tls.VersionDate() + "]";
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Tls.DrawGroupBox((GroupBox)sender, e.Graphics, this.BackColor, Color.Black, Color.Blue);
        }

        private void LoadCombo()
        {
            // https://stackoverflow.com/questions/6803073/get-local-ip-address
            try
            {
                cbEthernet.Items.Clear();
                foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if ((item.NetworkInterfaceType == NetworkInterfaceType.Ethernet || item.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) && item.OperationalStatus == OperationalStatus.Up)
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
                cbEthernet.SelectedIndex = cbEthernet.FindString(Subnet);
            }
            catch (Exception ex)
            {
                Tls.WriteErrorLog("frmModuleConfig/LoadCombo " + ex.Message);
            }
        }

        private void LoadPortsCombo()
        {
            //https://stackoverflow.com/questions/2837985/getting-serial-port-information

            cboPort1.Items.Clear();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    Console.WriteLine(s);
                    cboPort1.Items.Add(s);
                }
            }
        }

        private void LoadSettings()
        {
            try
            {
                LoadPortsCombo();

                // start comm port
                string ID = "_" + PortID.ToString();
                string tmp = Tls.LoadProperty("SCportName" + ID);
                if (tmp == "")
                {
                    // select first port available
                    if (cboPort1.Items.Count > 0) cboPort1.SelectedItem = cboPort1.Items[0];
                }
                else
                {
                    // select previous port
                    int i = cboPort1.FindString(tmp);
                    if (i != -1)
                    {
                        cboPort1.SelectedIndex = i;
                    }
                }

                // module
                byte.TryParse(Tls.LoadProperty("Module"), out cModule);
                cbModule.SelectedIndex = cModule;

                // ethernet
                if (IPAddress.TryParse(Tls.LoadProperty("SubNet"), out IPAddress IP)) cSubnet = IP.ToString();

                // connection type
                if (int.TryParse(Tls.LoadProperty("ConnectionType"), out int ConType)) tbType.SelectedIndex = ConType;
            }
            catch (Exception ex)
            {
                Tls.ShowHelp("frmMain/LoadSettings " + ex.Message, this.Text, 3000, true);
            }
        }

        private void ModuleIndicator_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Indicates module connected. The ESP8266 does not need to show connection.";

            Tls.ShowHelp(Message, this.Text, 3000);
            hlpevent.Handled = true;
        }

        private void PortIndicator1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Indicates serial port connected.";

            Tls.ShowHelp(Message, this.Text, 3000);
            hlpevent.Handled = true;
        }

        private void SetButtons()
        {
            switch (cbModule.SelectedIndex)
            {
                case 0:
                    btnSettingsNetwork.Enabled = true;
                    btnFirmwareNetwork.Enabled = true;
                    btnSettings.Enabled = false;
                    break;

                case 1:
                    btnSettingsNetwork.Enabled = false;
                    btnFirmwareNetwork.Enabled = true;
                    btnSettings.Enabled = false;
                    break;

                case 3:
                    btnSettingsNetwork.Enabled = true;
                    btnFirmwareNetwork.Enabled = false;
                    btnSettings.Enabled = true;
                    break;

                default:
                    btnSettingsNetwork.Enabled = false;
                    btnFirmwareNetwork.Enabled = false;
                    btnSettings.Enabled = false;
                    break;
            }
        }

        private void SetDayMode()
        {
            if (Properties.Settings.Default.IsDay)
            {
                this.BackColor = Properties.Settings.Default.DayColour;
                PortIndicator1.BackColor = Properties.Settings.Default.DayColour;
                ModuleIndicator.BackColor = Properties.Settings.Default.DayColour;

                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.Black;
                }

                for (int i = 0; i < tbType.TabCount; i++)
                {
                    tbType.TabPages[i].BackColor = Properties.Settings.Default.DayColour;
                }
            }
            else
            {
                this.BackColor = Properties.Settings.Default.NightColour;
                foreach (Control c in this.Controls)
                {
                    c.ForeColor = Color.White;
                }

                for (int i = 0; i < tbType.TabCount; i++)
                {
                    tbType.TabPages[i].BackColor = Properties.Settings.Default.NightColour;
                }
            }
        }

        private string TrimPortName(string portName)
        {
            string tmp = portName;
            int End = tmp.IndexOf(" - ");
            if (End > 0) tmp = tmp.Substring(0, End);
            return tmp;
        }

        private void UpdateForm(bool UpdateCombo = true)
        {
            if (CommPort.IsOpen())
            {
                PortIndicator1.Image = Properties.Resources.On;
                btnConnect1.Text = Languages.Lang.lgDisconnect;
            }
            else
            {
                PortIndicator1.Image = Properties.Resources.Off;
                btnConnect1.Text = Languages.Lang.lgConnect;
            }

            if (CommPort.IsReceiveActive())
            {
                ModuleIndicator.Image = Properties.Resources.On;
            }
            else
            {
                ModuleIndicator.Image = Properties.Resources.Off;
            }

            if (UpdateCombo) LoadCombo();
        }

        private void tbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tls.SaveProperty("ConnectionType", tbType.SelectedIndex.ToString());
        }
    }
}