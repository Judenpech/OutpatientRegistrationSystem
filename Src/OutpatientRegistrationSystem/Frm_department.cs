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
        private string sqlstr = "SELECT NO 科室编号,NAME 科室名称,DSCP 科室描述 FROM tb_dept;";
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

        private void Frm_department_Load(object sender, EventArgs e)
        {
            this.init();
            tb_id.DataBindings.Add("text", mybdsource, "科室编号");
            tb_name.DataBindings.Add("text", mybdsource, "科室名称");
            rtb_dscp.DataBindings.Add("text", mybdsource, "科室描述");

            tb_id.Enabled = false;
            tb_name.Enabled = false;
            rtb_dscp.Enabled = false;
        }

        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {
            tb_name.Enabled = true;
            rtb_dscp.Enabled = true;
            tb_name.Focus();
            savevalue = 1;
        }

        private void 删除ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (tb_name.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("DELETE FROM tb_dept WHERE NAME='" + tb_name.Text.Trim() + "';");
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
            tb_name.Enabled = false;
            rtb_dscp.Enabled = false;
            this.init();
        }

        private void 修改ToolStripButton_Click(object sender, EventArgs e)
        {
            tb_name.Enabled = true;
            rtb_dscp.Enabled = true;
            savevalue = 2;
        }

        private void 保存ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (savevalue == 1)
            {
                if (tb_name.Text != "")
                {
                    try
                    {
                        rowAffected = mysql.getcom("INSERT tb_dept ( NAME,DSCP ) VALUES  ( '" + tb_name.Text.Trim() + "','" + rtb_dscp.Text.Trim() + "' );");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowAffected == 1)
                    {
                        tb_name.Enabled = false;
                        rtb_dscp.Enabled = false;
                        savevalue = 0;
                        MessageBox.Show("添加科室成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("科室名称不能为空，添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_name.Enabled = false;
                    rtb_dscp.Enabled = false;
                }
            }
            else
            {
                if (savevalue == 2)
                {
                    if (tb_name.Text != "")
                    {
                        try
                        {
                            rowAffected = mysql.getcom("UPDATE tb_dept SET NAME='" + tb_name.Text.Trim() + "',dscp='" + rtb_dscp.Text.Trim() + "' WHERE NO=" + Convert.ToInt32(tb_id.Text.Trim()) + ";");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            tb_name.Enabled = false;
                            rtb_dscp.Enabled = false;
                            savevalue = 0;
                            MessageBox.Show("修改科室成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("科室名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_name.Focus();
                        tb_name.SelectAll();
                    }
                }
            }
            this.init();
        }
    }
}
