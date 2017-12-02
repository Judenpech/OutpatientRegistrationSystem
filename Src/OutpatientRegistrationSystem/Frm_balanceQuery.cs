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
    public partial class Frm_balanceQuery : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT p.No 患者编号,p.Name 患者姓名,c.visitNo 就诊卡号,c.balance 余额 "
            + "FROM tb_patient p JOIN tb_card c ON p.No=c.patientNo AND p.visitNo=c.visitNo "
            + "WHERE c.cardType=0;";
        private string mytable = "card";
        BindingSource mybdsource = new BindingSource();

        public Frm_balanceQuery()
        {
            InitializeComponent();
        }

        private void Frm_balanceQuery_Load(object sender, EventArgs e)
        {
            this.init();
            tb_patientno.DataBindings.Add("text", mybdsource, "患者编号");
            tb_name.DataBindings.Add("text", mybdsource, "患者姓名");
            tb_cardno.DataBindings.Add("text", mybdsource, "就诊卡号");
            tb_balance.DataBindings.Add("text", mybdsource, "余额");

            //添加已有病人供检索
            DataSet getnameds = mysql.getds("SELECT Name FROM tb_patient WHERE visitNo IS NOT NULL;", "patient");
            for (int i = 0; i < getnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_searchName.Items.Add(getnameds.Tables[0].Rows[i][0]);
            }
            this.cmb_searchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmb_searchName.AutoCompleteSource = AutoCompleteSource.ListItems;

            //只可查看
            tb_patientno.Enabled = false;
            tb_name.Enabled = false;
            tb_cardno.Enabled = false;
            tb_balance.Enabled = false;

            rdo_visitno.Select();
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_searchvn.Text = "";
            tb_searchPatienNo.Text = "";
            cmb_searchName.Text = "";
            rdo_visitno.Select();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int rowCount = 0;
            if (rdo_visitno.Checked)
            {
                SqlConnection conn = mysql.getcon();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT COUNT(1) FROM tb_card c WHERE c.visitNo='" + tb_searchvn.Text.Trim() + "';";
                conn.Open();
                rowCount = (int)comm.ExecuteScalar();
                conn.Close();
                if (rowCount == 1)
                {
                    tb_cardno.Text = tb_searchvn.Text.Trim();
                }
                else
                {
                    MessageBox.Show("您输入的就诊卡号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_searchvn.Focus();
                    tb_searchvn.SelectAll();
                }
            }
            if (rdo_patientno.Checked)
            {
                SqlConnection conn = mysql.getcon();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT COUNT(1) FROM tb_card c WHERE c.patientNo='" + tb_searchPatienNo.Text.Trim() + "' AND c.cardType=0;";
                conn.Open();
                rowCount = (int)comm.ExecuteScalar();
                conn.Close();
                if (rowCount == 1)
                {
                    tb_patientno.Text = tb_searchPatienNo.Text.Trim();
                }
                else
                {
                    MessageBox.Show("您输入的患者编号不存在或该患者没有就诊卡，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_searchPatienNo.Focus();
                    tb_searchPatienNo.SelectAll();
                }
            }
        }

        private void cmb_searchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_name.Text = cmb_searchName.Text.Trim();
        }
    }
}
