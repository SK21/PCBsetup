using AgOpenGPS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmFWTeensyNetwork : Form
    {
        //******************************************************************************
        // Intel Hex record format:
        //
        // Start code:  one character, ASCII colon ':'.
        // Byte count:  two hex digits, number of bytes (hex digit pairs) in data field.
        // Address:     four hex digits
        // Record type: two hex digits, 00 to 05, defining the meaning of the data field.
        // Data:        n bytes of data represented by 2n hex digits.
        // Checksum:    two hex digits, computed value used to verify record has no errors.
        //
        // Examples:
        //  :10 9D30 00 711F0000AD38000005390000F5460000 35
        //  :04 9D40 00 01480000 D6
        //  :00 0000 01 FF
        //******************************************************************************

        public UDPComm UDPmodules;
        private bool FormEdited = false;
        private Dictionary<string, byte> hexindex = new Dictionary<string, byte>();
        private string IDname;
        private bool Initializing = true;
        private frmMain mf;
        private byte ModuleID = 0;
        private byte ModuleType = 0;          // 0 - Teensy AutoSteer, 1 - Teensy Rate
        private int TotalLines = 0;
        private bool UseDefault = false;

        public frmFWTeensyNetwork(frmMain CallingForm, byte ID)
        {
            InitializeComponent();
            mf = CallingForm;
            ModuleType = ID;
            UDPmodules = new UDPComm(this, 29999, 28888, 9250, "UDPmodules");                   // arduino
        }

        public frmMain MF
        { get { return mf; } }

        public void CheckLines(byte[] data)
        {
            if (data.Length == 9 && data[0] == 0x4f && data[1] == 0x54 && data[2] == 0x41 && data[3] == 0x55 && data[4] == 0x70)
            {
                int lines = data[5] | (data[6] << 8) | (data[7] << 16) | (data[8] << 24);
                if (TotalLines == lines)
                {
                    UDPmodules.SendUDPMessage(new byte[] { 0x3a, 0x00, 0x00, 0x00, 0x06, 0xFA });
                }
                else
                {
                    UDPmodules.SendUDPMessage(new byte[] { 0x3a, 0x00, 0x00, 0x00, 0x07, 0xF9 });
                }
            }
        }

        public byte[] StrToByteArray(string str)
        {
            List<byte> hexres = new List<byte>();
            for (int i = 0; i < str.Length; i += 2) hexres.Add(hexindex[str.Substring(i, 2)]);

            return hexres.ToArray();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            if (FormEdited)
            {
                // save
                mf.Tls.SaveProperty(IDname, tbID.Text);
                SetButtons(false);
                UpdateForm();
            }
            else
            {
                Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            UseDefault = false;
            tbHexfile.Text = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "hex files (*.hex)|*.hex|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbHexfile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowse_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Search for new firmware (hex) files.";

            mf.Tls.ShowHelp(Message, "Browse");
            hlpevent.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            UseDefault = true;
            tbHexfile.Text = "Default file version date: " + mf.Tls.TeensyAutoSteerVersion();
        }

        private void btnDefault_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Use the base firmware included in the app.";

            mf.Tls.ShowHelp(Message, "Use default");
            hlpevent.Handled = true;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";

                PGN32703 BeginUpdate = new PGN32703(mf);
                BeginUpdate.Send(ModuleID, ModuleType,ckOverwrite.Checked);
                Thread.Sleep(1000);

                if (UseDefault)
                {
                    filename = Path.GetTempFileName();
                    switch (ModuleType)
                    {
                        case 1:
                            // rate
                            File.WriteAllBytes(filename, PCBsetup.Properties.Resources.RCteensy_ino);
                            break;

                        default:
                            // autosteer
                            File.WriteAllBytes(filename, PCBsetup.Properties.Resources.AutoSteerTeensyRVC_ino);
                            break;
                    }
                }
                else
                {
                    filename = tbHexfile.Text;
                }

                if (File.Exists(filename))
                {
                    progressBar.Value = 0;
                    int ExpectedLines = (int)new FileInfo(filename).Length / 45;

                    hexindex.Clear();
                    for (int i = 0; i <= 255; i++) hexindex.Add(i.ToString("X2"), (byte)i);
                    hexindex.Add("::", 0x3a);
                    TotalLines = 0;
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        //read all the lines
                        DateTime prev = DateTime.Now;
                        DateTime start = DateTime.Now;
                        TimeSpan aa = new TimeSpan(TimeSpan.TicksPerMillisecond * 10);
                        int idx = 0;
                        while (true)
                        {
                            if (DateTime.Now - prev > aa)
                            {
                                prev = DateTime.Now;
                                line = "";
                                for (int i = 0; i < 11; i++)
                                {
                                    if (!reader.EndOfStream)
                                    {
                                        line += ":" + reader.ReadLine();
                                        idx++;
                                    }
                                }
                                lbCount.Text = idx.ToString();
                                Application.DoEvents();

                                UpdateProgress(idx * 100 / ExpectedLines);
                                UDPmodules.SendUDPMessage(StrToByteArray(line));

                                if (reader.EndOfStream)
                                {
                                    break;
                                }
                            }
                        }
                        TotalLines = idx;
                    }
                }
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog(this.Text + "/btnUpload " + ex.Message);
            }
        }


        private void frmFWTeensyNetwork_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
            UDPmodules.Close();
        }

        private void frmFWTeensyNetwork_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
            this.BackColor = PCBsetup.Properties.Settings.Default.DayColour;

            UseDefault = true;
            switch (ModuleType)
            {
                case 1:
                    // rate
                    tbHexfile.Text = "Default file version date: " + mf.Tls.TeensyRateVersion();
                    this.Text = "Teensy Rate Firmware";
                    IDname = "TeensyRateID";
                    break;

                default:
                    // autosteer
                    tbHexfile.Text = "Default file version date: " + mf.Tls.TeensyAutoSteerVersion();
                    this.Text = "Teensy AutoSteer Firmware";
                    IDname = "TeensySteerID";
                    break;
            }

            if (int.TryParse(mf.Tls.LoadProperty(IDname), out int ID)) ModuleID = (byte)ID;

                       UDPmodules.NetworkEP = mf.Subnet;
 UDPmodules.StartUDPServer();
            if (!UDPmodules.IsUDPSendConnected)
            {
                mf.Tls.ShowHelp("UDPnetwork failed to start.", "", 3000, true, true);
            }


            UpdateForm();
        }


        private void SetButtons(bool Edited)
        {
            if (!Initializing)
            {
                if (Edited)
                {
                    btnCancel.Enabled = true;
                    bntOK.Image = Properties.Resources.Save;
                }
                else
                {
                    btnCancel.Enabled = false;
                    bntOK.Image = Properties.Resources.bntOK_Image;
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

        private void tbHexfile_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Filename of firmware to upload to the Teensy.";

            mf.Tls.ShowHelp(Message, "Firmware");
            hlpevent.Handled = true;
        }

        private void tbID_Enter(object sender, EventArgs e)
        {
            int val = 0;
            if (int.TryParse(tbID.Text, out int vl)) val = vl;
            using (var form = new FormNumeric(0, 7, val))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbID.Text = form.ReturnValue.ToString();
                    ModuleID = (byte)form.ReturnValue;
                }
            }
            tbHexfile.Focus();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void UpdateForm()
        {
            Initializing = true;
            tbID.Text = ModuleID.ToString();
            Initializing = false;
        }

        private void UpdateProgress(int ProgressPercent)
        {
            if (ProgressPercent > 100) ProgressPercent = 100;
            if (ProgressPercent < 0) ProgressPercent = 0;

            progressBar.BeginInvoke(new Action(() => progressBar.Value = ProgressPercent));
        }
    }
}