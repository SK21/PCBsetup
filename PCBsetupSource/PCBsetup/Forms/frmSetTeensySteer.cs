using AgOpenGPS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmSetTeensySteer : Form
    {
        public clsTextBoxes Boxes;
        public CheckBox[] CKs;
        public frmMain mf;
        private bool FormEdited = false;
        private bool Initializing = false;
        private bool[] TabEdited;

        public frmSetTeensySteer(frmMain CallingForm)
        {
            InitializeComponent();

            mf = CallingForm;

            CKs = new CheckBox[] { ckTSSwapRoll, ckTSInvertRoll, ckTSuse4_20,
                ckTSRelayOn, ckTSZeroWas };

            for (int i = 0; i < CKs.Length; i++)
            {
                CKs[i].CheckedChanged += tb_TextChanged;
            }

            TabEdited = new bool[2];

            Boxes = new clsTextBoxes(mf);
            BuildBoxes();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormEdited)
                {
                    bool Edited = false;
                    for (int i = 0; i < 2; i++)
                    {
                        if (TabEdited[i])
                        {
                            Edited = true;
                            break;
                        }
                    }
                    if (Edited) mf.Tls.ShowHelp("Changes have not been sent to the module.", "Warning", 3000);

                    this.Close();
                }
                else
                {
                    SaveSettings();
                    SetButtons(false);
                    UpdateForm();
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                TabEdited[i] = false;
            }
            UpdateForm();
            SetButtons(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Boxes.Clear();
        }

        private void btnLoadDefaults_Click(object sender, EventArgs e)
        {
            // AS15 pcb
            cbTSreceiver.SelectedIndex = 1;
            tbTSReceiverPort.Text = "8";    // 8 both micro and  simpleRTK2B
            tbTSIMUport.Text = "5";         // 5 Adafruit, 4 Sparkfun
            tbTSPulseCal.Text = "255";
            cbTSRelayControl.SelectedIndex = 0;
            tbTSDir.Text = "23";
            tbTSPWM.Text = "22";
            tbTSpowerRelay.Text = "0";
            tbTSsteerRelay.Text = "7";
            tbTSsteerSwitch.Text = "26";
            tbTSworkSwitch.Text = "27";
            tbTSspeedPulse.Text = "28";

            // check boxes
            for (int i = 0; i < CKs.Length; i++)
            {
                CKs[i].Checked = false;
            }
        }

        private void btnLoadDefaults_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Load defaults.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private  void btnSendToModule_Click(object sender, EventArgs e)
        {
            bool Sent;
            try
            {
                PGN32300 PGN = new PGN32300(this);
                Sent =  PGN.Send(); // Await the Task<bool> to get the result

                PGN32301 PGN2 = new PGN32301(this);
                Sent = Sent &  PGN2.Send(); // Await the Task<bool> to get the result

                if (Sent)
                {
                    mf.Tls.ShowHelp("Sent to module.", this.Text, 3000);
                    for (int i = 0; i < 2; i++)
                    {
                        TabEdited[i] = false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                switch (ex.Message)
                {
                    case "ModuleDisconnected":
                        mf.Tls.ShowHelp("Module disconnected. Wait for connection and retry.", this.Text, 3000);
                        break;

                    case "CommDisconnected":
                        mf.Tls.ShowHelp("Comm port is not open.", this.Text, 3000);
                        break;

                    default:
                        mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
                        break;
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
            }
        }

        private void btnSendToModule_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Upload to module.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private void BuildBoxes()
        {
            int StartID = Boxes.Add(this.Text, tbTSReceiverPort, 8, 1);
            Boxes.Add(this.Text, tbTSIMUport, 8, 1);
            Boxes.Add(this.Text, tbTSPulseCal);
            Boxes.Add(this.Text, tbTSDir, 41);
            Boxes.Add(this.Text, tbTSPWM, 41);

            // pins
            Boxes.Add(this.Text, tbTSpowerRelay, 41);
            Boxes.Add(this.Text, tbTSsteerRelay, 41);
            Boxes.Add(this.Text, tbTSsteerSwitch, 41);
            Boxes.Add(this.Text, tbTSworkSwitch, 41);
            Boxes.Add(this.Text, tbTSspeedPulse, 41);

            // relay pins
            Boxes.Add(this.Text, tbTSr1, 41);
            Boxes.Add(this.Text, tbTSr2, 41);
            Boxes.Add(this.Text, tbTSr3, 41);
            Boxes.Add(this.Text, tbTSr4, 41);
            Boxes.Add(this.Text, tbTSr5, 41);
            Boxes.Add(this.Text, tbTSr6, 41);
            Boxes.Add(this.Text, tbTSr7, 41);
            Boxes.Add(this.Text, tbTSr8, 41);
            Boxes.Add(this.Text, tbTSr9, 41);
            Boxes.Add(this.Text, tbTSr10, 41);
            Boxes.Add(this.Text, tbTSr11, 41);
            Boxes.Add(this.Text, tbTSr12, 41);
            Boxes.Add(this.Text, tbTSr13, 41);
            Boxes.Add(this.Text, tbTSr14, 41);
            Boxes.Add(this.Text, tbTSr15, 41);
            int EndID = Boxes.Add(this.Text, tbTSr16, 41);

            for (int i = StartID; i < EndID + 1; i++)
            {
                Boxes.Item(i).TB.Tag = Boxes.Item(i).ID;
                Boxes.Item(i).TB.Enter += tb_Enter;
                Boxes.Item(i).TB.TextChanged += tb_TextChanged;
                Boxes.Item(i).TB.Validating += tb_Validating;
                Boxes.Item(i).TB.HelpRequested += Page2_HelpRequested;
            }
        }

        private void cbTSreceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void cbTSRelayControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void ckTSRelayOn_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Which signal (high or low) turns on the relay.";

            mf.Tls.ShowHelp(Message, "Relay on high");
            hlpevent.Handled = true;
        }

        private void ckTSSwapRoll_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Use IMU pitch for roll";

            mf.Tls.ShowHelp(Message, "IMU roll");
            hlpevent.Handled = true;
        }

        private void ckTSuse4_20_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Use a 4-20 pressure sensor.";

            mf.Tls.ShowHelp(Message, "Pressure Sensor");
            hlpevent.Handled = true;
        }

        private void ckTSZeroWas_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Zero out the WAS reading.";

            mf.Tls.ShowHelp(Message, "WAS");
            hlpevent.Handled = true;
        }

        private void frmTeensySteer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
            ResetZeroWas();
        }

        private void frmTeensySteer_Load(object sender, EventArgs e)
        {
            try
            {
                mf.Tls.LoadFormData(this);

                this.BackColor = PCBsetup.Properties.Settings.Default.DayColour;

                for (int i = 0; i < tabControl1.TabCount; i++)
                {
                    tabControl1.TabPages[i].BackColor = PCBsetup.Properties.Settings.Default.DayColour;
                }

                UpdateForm();
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
            }
        }

        private void LoadSettings()
        {
            try
            {
                byte tmp;
                bool Checked;

                // textboxes
                Boxes.ReLoad();

                // combo boxes
                byte.TryParse(mf.Tls.LoadProperty("cbTSreceiver"), out tmp);
                cbTSreceiver.SelectedIndex = tmp;

                byte.TryParse(mf.Tls.LoadProperty("cbTSrelayControl"), out tmp);
                cbTSRelayControl.SelectedIndex = tmp;

                // check boxes
                for (int i = 0; i < CKs.Length; i++)
                {
                    bool.TryParse(mf.Tls.LoadProperty(CKs[i].Name), out Checked);
                    CKs[i].Checked = Checked;
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
            }
        }

        private void Page2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string FileName = AppDomain.CurrentDomain.BaseDirectory + "Help\\AutoSteerConfig.pdf";
            Process.Start(new ProcessStartInfo { FileName = FileName, UseShellExecute = true });
            hlpevent.Handled = true;
        }

        private void ResetZeroWas()
        {
            // Zero WAS checkbox is only a one-time setting, reset to false after use
            bool PrevInit = Initializing;
            Initializing = true;
            ckTSZeroWas.Checked = false;
            mf.Tls.SaveProperty(ckTSZeroWas.Name, false.ToString());
            Initializing = PrevInit;
        }

        private void SaveSettings()
        {
            try
            {
                // textboxes
                Boxes.Save();

                // combo boxes
                mf.Tls.SaveProperty("cbTSreceiver", cbTSreceiver.SelectedIndex.ToString());
                mf.Tls.SaveProperty("cbTSrelayControl", cbTSRelayControl.SelectedIndex.ToString());

                // check boxes
                for (int i = 0; i < CKs.Length; i++)
                {
                    mf.Tls.SaveProperty(CKs[i].Name, CKs[i].Checked.ToString());
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
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
                    btnSendToModule.Enabled = false;
                    if (tabControl1.SelectedIndex < 2) TabEdited[tabControl1.SelectedIndex] = true;
                }
                else
                {
                    btnCancel.Enabled = false;
                    bntOK.Image = Properties.Resources.bntOK_Image;
                    btnSendToModule.Enabled = true;
                }

                FormEdited = Edited;
            }
        }

        private void tb_Enter(object sender, EventArgs e)
        {
            int index = (int)((TextBox)sender).Tag;
            clsTextBox BX = Boxes.Item(index);
            double min = BX.MinValue;
            double max = BX.MaxValue;
            double Value = BX.Value();

            using (var form = new FormNumeric(min, max, Value))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BX.TB.Text = form.ReturnValue.ToString();
                }
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            int index = (int)((TextBox)sender).Tag;
            clsTextBox BX = Boxes.Item(index);
            if (BX.Value() < BX.MinValue || BX.Value() > BX.MaxValue)
            {
                System.Media.SystemSounds.Exclamation.Play();
                e.Cancel = true;
            }
        }

        private void tbTSIMUport_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbTSPulseCal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "The number of pulses per second output for monitors to read 1 KMH.";

            mf.Tls.ShowHelp(Message, "Speed pulse");
            hlpevent.Handled = true;
        }

        private void UpdateForm()
        {
            Initializing = true;
            LoadSettings();
            Initializing = false;
        }
    }
}