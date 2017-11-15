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
    public partial class Frm_operator : Form
    {
        sqlHelper mysql = new sqlHelper();
        public Frm_operator()
        {
            InitializeComponent();
        }

        private void Frm_operator_Load(object sender, EventArgs e)
        {
            //只可查看
            tb_name.Enabled = false;
            tb_no.Enabled = false;

            //加载操作员个人信息
            tb_no.Text = userHelper.operatorNo;
            tb_name.Text = userHelper.operatorName;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_oldPsw.Text = "";
            tb_newPsw.Text = "";
            tb_confirmPsw.Text = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tb_oldPsw.Text == "")
            {
                MessageBox.Show("原密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_oldPsw.Focus();
            }
            else
            {
                if (tb_oldPsw.Text.Trim() != userHelper.operatorPsw)
                {
                    MessageBox.Show("旧密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_oldPsw.Focus();
                    tb_oldPsw.SelectAll();
                }
                else
                {
                    if (tb_newPsw.Text == "")
                    {
                        MessageBox.Show("新密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_newPsw.Focus();
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
                                    rowAffected = mysql.getcom("UPDATE tb_operator SET password=HASHBYTES('SHA','" + tb_newPsw.Text.Trim() + "') WHERE No='" + tb_no.Text.Trim() + "';");
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
            }
        }
    }
}
