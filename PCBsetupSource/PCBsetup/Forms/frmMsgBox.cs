using System;
using System.Windows.Forms;

namespace PCBsetup.Forms
{
    public partial class frmMsgBox : Form
    {
        private frmMain mf;

        public frmMsgBox(frmMain CallingForm, string Message, string Title = "Help", bool Shrink = false)
        {
            InitializeComponent();
            mf = CallingForm;
            this.Text = Title;
            label1.Text = Message;
            Properties.Settings.Default.MsgBoxResult = false;

            if (Shrink)
            {
                panel1.Height = 60;
                this.Height = 198;
                btnCancel.Top = 78;
                bntOK.Top = 78;
            }
            else
            {
                panel1.Height = 303;
                this.Height = 441;
                btnCancel.Top = 321;
                bntOK.Top = 321;
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MsgBoxResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMsgBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) mf.Tls.SaveFormData(this);
        }

        private void frmMsgBox_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.DayColour;
            mf.Tls.LoadFormData(this);
        }
    }
}