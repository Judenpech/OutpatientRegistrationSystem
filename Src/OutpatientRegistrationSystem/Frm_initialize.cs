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
    public partial class Frm_initialize : Form
    {
        sqlHelper mysql = new sqlHelper();
        public Frm_initialize()
        {
            InitializeComponent();
        }

        private void Frm_initialize_Load(object sender, EventArgs e)
        {
            //初始化
            ckb_closeconfirm.Select();
            label2.Text = "本功能将会清空医院所有业务数据，并且在清空的同时";
            label10.Text = "，可以将基础资料也清空，请谨慎使用此功能！";
            label3.Text = "此功能一般用于清空演示数据！";
            label11.Text = "警告：以下操作非请勿用，否则造成损失，后果自负！！！";
            label14.Text = "为提高系统运行速度，可将旧数据进行备份（以后可以查询），然后\n"
                + "进行数据清理，清理前必须对原数据进行备份，切记！清理前应通知\n"
                + "所有客户端退出软件，等清理完毕再运行系统！";
            label15.Text = "第二步：选择清理此日期之前的所有数据";
        }

        private void btn_rebuild_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == userHelper.operatorPsw)
            {
                int rowCount;
                //清空业务数据
                if (ckb_clearBusiness.Checked)
                {
                    rowCount = 0;
                    try
                    {
                        rowCount = mysql.getcom("DELETE FROM dbo.tb_expensesRecord; DELETE FROM dbo.tb_registration; "
                        + "DELETE FROM dbo.tb_docScore; DELETE FROM dbo.tb_receipt;");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowCount >= 1)
                    {
                        MessageBox.Show("清空业务数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("清空业务数据失败！请稍后重试或联系信息科", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //清空基础资料
                if (ckb_clearBasic.Checked)
                {
                    rowCount = 0;
                    try
                    {
                        rowCount = mysql.getcom("DELETE FROM dbo.tb_patient; DELETE FROM dbo.tb_card; DELETE FROM dbo.tb_dept; "
                        + "DELETE FROM dbo.tb_doctor; DELETE FROM dbo.tb_regType;");
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowCount >= 1)
                    {
                        MessageBox.Show("清空基础资料成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("清空基础资料失败！请稍后重试或联系信息科", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("用户密码错误，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_password.Focus();
                tb_password.SelectAll();
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
          
            if (tb_specPsw.Text == "3150707012")
            {
                if (rtb_sql.Text != "")
                {
                    int rowCount = 0;
                    try
                    {
                        rowCount = mysql.getcom(rtb_sql.Text);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (rowCount >= 1)
                    {
                        MessageBox.Show("执行成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("执行失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("SQL语句不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtb_sql.Focus();
                }
            }
            else
            {
                MessageBox.Show("特殊密码错误，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_specPsw.Focus();
                tb_specPsw.SelectAll();
            }
        }
    }
}
