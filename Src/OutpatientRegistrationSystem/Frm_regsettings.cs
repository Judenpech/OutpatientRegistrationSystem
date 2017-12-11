﻿using System;
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
    public partial class Frm_regsettings : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT id 编号,NAME 挂号名称,price 价格 FROM tb_regType;";
        private string mytable = "regType";
        BindingSource mybdsource = new BindingSource();
        private int savevalue;

        public Frm_regsettings()
        {
            InitializeComponent();
        }

        private void Frm_regsettings_Load(object sender, EventArgs e)
        {
            this.init();
            tb_id.DataBindings.Add("text", mybdsource, "编号");
            tb_regname.DataBindings.Add("text", mybdsource, "挂号名称");
            tb_price.DataBindings.Add("text", mybdsource, "价格");
            this.setFalse();
        }

        private void setFalse()
        {
            tb_id.Enabled = false;
            tb_regname.Enabled = false;
            tb_price.Enabled = false;
        }

        private void setTrue()
        {
            tb_id.Enabled = true;
            tb_regname.Enabled = true;
            tb_price.Enabled = true;
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
            this.bindingNavigator1.BindingSource = mybdsource;
        }

        private void 新增ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
            savevalue = 1;
        }

        private void 删除ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (tb_regname.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("DELETE FROM tb_regType WHERE id=" + tb_id.Text.Trim() + ";");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("删除挂号类别成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("删除挂号类别失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的挂号类别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.setFalse();
            this.init();
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
                if (tb_regname.Text != "")
                {
                    try
                    {
                        rowAffected = mysql.getcom("INSERT tb_regType( NAME, price ) VALUES  ( '" + tb_regname.Text.Trim() + "', " + Convert.ToDecimal(tb_price.Text.Trim()) + "  );");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowAffected == 1)
                    {
                        tb_regname.Enabled = false;
                        tb_price.Enabled = false;
                        savevalue = 0;
                        MessageBox.Show("添加挂号类别成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("挂号名称不能为空，添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.setFalse();
                }
            }
            else
            {
                if (savevalue == 2)
                {
                    if (tb_regname.Text != "")
                    {
                        try
                        {
                            rowAffected = mysql.getcom("UPDATE tb_regType SET NAME='" + tb_regname.Text.Trim() + "',price=" + Convert.ToDecimal(tb_price.Text.Trim()) + " WHERE id=" + Convert.ToInt32(tb_id.Text.Trim()) + ";");
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (rowAffected == 1)
                        {
                            this.setFalse();
                            savevalue = 0;
                            MessageBox.Show("修改挂号类别信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    else
                    {
                        MessageBox.Show("挂号名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_regname.Focus();
                        tb_regname.SelectAll();
                    }
                }
            }
            this.init();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
