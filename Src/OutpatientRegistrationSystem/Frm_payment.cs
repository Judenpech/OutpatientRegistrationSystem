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
    public partial class Frm_payment : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT e.ticketNo 票号,e.regNo 挂号号码,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期 "
            + "FROM dbo.tb_expensesRecord e JOIN dbo.tb_patient p ON e.patientNo=p.No	JOIN dbo.tb_doctor d ON e.docNo=d.No 	JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO JOIN dbo.tb_registration r ON e.regNo=r.NO "
            + "WHERE e.havePaid=0 AND r.regDate='" + System.DateTime.Now.ToShortDateString() + "';";
        private string mytable = "expensesRecord";
        BindingSource mybdsource = new BindingSource();

        public Frm_payment()
        {
            InitializeComponent();
        }

        private void init()
        {
            DataSet nopayds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = nopayds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
        }

        private void Frm_payment_Load(object sender, EventArgs e)
        {
            //初始化
            cmb_cardType.Items.Add("就诊卡");
            cmb_cardType.Items.Add("社保卡");
            cmb_paymentallman.Items.Add("今日未缴费");
            cmb_paymentallman.Items.Add("所有未缴费");
            cmb_paymentallman.SelectedIndex = 0;

            //绑定数据  
            this.init();
            tb_ticketNo.DataBindings.Add("text", mybdsource, "票号");
            tb_regNo.DataBindings.Add("text", mybdsource, "挂号号码");
            tb_patientNo.DataBindings.Add("text", mybdsource, "患者编号");
            tb_patientname.DataBindings.Add("text", mybdsource, "患者姓名");
            tb_dept.DataBindings.Add("text", mybdsource, "就诊科室");
            tb_doctor.DataBindings.Add("text", mybdsource, "就诊医生");

            //只可查看
            tb_ticketNo.Enabled = false;
            tb_patientNo.Enabled = false;
            tb_patientname.Enabled = false;
            tb_regNo.Enabled = false;
            cmb_cardType.Enabled = false;
            tb_id.Enabled = false;
            tb_cardNo.Enabled = false;
            tb_doctor.Enabled = false;
            tb_dept.Enabled = false;
            tb_medicineFee.Enabled = false;
            tb_examFee.Enabled = false;
            tb_checkFee.Enabled = false;
            tb_diagFee.Enabled = false;
            tb_balance.Enabled = false;
            tb_creditLimit.Enabled = false;
            tb_regFee.Enabled = false;
            tb_total.Enabled = false;
        }

        private void btn_payprint_Click(object sender, EventArgs e)
        {
            Frm_printReceipt frm = new Frm_printReceipt();
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

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_mediCardRecharge") == true)
                return;
            Frm_mediCardRecharge frm = new Frm_mediCardRecharge();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void cmb_paymentallman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_paymentallman.SelectedItem.ToString() == "今日未缴费")
            {
                sqlstr = "SELECT e.ticketNo 票号,e.regNo 挂号号码,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期 "
            + "FROM dbo.tb_expensesRecord e JOIN dbo.tb_patient p ON e.patientNo=p.No	JOIN dbo.tb_doctor d ON e.docNo=d.No 	JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO JOIN dbo.tb_registration r ON e.regNo=r.NO "
            + "WHERE e.havePaid=0 AND r.regDate='" + System.DateTime.Now.ToShortDateString() + "';";
                this.init();
            }
            if (cmb_paymentallman.SelectedItem.ToString() == "所有未缴费")
            {
                sqlstr = "SELECT e.ticketNo 票号,e.regNo 挂号号码,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期 "
            + "FROM dbo.tb_expensesRecord e JOIN dbo.tb_patient p ON e.patientNo=p.No	JOIN dbo.tb_doctor d ON e.docNo=d.No 	JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO JOIN dbo.tb_registration r ON e.regNo=r.NO "
            + "WHERE e.havePaid=0;";
                this.init();
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (Convert.ToDouble(tb_total.Text.Trim()) <= Convert.ToDouble(tb_balance.Text.Trim()))
            {
                //账户余额充足
                try
                {
                    rowAffected = mysql.getcom("UPDATE tb_expensesRecord SET havePaid=1 " + ",payDate='" + dtp_paydate.Value.ToString() + "'" + " WHERE ticketNo='" + tb_ticketNo.Text.Trim() + "';");
                    rowAffected += mysql.getcom("UPDATE tb_card SET balance=" + (Convert.ToDouble(tb_balance.Text.Trim()) - Convert.ToDouble(tb_total.Text.Trim()))
                        + " WHERE patientNo='" + tb_patientNo.Text.Trim() + "';");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 2)
                {
                    MessageBox.Show("付款成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("付款失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //账户余额不足
            {
                if (Convert.ToDouble(tb_balance.Text.Trim()) + Convert.ToDouble(tb_creditLimit.Text.Trim()) >= Convert.ToDouble(tb_total.Text.Trim()))
                {
                    //余额加上信用额度足够支付
                    try
                    {
                        rowAffected = mysql.getcom("UPDATE tb_expensesRecord SET havePaid=1 " + ",payDate='" + dtp_paydate.Value.ToString() + "'" + " WHERE ticketNo='" + tb_ticketNo.Text.Trim() + "';");
                        rowAffected += mysql.getcom("UPDATE tb_card SET balance=" + (Convert.ToDouble(tb_balance.Text.Trim()) - Convert.ToDouble(tb_total.Text.Trim()))
                            + " WHERE patientNo='" + tb_patientNo.Text.Trim() + "';");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowAffected == 2)
                    {
                        MessageBox.Show("信用额度付款成功，已欠费 " + (Convert.ToDouble(tb_total.Text.Trim()) - Convert.ToDouble(tb_balance.Text.Trim())) + " 元，请及时补交欠费款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("付款失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    //余额加上信用额度任然不够支付
                    MessageBox.Show("余额不足，请先进行充值！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            this.init();
        }
        private void clear()
        {
            tb_medicineFee.Text = "";
            tb_examFee.Text = "";
            tb_checkFee.Text = "";
            tb_diagFee.Text = "";
            tb_regFee.Text = "";
            tb_total.Text = "";
            tb_creditLimit.Text = "";
            tb_balance.Text = "";
            tb_total.Text = "";
            tb_cardNo.Text = "";
        }

        private void tb_ticketNo_TextChanged(object sender, EventArgs e)
        {
            if (tb_ticketNo.Text == "")
            {
                this.clear();
            }
            DataSet payfeeds = mysql.getds("SELECT e.medicineFee 药品费,e.examFee 检验费,e.checkFee 检查费,e.diagFee 诊疗费,e.regFee 挂号费 "
                + "FROM dbo.tb_expensesRecord e "
                + "WHERE e.ticketNo='" + tb_ticketNo.Text.Trim() + "';", "payfeeds");
            this.dataGridView2.DataSource = payfeeds.Tables[0];
            tb_medicineFee.Text = payfeeds.Tables[0].Rows[0][0].ToString();
            tb_examFee.Text = payfeeds.Tables[0].Rows[0][1].ToString();
            tb_checkFee.Text = payfeeds.Tables[0].Rows[0][2].ToString();
            tb_diagFee.Text = payfeeds.Tables[0].Rows[0][3].ToString();
            tb_regFee.Text = payfeeds.Tables[0].Rows[0][4].ToString();
            tb_total.Text = Convert.ToString(Convert.ToDouble(tb_medicineFee.Text) + Convert.ToDouble(tb_examFee.Text) + Convert.ToDouble(tb_checkFee.Text) + Convert.ToDouble(tb_diagFee.Text) + Convert.ToDouble(tb_regFee.Text));
        }

        private void tb_patientNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = mysql.getcon();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT cardType,id,visitNo,balance,creditLimit FROM dbo.tb_card WHERE patientNo='" + tb_patientNo.Text.Trim() + "';";
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                cmb_cardType.SelectedIndex = Convert.ToInt32(dr["cardType"]);
                tb_id.Text = dr["id"].ToString();
                tb_cardNo.Text = dr["visitNo"].ToString();
                tb_balance.Text = dr["balance"].ToString();
                tb_creditLimit.Text = dr["creditLimit"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        private void btn_needpay_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_needpay") == true)
                return;
            Frm_needpay frm = new Frm_needpay();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
