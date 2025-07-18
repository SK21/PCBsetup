using System;
using System.IO;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmMonitor : Form
    {
        private bool FreezeUpdate;
        private frmMain mf;

        public frmMonitor(frmMain CallingForm)
        {
            InitializeComponent();
            mf = CallingForm;
            this.BackColor = PCBsetup.Properties.Settings.Default.DayColour;
            tbMonitor.BackColor=PCBsetup.Properties.Settings.Default.DayColour;
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(mf.Tls.AppDir() + "\\Serial Log.txt", tbMonitor.Text);
                mf.Tls.ShowHelp("File saved.", "Save", 10000);
            }
            catch (Exception ex)
            {
                mf.Tls.WriteErrorLog("frmMonitor/btnSave_Click: " + ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FreezeUpdate = !FreezeUpdate;
            UpdateForm();
        }

        private void frmMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
            timer1.Enabled = true;
            UpdateForm();
        }

        private void tbMonitor_Click(object sender, EventArgs e)
        {
            FreezeUpdate = !FreezeUpdate;
            UpdateForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!FreezeUpdate)
            {
                tbMonitor.Text = mf.CommPort.Log();
                tbMonitor.Select(tbMonitor.Text.Length, 0);
                tbMonitor.ScrollToCaret();
            }
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
            }
        }
    }
}