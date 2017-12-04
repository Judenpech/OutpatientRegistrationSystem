using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_exit : Form
    {
        public Frm_exit()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (rdo_exitSystem.Checked)
            {
                Application.Exit();
            }
            if (rdo_restartWindows.Checked)
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "shutdown.exe";
                ps.Arguments = "-r -t 1";
                Process.Start(ps);
            }
            if (rdo_closeWindows.Checked)
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "shutdown.exe";
                ps.Arguments = "-s -t 1";
                Process.Start(ps);
            }
        }

        private void Frm_exit_Load(object sender, EventArgs e)
        {
            rdo_exitSystem.Select();
        }
    }
}
