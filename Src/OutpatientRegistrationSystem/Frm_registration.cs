using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_registration : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT no 患者编号,Name 姓名 FROM tb_patient;";
        private string mytable = "patientInfo";
        BindingSource mybds = new BindingSource();
        BindingSource mybdsource = new BindingSource();

        public Frm_registration()
        {
            InitializeComponent();
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView2.DataSource = mybdsource;
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

        private void btn_addnewpatient_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_patient") == true)
                return;
            Frm_patient frm = new Frm_patient();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void Frm_registration_Load(object sender, EventArgs e)
        {
            //初始化
            lb_operater.Text = userHelper.operatorNo + "（" + userHelper.operatorName + "）";
            tb_name.Enabled = false;
            cmb_cardtype.Enabled = false;
            tb_cardno.Enabled = false;
            tb_tel.Enabled = false;
            tb_patientNo.Enabled = false;
            tb_id.Enabled = false;

            //绑定病人信息
            this.init();
            tb_name.DataBindings.Add("text", mybdsource, "姓名");
            tb_patientNo.DataBindings.Add("text", mybdsource, "患者编号");

            //加载医生和科室
            DataSet getdocnameds = mysql.getds("select name from tb_doctor", "doctor");
            for (int i = 0; i < getdocnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_docname.Items.Add(getdocnameds.Tables[0].Rows[i][0]);
            }
            DataSet getdeptds = mysql.getds("SELECT name FROM tb_dept", "dept");
            for (int i = 0; i < getdeptds.Tables[0].Rows.Count; i++)
            {
                this.cmb_dept.Items.Add(getdeptds.Tables[0].Rows[i][0]);
            }

            //添加挂号类型和挂号费用
            DataSet getRegds = mysql.getds("SELECT name,price FROM tb_regType", "regType");
            for (int i = 0; i < getRegds.Tables[0].Rows.Count; i++)
            {
                this.cmb_regname.Items.Add(getRegds.Tables[0].Rows[i][0]);
                this.cmb_regfee.Items.Add(getRegds.Tables[0].Rows[i][1]);
            }
            this.cmb_regname.SelectedIndex = 0;
            this.cmb_regfee.SelectedIndex = 0;
            this.cmb_regfee.Enabled = false;

            //添加卡类型
            cmb_cardtype.Items.Add("就诊卡");
            cmb_cardtype.Items.Add("社保卡");
            cmb_cardtype.SelectedIndex = 0;

            this.gridviewinit();
            tb_regid.DataBindings.Add("text", mybds, "候诊号");
        }

        private void tb_patientNo_TextChanged(object sender, EventArgs e)
        {
            string tempstr = tb_patientNo.Text;
            DataSet chanagenameds = mysql.getds("SELECT visitNo,id,tel,CASE WHEN visitNo IS NULL THEN '社保卡' ELSE '就诊卡' END 卡类型 "
                + " FROM dbo.tb_patient WHERE No='" + tempstr + "';", "patient");
            tb_tel.Text = chanagenameds.Tables[0].Rows[0]["tel"].ToString();
            tb_id.Text = chanagenameds.Tables[0].Rows[0]["id"].ToString();
            tb_cardno.Text = chanagenameds.Tables[0].Rows[0]["visitNo"].ToString();
            cmb_cardtype.SelectedItem = chanagenameds.Tables[0].Rows[0]["卡类型"].ToString();
        }

        private void cmb_regname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_regname.SelectedItem.ToString();
            DataSet regfreeds = mysql.getds("SELECT price FROM tb_regType WHERE name='" + tempstr + "'", "regType");
            for (int i = 0; i < regfreeds.Tables[0].Rows.Count; i++)
            {
                this.cmb_regfee.Text = regfreeds.Tables[0].Rows[i][0].ToString();
            }
        }

        private void btn_addreg_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("挂号病人不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (cmb_dept.Text == "")
                    MessageBox.Show("请选择挂号科室！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cmb_docname.Text == "")
                        MessageBox.Show("请选择挂号医生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int rowAffected = 0;
                        try
                        {
                            rowAffected = mysql.getcom("INSERT tb_registration ( patientNo , deptNo , docNo , regDate ,regTime ,operater ) SELECT '" + tb_patientNo.Text.Trim()
                                + "',d2.NO,d1.No,'" + dtp_regDate.Value.ToShortDateString() + "','" + dtp_regTime.Value.ToShortTimeString() + "','" + userHelper.operatorNo
                                + "' FROM tb_doctor d1 JOIN tb_dept d2 ON d1.deptNo = d2.NO WHERE d1.NAME='" + cmb_docname.SelectedItem.ToString() + "' AND d2.NAME='" + cmb_dept.SelectedItem.ToString() + "';");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            MessageBox.Show("添加挂号成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.gridviewinit();
                        }
                        else
                        {
                            MessageBox.Show("添加挂号失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void gridviewinit()
        {
            DataSet view1ds = mysql.getds("SELECT r.NO 候诊号,r.patientNo 患者编号,p.Name 患者姓名,d1.NAME 挂号科室,d2.NAME 挂号医生, r.regDate 挂号日期,CONVERT(VARCHAR(5),r.regTime,114) 挂号时间 "
                + "FROM tb_registration r JOIN tb_patient p ON r.patientNo = p.No,tb_dept d1 JOIN tb_doctor d2 ON d1.NO = d2.deptNo WHERE r.patientNo=p.No AND r.docNo=d2.No "
                + "AND r.done=0 ORDER BY r.NO,r.regDate,r.regTime;", "registration");
            mybds.DataSource = view1ds.Tables[0];
            this.dataGridView1.DataSource = mybds;
        }

        private void cmb_docname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_dept.Enabled = false;
            SqlConnection conn = mysql.getcon();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT d1.name FROM tb_dept d1,tb_doctor d2 WHERE d2.NAME='" + cmb_docname.SelectedItem.ToString() + "' AND d2.deptNo=d1.NO;";
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            dr.Read();
            cmb_dept.SelectedItem = dr["Name"].ToString();
            dr.Close();
            conn.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            try
            {
                rowAffected = mysql.getcom("DELETE FROM tb_registration WHERE NO= " + tb_regid.Text.Trim() + ";");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (rowAffected == 1)
            {
                MessageBox.Show("挂号作废成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.gridviewinit();
            }
            else
            {
                MessageBox.Show("挂号作废失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_printReg_Click(object sender, EventArgs e)
        {
            //打印预览           
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();

            //设置边距
            Margins margin = new Margins(20, 20, 20, 20);
            printDocument1.DefaultPageSettings.Margins = margin;

            //纸张设置默认
            PaperSize pageSize = new PaperSize("Custum", 230, 300);
            printDocument1.DefaultPageSettings.PaperSize = pageSize;

            //打印事件设置           
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            ppd.Document = printDocument1;
            DialogResult result = ppd.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    printDocument1.PrintController.OnEndPrint(printDocument1, new PrintEventArgs());
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string name = userHelper.hospitalName;
            string title = "门 诊 预 约 凭 证";
            string address = userHelper.hospitalAddress;
            string cardno;
            if (tb_cardno.Text == "")
            {
                cardno = tb_id.Text.Trim();
            }
            else
            {
                cardno = tb_cardno.Text.Trim();
            }
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawString(name, new Font(new FontFamily("宋体"), 10, FontStyle.Bold), System.Drawing.Brushes.Black, 30, 20);
            e.Graphics.DrawString(title, new Font(new FontFamily("宋体"), 10, FontStyle.Bold), System.Drawing.Brushes.Black, 50, 35);
            e.Graphics.DrawString("卡号："+cardno, new Font(new FontFamily("宋体"), 8, FontStyle.Bold), System.Drawing.Brushes.Black, 10, 60);
            //e.Graphics.DrawString("科别：" + cardno, new Font(new FontFamily("宋体"), 8, FontStyle.Bold), System.Drawing.Brushes.Black, 10, 60);


            //sb.Append("姓名: " + cmb_name.SelectedItem.ToString() + "/n");
            //sb.Append("科别: " + cmb_dept.SelectedItem.ToString() + "/n");
            //sb.Append("医生: " + cmb_dept.SelectedItem.ToString() + "/n");
            //sb.Append("号别: " + cmb_regname.SelectedItem.ToString() + "/n");
            //sb.Append("金额: " + cmb_regfee.SelectedItem.ToString() + "/n");
            //sb.Append("-----------------------------------------------------------------/n");
            //sb.Append("预约号: 第 " + tb_regid.Text.Trim() + " 号/n");
            //sb.Append("预约时间: " + tb_regid.Text.Trim() + "/n/n");
            //sb.Append("操作员: " + userHelper.operatorName + "/n");
            //sb.Append("-----------------------------------------------------------------/n");
            //sb.Append("预约时间: " + System.DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss") + "/n");
            //sb.Append("地址：" + address + "/n");
            //sb.Append("请在挂号后立即前往指定诊区候诊/n");
            //sb.Append("                —凭此券就诊  当日有效—                   "); 
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
