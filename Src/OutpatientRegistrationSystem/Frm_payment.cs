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
        private string sqlstr="SELECT e.ticketNo 票号,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期 "
            +"FROM dbo.tb_expensesRecord e JOIN dbo.tb_patient p ON e.patientNo=p.No	JOIN dbo.tb_doctor d ON e.docNo=d.No 	JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO JOIN dbo.tb_registration r ON e.regNo=r.NO "
            + "WHERE e.havePaid IS NULL AND r.regDate='" + System.DateTime.Now.ToShortDateString() + "';";
        private string mytable = "expensesRecord";
        BindingSource mybdsource = new BindingSource();

        public Frm_payment()
        {
            InitializeComponent();
        }

        private void Frm_payment_Load(object sender, EventArgs e)
        {
            //初始化
            cmb_cardType.Items.Add("就诊卡");
            cmb_cardType.Items.Add("社保卡");
            cmb_paymentallman.Items.Add("今日未缴费");
            cmb_paymentallman.Items.Add("所有未缴费");
            cmb_paymentallman.SelectedIndex = 0;

            //绑定数据   //bug:数据未绑定
            DataSet nopayds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = nopayds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
            tb_ticketNo.DataBindings.Add("text", mybdsource, "票号");
            tb_patientNo.DataBindings.Add("text", mybdsource, "患者编号");
            tb_patientname.DataBindings.Add("text", mybdsource, "患者姓名");
            tb_dept.DataBindings.Add("text", mybdsource, "就诊科室");
            tb_doctor.DataBindings.Add("text", mybdsource, "就诊医生");

            //只可查看
            tb_ticketNo.Enabled = false;
            tb_mediRecordNo.Enabled = false;
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
                DataSet nopayds = mysql.getds(sqlstr, mytable);
                this.dataGridView1.DataSource = nopayds.Tables[0];
            }
            if (cmb_paymentallman.SelectedItem.ToString() == "所有未缴费")
            {
                DataSet nopayds = mysql.getds("SELECT e.ticketNo 票号,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期 "
            + "FROM dbo.tb_expensesRecord e JOIN dbo.tb_patient p ON e.patientNo=p.No	JOIN dbo.tb_doctor d ON e.docNo=d.No 	JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO JOIN dbo.tb_registration r ON e.regNo=r.NO "
            + "WHERE e.havePaid IS NULL;", "expensesRecord");
                this.dataGridView1.DataSource = nopayds.Tables[0];
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

        }

        private void tb_ticketNo_TextChanged(object sender, EventArgs e)
        {
            DataSet payfeeds = mysql.getds("SELECT e.medicineFee 药品费,e.examFee 检验费,e.checkFee 检查费,e.diagFee 诊疗费,e.regFee 挂号费 "
                +"FROM dbo.tb_expensesRecord e "
                +"WHERE e.ticketNo='"+tb_ticketNo.Text.Trim()+"';","payfeeds");
            this.dataGridView2.DataSource = payfeeds.Tables[0];

        }

    }
}
