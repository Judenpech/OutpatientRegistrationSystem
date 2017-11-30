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
    public partial class Frm_deptQuery : Form
    {
        sqlHelper mysql = new sqlHelper();

        public Frm_deptQuery()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_schNo.Text = "";
            cmb_searchName.Text = "";
        }

        private void Frm_deptQuery_Load(object sender, EventArgs e)
        {
            //添加已有科室供检索
            DataSet getnameds = mysql.getds("SELECT NAME FROM tb_dept;", "dept");
            for (int i = 0; i < getnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_searchName.Items.Add(getnameds.Tables[0].Rows[i][0]);
            }
            this.cmb_searchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmb_searchName.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            //初始化
            tb_id.Enabled = false;
            tb_name.Enabled = false;
            rtb_dscp.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = mysql.getcon();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT NO,NAME,DSCP FROM tb_dept WHERE NO=" + tb_schNo.Text.Trim() + ";";
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                tb_id.Text = dr["NO"].ToString();
                tb_name.Text = dr["NAME"].ToString();
                rtb_dscp.Text = dr["DSCP"].ToString();
            }
            else
            {
                MessageBox.Show("科室编号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_schNo.Focus();
                tb_schNo.SelectAll();
            }
            dr.Close();
            conn.Close();
        }

        private void cmb_searchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_searchName.Text;
            DataSet chanagenameds = mysql.getds("SELECT NO,NAME,DSCP FROM tb_dept WHERE NAME='" + tempstr + "';", "dept");
            tb_id.Text = chanagenameds.Tables[0].Rows[0]["NO"].ToString();
            tb_name.Text = chanagenameds.Tables[0].Rows[0]["NAME"].ToString();
            rtb_dscp.Text = chanagenameds.Tables[0].Rows[0]["DSCP"].ToString();
        }
    }
}
