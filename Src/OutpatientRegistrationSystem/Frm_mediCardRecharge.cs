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
    public partial class Frm_mediCardRecharge : Form
    {
        sqlHelper mysql = new sqlHelper();

        public Frm_mediCardRecharge()
        {
            InitializeComponent();
        }

        private void Frm_mediCardRecharge_Load(object sender, EventArgs e)
        {
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
            rdo_cash.Select();
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
            if (rdo_visitno.Checked)
            {
                string tempstr = tb_searchvn.Text.Trim();
                DataSet visitNods = mysql.getds("SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额 "
                    + "FROM tb_patient p JOIN tb_card c ON p.No=c.patientNo WHERE p.visitNo='" + tempstr + "';", "visitNo");
                if (visitNods.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("您输入的就诊卡号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_searchvn.Focus();
                    tb_searchvn.SelectAll();
                }
                else
                {
                    tb_patientno.Text = visitNods.Tables[0].Rows[0]["患者编号"].ToString();
                    tb_name.Text = visitNods.Tables[0].Rows[0]["患者姓名"].ToString();
                    tb_cardno.Text = visitNods.Tables[0].Rows[0]["就诊卡号"].ToString();
                    tb_balance.Text = visitNods.Tables[0].Rows[0]["余额"].ToString();
                }
            }
            if (rdo_patientno.Checked)
            {
                string tempstr = tb_searchPatienNo.Text.Trim();
                DataSet patientnods = mysql.getds("SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额"
                    + " FROM tb_patient p JOIN tb_card c ON p.No=c.patientNo "
                    + "WHERE p.No='" + tempstr + "' AND p.visitNo IS NOT NULL;", "patientno");
                if (patientnods.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("您输入的患者编号不存在或该患者没有就诊卡，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_searchPatienNo.Focus();
                    tb_searchPatienNo.SelectAll();
                }
                else
                {
                    tb_patientno.Text = patientnods.Tables[0].Rows[0]["患者编号"].ToString();
                    tb_name.Text = patientnods.Tables[0].Rows[0]["患者姓名"].ToString();
                    tb_cardno.Text = patientnods.Tables[0].Rows[0]["就诊卡号"].ToString();
                    tb_balance.Text = patientnods.Tables[0].Rows[0]["余额"].ToString();
                }
            }
        }

        private void cmb_searchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_searchName.Text.Trim();
            DataSet patientnameds = mysql.getds("SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额"
                + " FROM tb_patient p JOIN tb_card c ON p.No=c.patientNo "
                + "WHERE p.Name='" + tempstr + "' AND p.visitNo IS NOT NULL;", "patientname");
            tb_patientno.Text = patientnameds.Tables[0].Rows[0]["患者编号"].ToString();
            tb_name.Text = patientnameds.Tables[0].Rows[0]["患者姓名"].ToString();
            tb_cardno.Text = patientnameds.Tables[0].Rows[0]["就诊卡号"].ToString();
            tb_balance.Text = patientnameds.Tables[0].Rows[0]["余额"].ToString();
        }

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (rdo_cash.Checked)
            {
                try
                {
                    rowAffected = mysql.getcom("UPDATE tb_card SET balance=" + Convert.ToSingle(nud_money.Value) + " WHERE patientNo='" + tb_patientno.Text.Trim() + "';");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("充值成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    nud_money.Value = 0;
                }
                else
                {
                    MessageBox.Show("充值失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("充值金额不能为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_money.Focus();
            }
            if (rdo_creditCard.Checked) //待添加
            {
            }
            if (rdo_alipay.Checked)
            {
            }
            if (rdo_wechat.Checked)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_balanceQuery") == true)
                return;
            Frm_balanceQuery frm = new Frm_balanceQuery();
            frm.MdiParent = this.MdiParent;
            frm.Show();
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
    }
}
