using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmMonitorEthernet : Form
    {
        private bool FreezeUpdate;
        private frmMain mf;
        private bool RequestSent = false;
        private PGN32504 Status;

        public frmMonitorEthernet(frmMain CallingForm)
        {
            InitializeComponent();
            mf = CallingForm;
            this.BackColor = PCBsetup.Properties.Settings.Default.DayColour;
            tbMonitor.BackColor = PCBsetup.Properties.Settings.Default.DayColour;
            Status = new PGN32504(mf);
            mf.ModuleStatus.NewData += ModuleStatus_NewData;
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(mf.Tls.AppDir() + "\\Ethernet Log.txt", tbMonitor.Text);
                mf.Tls.ShowHelp("File saved.", "Save", 10000);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("frmMonitorEthernet/btnSave_Click: " + ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FreezeUpdate = !FreezeUpdate;
            timer1.Enabled = !FreezeUpdate;
            UpdateForm();
        }

        private void frmMonitorEthernet_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmMonitorEthernet_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
            timer1.Enabled = true;
            UpdateForm();
        }

        private void ModuleStatus_NewData(object sender, EventArgs e)
        {
            var newStatus = new StringBuilder();
            newStatus.AppendLine();
            newStatus.AppendLine("Firmware version:\t" + mf.ModuleStatus.FirmwareVersion);
            newStatus.AppendLine("IMU heading:\t" + mf.ModuleStatus.IMUheading);
            newStatus.AppendLine("WAS counts:\t" + mf.ModuleStatus.WASreading);
            newStatus.AppendLine("Zero offset:\t" + mf.ModuleStatus.ZeroOffset);
            newStatus.AppendLine("Net WAS counts:\t" + mf.ModuleStatus.CurrentWAS);
            newStatus.AppendLine("Analog counts:\t" + mf.ModuleStatus.AnalogReading);
            newStatus.AppendLine("IMU enabled:\t" + mf.ModuleStatus.IMUenabled);
            newStatus.AppendLine("Receiver enabled:\t" + mf.ModuleStatus.ReceiverEnabled);
            newStatus.AppendLine("RS232 enabled:\t" + mf.ModuleStatus.PassThruEnabled);
            newStatus.AppendLine("ADS1115 found:\t" + mf.ModuleStatus.ADS1115Found);
            newStatus.AppendLine("AOG connected:\t" + mf.ModuleStatus.AOGconnected);
            newStatus.AppendLine("Steering On:\t" + mf.ModuleStatus.SteeringOn);
            newStatus.AppendLine("Steer switch On:\t" + mf.ModuleStatus.SteerSwitchOn);
            newStatus.AppendLine("Loop time (micros):\t" + mf.ModuleStatus.MaxLoopTime);

            tbMonitor.SuspendLayout();
            tbMonitor.Text += newStatus.ToString();

            if (tbMonitor.Text.Length > 20000)
            {
                tbMonitor.Text = tbMonitor.Text.Substring(tbMonitor.Text.Length - 1000);
            }
            tbMonitor.Select(tbMonitor.Text.Length, 0);
            tbMonitor.ScrollToCaret();
            tbMonitor.ResumeLayout();

            RequestSent = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateForm();
            if (RequestSent) tbMonitor.AppendText(".");
            RequestSent = true;
        }

        private void UpdateForm()
        {
            if (FreezeUpdate)
            {
                btnStart.Image = Properties.Resources.Start;
            }
            else
            {
                btnStart.Image = Properties.Resources.Pause;
                Status.Send();
            }
        }
    }
}