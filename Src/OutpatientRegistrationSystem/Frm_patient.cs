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
            //添加已有病人供检索
            DataSet getnameds = mysql.getds("SELECT Name FROM tb_patient", "patient");
            for (int i = 0; i < getnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_searchName.Items.Add(getnameds.Tables[0].Rows[i][0]);
            }
            this.cmb_searchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmb_searchName.AutoCompleteSource = AutoCompleteSource.ListItems;

            //添加性别
            cmb_sex.Items.Add("男");
            cmb_sex.Items.Add("女");
            cmb_sex.SelectedIndex = 0;

            //添加卡类型
            cmb_cardtype.Items.Add("就诊卡");
            cmb_cardtype.Items.Add("社保卡");
            cmb_cardtype.SelectedIndex = 0;

            //只可查看
            this.setFalse();
        }

        private void setFalse()
        {
            tb_address.Enabled = false;
            tb_age.Enabled = false;
            tb_cardNo.Enabled = false;
            tb_cellphone.Enabled = false;
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

        private void setTrue()
        {
            tb_address.Enabled = true;
            tb_age.Enabled = true;
            tb_cardNo.Enabled = true;
            tb_cellphone.Enabled = true;
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
        }
        private void initAdd()
        {
            //使控件可用
            this.setTrue();

            //初始化原有值
            tb_address.Text = "";
            tb_age.Text = "0";
            tb_cardNo.Text = "";
            tb_cellphone.Text = "";
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

            btn_appointment.Enabled = false;
            btn_regno.Enabled = false;
            btn_modifypatient.Enabled = false;
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
                        if (tb_patientNo.Text == "")
                        {
                            MessageBox.Show("患者编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (cmb_cardtype.SelectedIndex == 0 && tb_cardNo.Text == "")
                            {
                                MessageBox.Show("请输入病人的就诊卡号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tb_cardNo.Focus();
                            }
                            else
                            {
                                if (cmb_cardtype.SelectedIndex == 1 && tb_id.Text == "")
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
                                        + "(No,Name,age,sex,id,visitNo,birthday,nationality,nation,email,tel,Address,firstman1,firstmantel1,firstman2,firstmantel2,regDate,allergyHistory,operationHistory)"
                                        + "VALUES('" + tb_patientNo.Text.Trim() + "','" + tb_name.Text.Trim() + "'," + tb_age.Text.Trim() + "," + cmb_sex.SelectedIndex + ",'"
                                        + tb_id.Text.Trim() + "','" + tb_cardNo.Text.Trim() + "','" + dtp_birthday.Value.ToShortDateString() + "','" + tb_nationality.Text.Trim() + "','" + tb_nation.Text.Trim() + "','" + tb_email.Text.Trim() + "','"
                                        + tb_cellphone.Text.Trim() + "','" + tb_address.Text.Trim() + "','" + tb_firstman1.Text.Trim() + "','" + tb_firstphone1.Text.Trim() + "','"
                                        + tb_firstman2.Text.Trim() + "','" + tb_firstphone2.Text.Trim() + "','" + dtp_recdate.Value.ToShortDateString() + "','" + tb_hispass.Text.Trim() + "','" + tb_operate.Text.Trim() + "')");
                                    }
                                    catch (SqlException sqlEx)
                                    {
                                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    if (rowAffected == 1)
                                    {
                                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);

                                        this.setFalse();
                                        btn_appointment.Enabled = true;
                                        btn_regno.Enabled = true;
                                        btn_modifypatient.Enabled = true;
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
        }

        private void dtp_birthday_ValueChanged(object sender, EventArgs e)
        {
            //自动计算患者年龄
            tb_age.Text = (DateTime.Now.Year - dtp_birthday.Value.Year + 1).ToString();
        }

        private void cmb_cardtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cardtype.SelectedItem.ToString() == "就诊卡")
            {
                tb_id.Enabled = true;
                tb_cardNo.Enabled = true;
            }
            else
            {
                tb_cardNo.Enabled = false;
                tb_cardNo.Text = "";
                tb_id.Enabled = true;
            }
        }

        private void btn_modifypatient_Click(object sender, EventArgs e)
        {
            if (btn_modifypatient.Text == "修改病人")
            {
                this.setTrue();
                tb_patientNo.Enabled = false;
                btn_patientNo.Enabled = false;
                btn_appointment.Enabled = false;
                btn_regno.Enabled = false;
                btn_addpatient.Enabled = false;
                btn_modifypatient.Text = "保存修改";
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
                        if (tb_patientNo.Text == "")
                        {
                            MessageBox.Show("患者编号不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (cmb_cardtype.SelectedIndex == 0 && tb_cardNo.Text == "")
                            {
                                MessageBox.Show("请输入病人的就诊卡号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tb_cardNo.Focus();
                            }
                            else
                            {
                                if (cmb_cardtype.SelectedIndex == 1 && tb_id.Text == "")
                                {
                                    MessageBox.Show("请输入病人的身份证号码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    tb_id.Focus();
                                }
                                else
                                {
                                    int rowAffected = 0;
                                    try
                                    {
                                        rowAffected = mysql.getcom("UPDATE tb_patient SET "
                                            + "Name='" + tb_name.Text.Trim() + "',age=" + tb_age.Text.Trim() + ",sex=" + cmb_sex.SelectedIndex + ",birthday='" + dtp_birthday.Value.ToShortDateString()
                                            + "',nationality='" + tb_nationality.Text.Trim() + "',nation='" + tb_nation.Text.Trim() + "',email='" + tb_email.Text.Trim() + "',tel='" + tb_cellphone.Text.Trim()
                                            + "',Address='" + tb_address.Text.Trim() + "',firstMan1='" + tb_firstman1.Text.Trim() + "',firstManTel1='" + tb_firstphone1.Text.Trim() + "',firstMan2='"
                                            + tb_firstman2.Text.Trim() + "',firstManTel2='" + tb_firstphone2.Text.Trim() + "',regDate='" + dtp_recdate.Value.ToShortDateString() + "',allergyHistory='"
                                            + tb_hispass.Text.Trim() + "',operationHistory='" + tb_operate.Text.Trim() + "',id='" + tb_id.Text.Trim() + "',visitNo='" + tb_cardNo.Text.Trim() + "'"
                                            + "WHERE No='" + tb_patientNo.Text.Trim() + "';");
                                    }
                                    catch (SqlException sqlEx)
                                    {
                                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    if (rowAffected == 1)
                                    {
                                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);

                                        this.setFalse();
                                        btn_appointment.Enabled = true;
                                        btn_regno.Enabled = true;
                                        btn_addpatient.Enabled = true;
                                        btn_modifypatient.Text = "修改病人";
                                    }
                                    else
                                    {
                                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }
                }
            }
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

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_appointment") == true)
                return;
            Frm_appointment frm = new Frm_appointment();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_regno_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_registration") == true)
                return;
            Frm_registration frm = new Frm_registration();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_patientNo_Click(object sender, EventArgs e)
        {
            //根据就诊日期时间自动生成患者编号
            tb_patientNo.Text = DateTime.Now.ToString("yyyyMMddhhmmss");
        }

        private void btn_searchId_Click(object sender, EventArgs e)
        {
            //根据身份证号搜索
            string tempstr = tb_searchId.Text.Trim();
            DataSet Idds = mysql.getds("SELECT * FROM tb_patient WHERE id='" + tempstr + "'", "patientId");
            if (Idds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("查询的病人身份证号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_searchId.Focus();
                tb_searchId.SelectAll();
            }
            else
            {
                tb_name.Text = Idds.Tables[0].Rows[0]["name"].ToString();
                tb_patientNo.Text = Idds.Tables[0].Rows[0]["no"].ToString();
                tb_age.Text = Idds.Tables[0].Rows[0]["age"].ToString();
                tb_id.Text = Idds.Tables[0].Rows[0]["id"].ToString();
                tb_cardNo.Text = Idds.Tables[0].Rows[0]["visitNo"].ToString();
                cmb_sex.SelectedIndex = Convert.ToInt32(Idds.Tables[0].Rows[0]["sex"]);
                dtp_birthday.Value = Convert.ToDateTime(Idds.Tables[0].Rows[0]["birthday"]);
                tb_nationality.Text = Idds.Tables[0].Rows[0]["nationality"].ToString();
                tb_nation.Text = Idds.Tables[0].Rows[0]["nation"].ToString();
                tb_email.Text = Idds.Tables[0].Rows[0]["email"].ToString();
                tb_cellphone.Text = Idds.Tables[0].Rows[0]["tel"].ToString();
                tb_address.Text = Idds.Tables[0].Rows[0]["address"].ToString();
                tb_firstman1.Text = Idds.Tables[0].Rows[0]["firstman1"].ToString();
                tb_firstphone1.Text = Idds.Tables[0].Rows[0]["firstmantel1"].ToString();
                tb_firstman2.Text = Idds.Tables[0].Rows[0]["firstman2"].ToString();
                tb_firstphone2.Text = Idds.Tables[0].Rows[0]["firstmantel2"].ToString();
                dtp_recdate.Value = Convert.ToDateTime(Idds.Tables[0].Rows[0]["regDate"]);
                tb_hispass.Text = Idds.Tables[0].Rows[0]["allergyHistory"].ToString();
                tb_operate.Text = Idds.Tables[0].Rows[0]["operationHistory"].ToString();
            }
        }

        private void btn_searchPatientNo_Click(object sender, EventArgs e)
        {
            //根据患者编号搜索
            string tempstr = tb_searchPatienNo.Text.Trim();
            DataSet nods = mysql.getds("SELECT * FROM tb_patient WHERE No='" + tempstr + "'", "patientNo");
            if (nods.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("查询的患者编号不存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_patientNo.Focus();
                tb_patientNo.SelectAll();
            }
            else
            {
                tb_name.Text = nods.Tables[0].Rows[0]["name"].ToString();
                tb_patientNo.Text = nods.Tables[0].Rows[0]["no"].ToString();
                tb_age.Text = nods.Tables[0].Rows[0]["age"].ToString();
                tb_id.Text = nods.Tables[0].Rows[0]["id"].ToString();
                tb_cardNo.Text = nods.Tables[0].Rows[0]["visitNo"].ToString();
                cmb_sex.SelectedIndex = Convert.ToInt32(nods.Tables[0].Rows[0]["sex"]);
                dtp_birthday.Value = Convert.ToDateTime(nods.Tables[0].Rows[0]["birthday"]);
                tb_nationality.Text = nods.Tables[0].Rows[0]["nationality"].ToString();
                tb_nation.Text = nods.Tables[0].Rows[0]["nation"].ToString();
                tb_email.Text = nods.Tables[0].Rows[0]["email"].ToString();
                tb_cellphone.Text = nods.Tables[0].Rows[0]["tel"].ToString();
                tb_address.Text = nods.Tables[0].Rows[0]["address"].ToString();
                tb_firstman1.Text = nods.Tables[0].Rows[0]["firstman1"].ToString();
                tb_firstphone1.Text = nods.Tables[0].Rows[0]["firstmantel1"].ToString();
                tb_firstman2.Text = nods.Tables[0].Rows[0]["firstman2"].ToString();
                tb_firstphone2.Text = nods.Tables[0].Rows[0]["firstmantel2"].ToString();
                dtp_recdate.Value = Convert.ToDateTime(nods.Tables[0].Rows[0]["regDate"]);
                tb_hispass.Text = nods.Tables[0].Rows[0]["allergyHistory"].ToString();
                tb_operate.Text = nods.Tables[0].Rows[0]["operationHistory"].ToString();
            }
        }

        private void cmb_searchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据姓名搜索
            string tempstr = cmb_searchName.Text;
            DataSet chanagenameds = mysql.getds("SELECT * FROM tb_patient WHERE Name='" + tempstr + "'", "patient");
            tb_name.Text = chanagenameds.Tables[0].Rows[0]["name"].ToString();
            tb_patientNo.Text = chanagenameds.Tables[0].Rows[0]["no"].ToString();
            tb_age.Text = chanagenameds.Tables[0].Rows[0]["age"].ToString();
            tb_id.Text = chanagenameds.Tables[0].Rows[0]["id"].ToString();
            tb_cardNo.Text = chanagenameds.Tables[0].Rows[0]["visitNo"].ToString();
            cmb_sex.SelectedIndex = Convert.ToInt32(chanagenameds.Tables[0].Rows[0]["sex"]);
            dtp_birthday.Value = Convert.ToDateTime(chanagenameds.Tables[0].Rows[0]["birthday"]);
            tb_nationality.Text = chanagenameds.Tables[0].Rows[0]["nationality"].ToString();
            tb_nation.Text = chanagenameds.Tables[0].Rows[0]["nation"].ToString();
            tb_email.Text = chanagenameds.Tables[0].Rows[0]["email"].ToString();
            tb_cellphone.Text = chanagenameds.Tables[0].Rows[0]["tel"].ToString();
            tb_address.Text = chanagenameds.Tables[0].Rows[0]["address"].ToString();
            tb_firstman1.Text = chanagenameds.Tables[0].Rows[0]["firstman1"].ToString();
            tb_firstphone1.Text = chanagenameds.Tables[0].Rows[0]["firstmantel1"].ToString();
            tb_firstman2.Text = chanagenameds.Tables[0].Rows[0]["firstman2"].ToString();
            tb_firstphone2.Text = chanagenameds.Tables[0].Rows[0]["firstmantel2"].ToString();
            dtp_recdate.Value = Convert.ToDateTime(chanagenameds.Tables[0].Rows[0]["regDate"]);
            tb_hispass.Text = chanagenameds.Tables[0].Rows[0]["allergyHistory"].ToString();
            tb_operate.Text = chanagenameds.Tables[0].Rows[0]["operationHistory"].ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_searchId.Text = "";
            tb_searchPatienNo.Text = "";
        }
    }
}
