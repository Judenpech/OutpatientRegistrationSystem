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
    public partial class Frm_doctor : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string Mstr = "SELECT d1.No 工号,d1.NAME 姓名,d1.pinyin 拼音码,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
            + "FROM tb_doctor d1,tb_dept d2 "
            + "WHERE d1.deptNo=d2.NO;";
        private string Mtable = "doctor";
        BindingSource bdsource = new BindingSource();
        private int savevalue;

        public Frm_doctor()
        {
            InitializeComponent();
        }

        private void Frm_doctor_Load(object sender, EventArgs e)
        {
            //初始化科室列表
            DataSet myds1 = mysql.getds("SELECT NO 科室编号,NAME 科室名称 FROM tb_dept; ", "department");
            BindingSource mybdsource = new BindingSource();
            mybdsource.DataSource = myds1.Tables[0];
            this.dataGridView2.DataSource = mybdsource;
            tb_curDept.DataBindings.Add("text", mybdsource, "科室名称");

            Mstr = "SELECT d1.No 工号,d1.NAME 姓名,d1.pinyin 拼音码,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
            + "FROM tb_doctor d1,tb_dept d2 "
            + "WHERE d1.deptNo=d2.NO AND d2.Name='" + tb_curDept.Text.Trim() + "';";
            tb_curDept.Enabled = false;
            this.setFalse();
            this.init();

            //绑定数据
            tb_name.DataBindings.Add("text", bdsource, "姓名");
            tb_pinyin.DataBindings.Add("text", bdsource, "拼音码");
            tb_no.DataBindings.Add("text", bdsource, "工号");
            tb_title.DataBindings.Add("text", bdsource, "职称");
            cmb_dept.DataBindings.Add("text", bdsource, "所属科室");
            rtb_spec.DataBindings.Add("text", bdsource, "擅长");

            //添加科室
            DataSet partds = mysql.getds("SELECT NAME FROM tb_dept;", "department");
            for (int i = 0; i < partds.Tables[0].Rows.Count; i++)
            {
                this.cmb_dept.Items.Add(partds.Tables[0].Rows[i][0]);
            }
        }

        private void init()
        {
            DataSet myds = mysql.getds(Mstr, Mtable);
            bdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = bdsource;
            this.bindingNavigator1.BindingSource = bdsource;
        }

        private void setFalse()
        {
            tb_no.Enabled = false;
            tb_pinyin.Enabled = false;
            tb_name.Enabled = false;
            tb_title.Enabled = false;
            cmb_dept.Enabled = false;
            rtb_spec.Enabled = false;
        }

        private void setTrue()
        {
            tb_no.Enabled = true;
            tb_pinyin.Enabled = true;
            tb_name.Enabled = true;
            tb_title.Enabled = true;
            cmb_dept.Enabled = true;
            rtb_spec.Enabled = true;
        }

        private void cleartext()
        {
            tb_no.Text = "";
            tb_pinyin.Text = "";
            tb_name.Text = "";
            tb_title.Text = "";
            cmb_dept.SelectedIndex = 0;
            rtb_spec.Text = "";
        }

        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
            this.cleartext();
            savevalue = 1;
        }

        private void 删除ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (tb_name.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("DELETE FROM tb_doctor WHERE No='" + tb_no.Text.Trim() + "';");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("删除医生成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("删除医生失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的医生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.init();
            this.setFalse();
        }

        private void 修改ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
            savevalue = 2;
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (savevalue == 1)
            {
                if (tb_name.Text != "" && tb_no.Text != "" && tb_title.Text != "")
                {
                    try
                    {
                        rowAffected = mysql.getcom("INSERT tb_doctor( No, NAME, pinyin, title, deptNo, specialty ) "
                            + "SELECT '" + tb_no.Text.Trim() + "','" + tb_name.Text.Trim() + "','" + tb_pinyin.Text.Trim() + "','" + tb_title.Text.Trim() + "',d.NO,'" + rtb_spec.Text.Trim() + "' "
                            + "FROM tb_dept d WHERE d.NAME='" + cmb_dept.SelectedItem.ToString() + "';");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowAffected == 1)
                    {
                        this.setFalse();
                        savevalue = 0;
                        MessageBox.Show("添加成功！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("医生工号/姓名/职称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                if (savevalue == 2)
                {
                    if (tb_name.Text != "" && tb_no.Text != "" && tb_title.Text != "")
                    {
                        try
                        {
                            rowAffected = mysql.getcom("UPDATE tb_doctor "
                                + "SET No='" + tb_no.Text.Trim() + "',NAME='" + tb_name.Text.Trim() + "',pinyin='" + tb_pinyin.Text.Trim() + "',title='" + tb_title.Text.Trim() + "',specialty='" + rtb_spec.Text.Trim() + "',deptNo= "
                                + "(SELECT deptNo FROM tb_dept  WHERE NAME='" + cmb_dept.SelectedItem.ToString() + "')"
                                + "WHERE No='" + tb_no.Text.Trim() + "';");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            this.setFalse();
                            savevalue = 0;
                            MessageBox.Show("修改成功！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("医生工号/姓名/职称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
            this.init();
        }

        private void tb_curDept_TextChanged(object sender, EventArgs e)
        {
            Mstr = "SELECT d1.No 工号,d1.NAME 姓名,d1.pinyin 拼音码,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
                + "FROM tb_doctor d1,tb_dept d2 "
                + "WHERE d1.deptNo=d2.NO AND d2.Name='" + tb_curDept.Text.Trim() + "';";
            this.init();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
