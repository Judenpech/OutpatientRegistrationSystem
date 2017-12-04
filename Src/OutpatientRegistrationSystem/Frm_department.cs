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
    public partial class Frm_department : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT NO 科室编号,NAME 科室名称,pinyin 拼音码,DSCP 科室描述 FROM tb_dept; ";
        private string mytable = "department";
        BindingSource mybdsource = new BindingSource();
        private int savevalue;

        public Frm_department()
        {
            InitializeComponent();
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
            this.bindingNavigator1.BindingSource = mybdsource;
        }

        private void setFalse()
        {
            tb_id.Enabled = false;
            tb_name.Enabled = false;
            tb_pinyin.Enabled = false;
            rtb_dscp.Enabled = false;
        }

        private void setTrue()
        {
            tb_id.Enabled = true;
            tb_name.Enabled = true;
            tb_pinyin.Enabled = true;
            rtb_dscp.Enabled = true;
        }

        private void Frm_department_Load(object sender, EventArgs e)
        {
            this.init();
            tb_pinyin.DataBindings.Add("text", mybdsource, "拼音码");
            tb_id.DataBindings.Add("text", mybdsource, "科室编号");
            tb_name.DataBindings.Add("text", mybdsource, "科室名称");
            rtb_dscp.DataBindings.Add("text", mybdsource, "科室描述");
            this.setFalse();
        }

        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
            tb_id.Focus();
            savevalue = 1;
        }

        private void 删除ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (tb_id.Text != "" && tb_name.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("DELETE FROM tb_dept WHERE NO='" + tb_id.Text.Trim() + "';");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("删除科室成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("删除科室失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的科室！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.setFalse();
            this.init();
        }

        private void 修改ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
            savevalue = 2;
        }

        private void 保存ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (savevalue == 1)
            {
                if (tb_id.Text != "" && tb_name.Text != "")
                {
                    try
                    {
                        rowAffected = mysql.getcom("INSERT dbo.tb_dept ( NO,NAME,pinyin,DSCP ) "
                            + "VALUES  ( '" + tb_id.Text.Trim() + "','" + tb_name.Text.Trim() + "','" + tb_pinyin.Text.Trim() + "','" + rtb_dscp.Text.Trim() + "' );");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowAffected == 1)
                    {
                        this.setFalse();
                        savevalue = 0;
                        MessageBox.Show("添加科室成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("科室编号和名称不能为空，添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.setFalse();
                }
            }
            else
            {
                if (savevalue == 2)
                {
                    if (tb_id.Text != "" && tb_name.Text != "")
                    {
                        try
                        {
                            rowAffected = mysql.getcom("UPDATE tb_dept "
                                + "SET NO='" + tb_id.Text.Trim() + "',NAME='" + tb_name.Text.Trim() + "',pinyin='" + tb_pinyin.Text.Trim() + "',dscp='" + rtb_dscp.Text.Trim()
                                + "' WHERE NO='" + tb_id.Text.Trim() + "';");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            this.setFalse();
                            savevalue = 0;
                            MessageBox.Show("修改科室成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("科室编号和名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_name.Focus();
                        tb_name.SelectAll();
                    }
                }
            }
            this.init();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {

        }
    }
}
