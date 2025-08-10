using AgOpenGPS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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

            CKs = new CheckBox[] { ckTSZeroWas, ckTSInvertRoll, ckTSUseAds, ckTSAutoZero };

            for (int i = 0; i < CKs.Length; i++)
            {
                CKs[i].CheckedChanged += tb_TextChanged;
            }

            TabEdited = new bool[2];

            Boxes = new clsTextBoxes(mf);
            BuildBoxes();
        }
        private void groupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            mf.Tls.DrawGroupBox(box, e.Graphics, this.BackColor, Color.Black, Color.Blue);
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
            // AS15-3 pcb
            tbTSpowerRelay.Text = "0";
            tbTSsteerRelay.Text = "1";
            tbTSwas.Text = "25";
            tbTScurrent.Text = "26";
            tbTSsteerSwitch.Text = "30";
            tbTSworkSwitch.Text = "31";
            tbTSdir.Text = "23";
            tbTSpwm.Text = "22";
            tbTSReceiverPort.Text = "8";
            tbTSRS232Out.Text = "2";
            tbTSRS232In.Text = "4";
            tbTSIMUport.Text = "3";
            cboIMU.SelectedIndex = 0;

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

        private void btnSendToModule_Click(object sender, EventArgs e)
        {
            try
            {
                PGN32300 PGN = new PGN32300(this);

                if (PGN.Send())
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
            int StartID = Boxes.Add(this.Text, tbTSReceiverPort, 8, 0);
            Boxes.Add(this.Text, tbTSIMUport, 8, 0);
            Boxes.Add(this.Text, tbTSRS232In, 8, 0);
            Boxes.Add(this.Text, tbTSRS232Out, 8, 0);

            // pins
            Boxes.Add(this.Text, tbTSpowerRelay, 41);
            Boxes.Add(this.Text, tbTSsteerRelay, 41);
            Boxes.Add(this.Text, tbTSsteerSwitch, 41);
            Boxes.Add(this.Text, tbTSworkSwitch, 41);

            Boxes.Add(this.Text, tbTSwas, 41);
            Boxes.Add(this.Text, tbTScurrent, 41);
            Boxes.Add(this.Text, tbTSdir, 41);
            int EndID = Boxes.Add(this.Text, tbTSpwm, 41);

            for (int i = StartID; i < EndID + 1; i++)
            {
                Boxes.Item(i).TB.Tag = Boxes.Item(i).ID;
                Boxes.Item(i).TB.Enter += tb_Enter;
                Boxes.Item(i).TB.TextChanged += tb_TextChanged;
                Boxes.Item(i).TB.Validating += tb_Validating;
                Boxes.Item(i).TB.HelpRequested += Page2_HelpRequested;
            }
        }

        private void ckTSUseAds_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Use ADS1115 for WAS and Current measurement.";

            mf.Tls.ShowHelp(Message, "ADS1115");
            hlpevent.Handled = true;
        }

        private void ckTSZeroWas_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Zero out the WAS at current reading.";

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
                bool Checked;

                // textboxes
                Boxes.ReLoad();

                // check boxes
                for (int i = 0; i < CKs.Length; i++)
                {
                    bool.TryParse(mf.Tls.LoadProperty(CKs[i].Name), out Checked);
                    CKs[i].Checked = Checked;
                }
                cboIMU.SelectedIndex = Properties.Settings.Default.IMU;
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

                // check boxes
                for (int i = 0; i < CKs.Length; i++)
                {
                    mf.Tls.SaveProperty(CKs[i].Name, CKs[i].Checked.ToString());
                }
                Properties.Settings.Default.IMU = cboIMU.SelectedIndex;
                Properties.Settings.Default.Save();
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

        private void UpdateForm()
        {
            Initializing = true;
            LoadSettings();
            Initializing = false;
        }

        private void cboIMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons(true);
        }

        private void ckTSAutoZero_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Auto Zero the WAS reading as it is being used.";

            mf.Tls.ShowHelp(Message, "WAS");
            hlpevent.Handled = true;
        }
    }
}