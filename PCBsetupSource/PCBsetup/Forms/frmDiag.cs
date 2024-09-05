using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmDiag : Form
    {
        private PGN32302 Diag;
        private frmMain mf;

        public frmDiag(frmMain Main)
        {
            InitializeComponent();
            mf = Main;
            Diag = new PGN32302(mf);
            timer1.Interval = 1000;
            timer1.Enabled = true;
            this.BackColor = Properties.Settings.Default.DayColour;
            mf.SteerInfo.NewData += SteerInfo_NewData;
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDiag_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Tls.SaveFormData(this);
            timer1.Enabled = false;
        }

        private void frmDiag_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
        }

        private void SteerInfo_NewData(object sender, EventArgs e)
        {
            lbInoID.Text = mf.SteerInfo.InoID.ToString();
            lbByte1.Text = mf.SteerInfo.Debug(0).ToString();
            lbByte2.Text = mf.SteerInfo.Debug(1).ToString();
            lbByte3.Text = mf.SteerInfo.Debug(2).ToString();
            lbByte4.Text = mf.SteerInfo.Debug(3).ToString();
            lbByte5.Text = mf.SteerInfo.Debug(4).ToString();
            lbByte6.Text = mf.SteerInfo.Debug(5).ToString();
            lbWAS.Text = mf.SteerInfo.WAS.ToString("N2");
            lbHeading.Text = mf.SteerInfo.Heading.ToString("N1");
            lbTime.Text = DateTime.Now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Diag.Send();
        }
    }
}