using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_needpay : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT c.patientNo 患者编号,p.Name 病人姓名,CASE c.cardType WHEN 0 THEN '就诊卡' WHEN 1 THEN '社保卡' END 卡类型,"
            + "c.id 身份证号码,c.visitNo 就诊卡号,c.balance 欠款总计 "
            + "FROM tb_card c JOIN tb_patient p ON c.patientNo=p.No "
            + "WHERE c.patientNo=p.No AND c.balance<0;";
        private string mytable = "patient";
        BindingSource mybdsource = new BindingSource();

        public Frm_needpay()
        {
            InitializeComponent();
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = myds.Tables[0];
        }

        private void Frm_needpay_Load(object sender, EventArgs e)
        {
            //只可查看
            tb_patientno.Enabled = false;
            tb_name.Enabled = false;
            cmb_cardType.Enabled = false;
            tb_id.Enabled = false;
            tb_cardNo.Enabled = false;
            tb_tel.Enabled = false;
            tb_email.Enabled = false;
            tb_balance.Enabled = false;

            //初始化
            cmb_cardType.Items.Add("就诊卡");
            cmb_cardType.Items.Add("社保卡");

            //绑定数据
            this.init();
            tb_patientno.DataBindings.Add("text", mybdsource, "患者编号");
            tb_name.DataBindings.Add("text", mybdsource, "病人姓名");
            cmb_cardType.DataBindings.Add("text", mybdsource, "卡类型");
            tb_id.DataBindings.Add("text", mybdsource, "身份证号码");
            tb_cardNo.DataBindings.Add("text", mybdsource, "就诊卡号");
            tb_balance.DataBindings.Add("text", mybdsource, "欠款总计");
        }

        private void tb_patientno_TextChanged(object sender, EventArgs e)
        {
            if (tb_patientno.Text == "")
            {
                tb_tel.Text = "";
                tb_email.Text = "";
            }
            else
            {
                SqlConnection conn = mysql.getcon();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT tel,email FROM dbo.tb_patient WHERE No='" + tb_patientno.Text.Trim() + "';";
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    tb_tel.Text = dr["tel"].ToString();
                    tb_email.Text = dr["email"].ToString();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            if (tb_patientno.Text == "")
            {
                MessageBox.Show("请选择催款人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MailMessage msg = new MailMessage();
                msg.To.Add(tb_email.Text.Trim());
                msg.From = new MailAddress("test@abc.com", userHelper.operatorName, Encoding.UTF8);
                msg.Subject = "XX医院催款通知";
                msg.SubjectEncoding = Encoding.UTF8;
                String mailstr = "尊敬的患者 " + tb_name.Text.Trim() + "：\n"
                    + "\n您至今已拖欠本院医疗费用 " + Math.Abs(Convert.ToSingle(tb_balance.Text.Trim())) + " 元。\n"
                    + "1、请您在收到本通知10日内到我院住院部交费处补交金额 " + Math.Abs(Convert.ToSingle(tb_balance.Text.Trim())) + " 元；\n"
                    + "2、在您刚入院时，您签署了住院须知，您已承诺遵守医院管理规定，按时足额缴纳医药费用，请您履行您的承诺； \n"
                    + "3、如您在接到本通知后，既不缴费又不与我院相关部门联系，我们在10日后将视作您放弃治疗，医院将给您采取维持生命的一般治疗。"
                    + "此措施将有可能产生下列后果： \n"
                    + "(1) 您治疗的时间将延长； \n(2) 您原有疾病可能加重或复发； \n(3) 您以后的治疗可能会增加困难； "
                    + "\n(4)您治疗的中断，使原已花费的医疗费用可能重复或增加； \n(5) 其他。"
                    + "\n4、如果您既不缴费又不与我院相关部门联系协商解决，我们将依据相关规定寻求法律途径解决，由此产生的后果将由您自行承担。 \n"
                    + "\nXX医院\n" + System.DateTime.Now.ToString("yyyy年MM月dd日");
                msg.Body = mailstr;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = false;
                msg.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();
                client.Host = "localhost";
                object userState = msg;
                DialogResult dr = MessageBox.Show(mailstr, "确认邮件内容", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        client.SendAsync(msg, userState);
                        MessageBox.Show("邮件发送成功！");
                    }
                    catch (SmtpException ex)
                    {
                        MessageBox.Show("邮件发送出错：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (nud_pay.Value != 0)
            {
                try
                {
                    rowAffected = mysql.getcom("UPDATE tb_card SET balance=" + (Convert.ToSingle(nud_pay.Value) + Convert.ToSingle(tb_balance.Text.Trim()))
                        + " WHERE patientNo='" + tb_patientno.Text.Trim() + "';");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("还款成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    nud_pay.Value = 0;
                }
                else
                {
                    MessageBox.Show("还款失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("本次还款额不能为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nud_pay.Focus();
            }
            this.init();
        }
    }
}
