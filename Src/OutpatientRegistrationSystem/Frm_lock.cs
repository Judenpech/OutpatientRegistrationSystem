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
            if (tb_psw.Text.Trim() == userHelper.operatorPsw)
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

        private void Frm_lock_Load(object sender, EventArgs e)
        {
            texbox_userName.Text = userHelper.operatorNo;
            texbox_userName.Enabled = false;
            label1.Text = "本系统正在使用中，且已被锁定。\n请输入当前用户密码解除锁定。";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出系统吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
