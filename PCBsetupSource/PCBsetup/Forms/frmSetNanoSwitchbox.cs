using AgOpenGPS;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmSetNanoSwitchbox : Form
    {
        public clsTextBoxes Boxes;
        public frmMain mf;
        private bool ConfigEdited;
        private bool FormEdited = false;
        private bool Initializing = false;

        public frmSetNanoSwitchbox(frmMain CallingForm)
        {
            InitializeComponent();
            mf = CallingForm;

            Boxes = new clsTextBoxes(mf);
            BuildBoxes();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormEdited)
                {
                    if (ConfigEdited) mf.Tls.ShowHelp("Changes have not been sent to the module.", "Warning", 3000);

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
            UpdateForm();
            SetButtons(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAuto.Text = "";
            tbMasterOff.Text = "";
            tbMasterOn.Text = "";
            tbRateDown.Text = "";
            tbRateUp.Text = "";
            tbWorkSwitch.Text = "";

            tbSW1.Text = "";
            tbSW2.Text = "";
            tbSW3.Text = "";
            tbSW4.Text = "";
            tbSW5.Text = "";
            tbSW6.Text = "";
            tbSW7.Text = "";
            tbSW8.Text = "";

            tbSW9.Text = "";
            tbSW10.Text = "";
            tbSW11.Text = "";
            tbSW12.Text = "";
            tbSW13.Text = "";
            tbSW14.Text = "";
            tbSW15.Text = "";
            tbSW16.Text = "";
        }

        private void btnLoadDefaults_Click(object sender, EventArgs e)
        {
            // switchbox 3
            tbAuto.Text = "9";
            tbMasterOn.Text = "4";
            tbMasterOff.Text = "3";
            tbRateUp.Text = "6";
            tbRateDown.Text = "5";
            tbWorkSwitch.Text = "0";

            tbSW1.Text = "21";
            tbSW2.Text = "20";
            tbSW3.Text = "19";
            tbSW4.Text = "18";
            tbSW5.Text = "14";
            tbSW6.Text = "15";
            tbSW7.Text = "16";
            tbSW8.Text = "17";

            tbSW9.Text = "0";
            tbSW10.Text = "0";
            tbSW11.Text = "0";
            tbSW12.Text = "0";
            tbSW13.Text = "0";
            tbSW14.Text = "0";
            tbSW15.Text = "0";
            tbSW16.Text = "0";
        }

        private void btnLoadDefaults_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string Message = "Load defaults.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private async void btnSendToModule_Click(object sender, EventArgs e)
        {
            bool Sent;
            try
            {
                if (mf.CommPort != null && mf.CommPort.IsOpen)
                {
                    PGN32701 PGN = new PGN32701(this);
                    Sent = await PGN.Send();

                    if (Sent)
                    {
                        mf.Tls.ShowHelp("Sent to module.", this.Text, 3000);
                        ConfigEdited = false;
                        mf.CommPort.Dispose();
                        mf.OpenPort();
                    }
                }
                else
                {
                    mf.Tls.ShowHelp("Port not open.");
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
            string Message = "Send to module.";

            mf.Tls.ShowHelp(Message);
            hlpevent.Handled = true;
        }

        private void BuildBoxes()
        {
            Boxes.Add(this.Text, tbAuto, 21);
            Boxes.Add(this.Text, tbMasterOn, 21);
            Boxes.Add(this.Text, tbMasterOff, 21);
            Boxes.Add(this.Text, tbRateUp, 21);
            Boxes.Add(this.Text, tbRateDown, 21);

            Boxes.Add(this.Text, tbSW1, 21);
            Boxes.Add(this.Text, tbSW2, 21);
            Boxes.Add(this.Text, tbSW3, 21);
            Boxes.Add(this.Text, tbSW4, 21);
            Boxes.Add(this.Text, tbSW5, 21);
            Boxes.Add(this.Text, tbSW6, 21);
            Boxes.Add(this.Text, tbSW7, 21);
            Boxes.Add(this.Text, tbSW8, 21);

            Boxes.Add(this.Text, tbSW9, 21);
            Boxes.Add(this.Text, tbSW10, 21);
            Boxes.Add(this.Text, tbSW11, 21);
            Boxes.Add(this.Text, tbSW12, 21);
            Boxes.Add(this.Text, tbSW13, 21);
            Boxes.Add(this.Text, tbSW14, 21);
            Boxes.Add(this.Text, tbSW15, 21);
            Boxes.Add(this.Text, tbSW16, 21);

            Boxes.Add(this.Text, tbWorkSwitch, 21);

            for (int i = 0; i < Boxes.Count(); i++)
            {
                Boxes.Item(i).TB.Tag = Boxes.Item(i).ID;
                Boxes.Item(i).TB.Enter += tb_Enter;
                Boxes.Item(i).TB.TextChanged += tb_TextChanged;
                Boxes.Item(i).TB.Validating += tb_Validating;
            }
        }

        private void frmSwitchboxSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmSwitchboxSettings_Load(object sender, EventArgs e)
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
                // textboxes
                Boxes.ReLoad();
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp(ex.Message, this.Text, 3000, true);
            }
        }

        private void Pins_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string FileName = AppDomain.CurrentDomain.BaseDirectory + "Help\\SwitchBoxPins.pdf";
            Process.Start(new ProcessStartInfo { FileName = FileName, UseShellExecute = true });
            hlpevent.Handled = true;
        }

        private void SaveSettings()
        {
            try
            {
                // textboxes
                Boxes.Save();
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
                    ConfigEdited = true;
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
    }
}