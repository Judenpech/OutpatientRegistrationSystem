﻿using System;
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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            texbox_userName.Focus();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=(local);Database=ORSBase;Integrated Security=sspi";
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT COUNT(1) FROM tb_operator WHERE No=@No AND Password=HASHBYTES('MD5',@Password);";
            comm.Parameters.AddWithValue("@No", this.texbox_userName.Text.Trim());
            comm.Parameters["@No"].SqlDbType = SqlDbType.VarChar;
            comm.Parameters.AddWithValue("@Password", this.texbox_psw.Text.Trim());
            comm.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            conn.Open();
            int rowCount = (int)comm.ExecuteScalar();
            conn.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                userhelp.operaterNo = this.texbox_userName.Text.Trim();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.texbox_psw.Focus();
                this.texbox_psw.SelectAll();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出系统吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
