using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_appointment : Form
    {
        public Frm_appointment()
        {
            InitializeComponent();
        }

        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiParent.MdiChildren)
            {
                if (childFrm.Name == childfrmname)
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)
                        childFrm.WindowState = FormWindowState.Normal;
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btn_addnewpatient_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_patient") == true)
                return;
            Frm_patient frm = new Frm_patient();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
