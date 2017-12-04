using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_firstTimeLogin : Form
    {
        sqlHelper mysql = new sqlHelper();

        public Frm_firstTimeLogin()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_newPsw.Text = "";
            tb_confirmPsw.Text = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_newPsw.Text == "")
            {
                MessageBox.Show("新密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tb_confirmPsw.Text == "")
                {
                    MessageBox.Show("请再次输入新密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_confirmPsw.Focus();
                }
                else
                {
                    if (tb_newPsw.Text != tb_confirmPsw.Text)
                    {
                        MessageBox.Show("两次输入的新密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int rowAffected = 0;
                        try
                        {
                            rowAffected = mysql.getcom("UPDATE tb_operator SET password=HASHBYTES('SHA','" + tb_newPsw.Text.Trim() + "') WHERE No='" + userHelper.operatorNo + "';");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            MessageBox.Show("密码修改成功，请重新登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Application.Restart();
                        }
                    }
                }
            }

        }

        private void Frm_firstTimeLogin_Load(object sender, EventArgs e)
        {
            tb_oldPsw.Enabled = false;
        }
    }
}
