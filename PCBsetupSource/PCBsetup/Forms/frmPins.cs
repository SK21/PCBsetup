﻿using System;
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
    public partial class frmPins : Form
    {
        public frmMain mf;
        public frmPins(frmMain Main)
        {
            InitializeComponent();
            mf = Main;
        }

        private void frmPins_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                mf.Tls.SaveFormData(this);
            }
        }

        private void frmPins_Load(object sender, EventArgs e)
        {
            mf.Tls.LoadFormData(this);
            this.BackColor = Properties.Settings.Default.DayColour;
        }
    }
}
