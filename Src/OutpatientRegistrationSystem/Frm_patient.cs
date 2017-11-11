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
    public partial class Frm_patient : Form
    {
        sqlHelper mysql = new sqlHelper();
        public Frm_patient()
        {
            InitializeComponent();
        }

        private void Frm_patient_Load(object sender, EventArgs e)
        {
            //添加已有病人供检索使用


            //添加性别
            cmb_sex.Items.Add("男");
            cmb_sex.Items.Add("女");
            cmb_sex.SelectedIndex = 0;
            
            //添加卡类型
            cmb_cardtype.Items.Add("就诊卡");
            cmb_cardtype.Items.Add("社保卡");
            cmb_cardtype.SelectedIndex = 0;

            //只可查看
            tb_address.Enabled = false;
            tb_age.Enabled = false;
            tb_balance.Enabled = false;
            tb_cardNo.Enabled = false;
            tb_cellphone.Enabled = false;
            tb_creditlimit.Enabled = false;
            tb_email.Enabled = false;
            tb_firstman1.Enabled = false;
            tb_firstphone1.Enabled = false;
            tb_firstman2.Enabled = false;
            tb_firstphone2.Enabled = false;
            tb_hispass.Enabled = false;
            tb_id.Enabled = false;
            tb_name.Enabled = false;
            tb_nation.Enabled = false;
            tb_operate.Enabled = false;
            tb_patientNo.Enabled = false;
            dtp_birthday.Enabled = false;
            dtp_recdate.Enabled = false;
            tb_nationality.Enabled = false;
            cmb_sex.Enabled = false;
            cmb_cardtype.Enabled = false;
            btn_patientNo.Enabled = false;
        }

        private void initAdd()
        {
            //使控件可用
            tb_address.Enabled = true;
            tb_age.Enabled = true;
            tb_balance.Enabled = true;
            tb_cardNo.Enabled = true;
            tb_cellphone.Enabled = true;
            tb_creditlimit.Enabled = true;
            tb_email.Enabled = true;
            tb_firstman1.Enabled = true;
            tb_firstphone1.Enabled = true;
            tb_firstman2.Enabled = true;
            tb_firstphone2.Enabled = true;
            tb_hispass.Enabled = true;
            tb_name.Enabled = true;
            tb_nation.Enabled = true;
            tb_operate.Enabled = true;
            tb_patientNo.Enabled = true;
            tb_id.Enabled = true;
            dtp_birthday.Enabled = true;
            dtp_recdate.Enabled = true;
            tb_nationality.Enabled = true;
            cmb_sex.Enabled = true;
            cmb_cardtype.Enabled = true;
            btn_patientNo.Enabled = true;

            //清除原有值
            tb_address.Text = "";
            tb_age.Text = "";
            tb_balance.Text = "";
            tb_cardNo.Text = "";
            tb_cellphone.Text = "";
            tb_creditlimit.Text = "";
            tb_email.Text = "";
            tb_firstman1.Text = "";
            tb_firstphone1.Text = "";
            tb_firstman2.Text = "";
            tb_firstphone2.Text = "";
            tb_hispass.Text = "";
            tb_id.Text = "";
            tb_name.Text = "";
            tb_nation.Text = "汉";
            tb_operate.Text = "";
            tb_patientNo.Text = "";
            cmb_sex.SelectedIndex = 0;
            cmb_cardtype.SelectedIndex = 0;

            btn_addpatient.Text = "保存添加";
        }

        private void btn_addpatient_Click(object sender, EventArgs e)
        {
            if (btn_addpatient.Text == "添加病人")
            {
                this.initAdd();
            }
            else
            {
                if (tb_name.Text == "")
                {
                    MessageBox.Show("请输入病人的姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_name.Focus();
                }
                else 
                {
                    if (tb_cellphone.Text == "")
                    {
                        MessageBox.Show("请输入病人的联系电话！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_cellphone.Focus();
                    }
                    else
                    {
                            if (cmb_cardtype.SelectedItem.ToString() == "就诊卡")
                            {
                                if (tb_cardNo.Text == "")
                                {
                                    MessageBox.Show("请输入病人的就诊卡号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    tb_cardNo.Focus();
                                }
                            }
                            else 
                            {
                                if (tb_id.Text == "")
                                {
                                    MessageBox.Show("请输入病人的身份证号码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    tb_id.Focus();
                                }
                                else
                                {
                                    int rowAffected = 0;
                                    try
                                    {
                                        rowAffected = mysql.getcom("INSERT tb_patient"
                                        + "(No,Name,age,sex,birthday,nationality,nation,email,tel,Address,firstman1,firstmantel1,firstman2,firstmantel2,regDate,allergyHistory,operationHistory)"
                                        + "VALUES('" + tb_patientNo.Text.Trim() + "','" + tb_name.Text.Trim() + "'," + tb_age.Text.Trim() + "," + cmb_sex.SelectedIndex + ",'"
                                        + dtp_birthday.Value.ToShortDateString() + "','" + tb_nationality.Text.Trim() + "','" + tb_nation.Text.Trim() + "','" + tb_email.Text.Trim() + "','"
                                        + tb_cellphone.Text.Trim() + "','" + tb_address.Text.Trim() + "','" + tb_firstman1.Text.Trim() + "','" + tb_firstphone1.Text.Trim() + "','"
                                        + tb_firstman2.Text.Trim() + "','" + tb_firstphone2.Text.Trim() + "','" + dtp_recdate.Value.ToShortDateString() + "','" + tb_hispass.Text.Trim() + "','" + tb_operate.Text.Trim() + "')");
                                    }
                                    catch(SqlException sqlEx)
                                    {
                                        MessageBox.Show(sqlEx.Message,"数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                                    }
                                    if (rowAffected == 1)
                                    {
                                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);

                                        tb_address.Enabled = false;
                                        tb_age.Enabled = false;
                                        tb_balance.Enabled = false;
                                        tb_cardNo.Enabled = false;
                                        tb_cellphone.Enabled = false;
                                        tb_creditlimit.Enabled = false;
                                        tb_email.Enabled = false;
                                        tb_firstman1.Enabled = false;
                                        tb_firstphone1.Enabled = false;
                                        tb_firstman2.Enabled = false;
                                        tb_firstphone2.Enabled = false;
                                        tb_hispass.Enabled = false;
                                        tb_id.Enabled = false;
                                        tb_name.Enabled = false;
                                        tb_nation.Enabled = false;
                                        tb_operate.Enabled = false;
                                        tb_patientNo.Enabled = false;
                                        dtp_birthday.Enabled = false;
                                        dtp_recdate.Enabled = false;
                                        tb_nationality.Enabled = false;
                                        cmb_sex.Enabled = false;
                                        cmb_cardtype.Enabled = false;
                                        btn_patientNo.Enabled = false;

                                        btn_addpatient.Text = "添加病人";
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }    
                       
                    }         
                }
                   
                }
            }
        }

        private void btn_socialCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请插入社保卡!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtp_birthday_ValueChanged(object sender, EventArgs e)
        {
            tb_age.Text = (DateTime.Now.Year - dtp_birthday.Value.Year).ToString();
        }

        private void cmb_cardtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cardtype.Text == "")
            {
                tb_id.Enabled = false;
                tb_cardNo.Enabled = false;
            }
            else if (cmb_cardtype.SelectedItem.ToString() == "就诊卡")
            {
                tb_id.Enabled = false;
                tb_cardNo.Enabled = true;
            }
            else
            {
                tb_cardNo.Enabled = false;
                tb_id.Enabled = true;
            }
        }

        private void btn_modifypatient_Click(object sender, EventArgs e)
        {
            if (btn_modifypatient.Text == "修改病人")
            {
                //使控件可用
                tb_address.Enabled = true;
                tb_age.Enabled = true;
                tb_balance.Enabled = true;
                tb_cardNo.Enabled = true;
                tb_cellphone.Enabled = true;
                tb_creditlimit.Enabled = true;
                tb_email.Enabled = true;
                tb_firstman1.Enabled = true;
                tb_firstphone1.Enabled = true;
                tb_firstman2.Enabled = true;
                tb_firstphone2.Enabled = true;
                tb_hispass.Enabled = true;
                tb_id.Enabled = true;
                tb_name.Enabled = true;
                tb_nation.Enabled = true;
                tb_operate.Enabled = true;
                tb_patientNo.Enabled = true;
                dtp_birthday.Enabled = true;
                dtp_recdate.Enabled = true;
                tb_nationality.Enabled = true;
                cmb_sex.Enabled = true;
                cmb_cardtype.Enabled = true;
                btn_patientNo.Enabled = true;

                btn_modifypatient.Text = "保存修改";
            }
            else
            {


                tb_address.Enabled = false;
                tb_age.Enabled = false;
                tb_balance.Enabled = false;
                tb_cardNo.Enabled = false;
                tb_cellphone.Enabled = false;
                tb_creditlimit.Enabled = false;
                tb_email.Enabled = false;
                tb_firstman1.Enabled = false;
                tb_firstphone1.Enabled = false;
                tb_firstman2.Enabled = false;
                tb_firstphone2.Enabled = false;
                tb_hispass.Enabled = false;
                tb_id.Enabled = false;
                tb_name.Enabled = false;
                tb_nation.Enabled = false;
                tb_operate.Enabled = false;
                tb_patientNo.Enabled = false;
                dtp_birthday.Enabled = false;
                dtp_recdate.Enabled = false;
                tb_nationality.Enabled = false;
                cmb_sex.Enabled = false;
                cmb_cardtype.Enabled = false;
                btn_patientNo.Enabled = false;

                btn_modifypatient.Text = "修改病人";
            }
        }

        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)
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

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_appointment") == true)
                return;
            Frm_appointment frm = new Frm_appointment();
            frm.MdiParent = this.Owner;
            frm.Show();
        }

        private void btn_patientNo_Click(object sender, EventArgs e)
        {
            tb_patientNo.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
        }

    }
}
