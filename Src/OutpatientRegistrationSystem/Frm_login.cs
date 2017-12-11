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
    public partial class Frm_login : Form
    {
        sqlHelper mysql = new sqlHelper();

        public Frm_login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            texbox_userName.Focus();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (rdo_remote.Checked)
            {
                sqlHelper.sqlconstr = @"Server=192.168.189.128; Database=OPRSBase; UID=sa; Pwd=sa";
            }
            if (rdo_backup.Checked)
            {
                sqlHelper.sqlconstr = @"Server=SERVER-1; Database=OPRSBase; UID=jsj; Pwd=2wsx@WSX";
            }
            if (rdo_local.Checked)
            {
                sqlHelper.sqlconstr = @"Server=(local); Database=OPRSBase; Integrated Security=sspi";
            }
            if (texbox_psw.Text == "")
            {
                userHelper.operatorNo = texbox_userName.Text.Trim();
                SqlConnection conn = mysql.getcon();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT COUNT(1) FROM tb_operator WHERE No='" + userHelper.operatorNo + "' AND password IS NULL;";
                conn.Open();
                int rowCount = (int)comm.ExecuteScalar();
                conn.Close();
                if (rowCount == 1)
                {
                    this.Enabled = false;
                    Frm_firstTimeLogin frm = new Frm_firstTimeLogin();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texbox_userName.Focus();
                    texbox_userName.SelectAll();
                }
            }
            else
            {
                SqlConnection conn = mysql.getcon();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM tb_operator WHERE No=@No AND Password=HASHBYTES('SHA',@Password);";
                comm.Parameters.AddWithValue("@No", this.texbox_userName.Text.Trim());
                comm.Parameters["@No"].SqlDbType = SqlDbType.VarChar;
                comm.Parameters.AddWithValue("@Password", this.texbox_psw.Text.Trim());
                comm.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    this.DialogResult = DialogResult.OK;
                    userHelper.operatorNo = this.texbox_userName.Text.Trim();
                    userHelper.operatorName = dr["Name"].ToString();
                    userHelper.operatorPsw = this.texbox_psw.Text.Trim();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.texbox_psw.Focus();
                    this.texbox_psw.SelectAll();
                }
                dr.Close();
                conn.Close();
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

        private void Frm_login_Load(object sender, EventArgs e)
        {
            this.Text += userHelper.hospitalName;
            rdo_remote.Select();
        }
    }
}
