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
    public partial class Frm_lock : Form
    {
        public Frm_lock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            if (tb_psw.Text.Trim() == userHelper.operaterPsw)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_psw.Focus();
                tb_psw.SelectAll();
            }
        }
    }
}
