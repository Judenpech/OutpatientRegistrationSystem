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
    public partial class Frm_docScore : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string sqlstr = "SELECT d.id 编号,p.Name 病人姓名,d1.NAME 医生,d.comments 评价内容,d.score 等级,d.comDate 评价日期 "
            + "FROM tb_docScore d JOIN dbo.tb_patient p ON p.No=d.patientNo JOIN dbo.tb_doctor d1 ON d.docNo=d1.No ORDER BY d.id;";
        private string mytable = "docScore";
        BindingSource mybdsource = new BindingSource();

        public Frm_docScore()
        {
            InitializeComponent();
        }

        private void setFalse()
        {
            cmb_score.Enabled = false;
            tb_patient.Enabled = false;
            tb_comment.Enabled = false;
            dtp_date.Enabled = false;
            cmb_doc.Enabled = false;
        }

        private void setTrue()
        {
            cmb_score.Enabled = true;
            tb_patient.Enabled = true;
            tb_comment.Enabled = true;
            dtp_date.Enabled = true;
            cmb_doc.Enabled = true;
        }

        private void init()
        {
            DataSet myds = mysql.getds(sqlstr, mytable);
            mybdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = mybdsource;
            this.bindingNavigator1.BindingSource = mybdsource;
        }

        private void Frm_docScore_Load(object sender, EventArgs e) //bug：事件未触发
        {
            this.init();

            tb_id.DataBindings.Add("value", mybdsource, "编号");
            tb_comment.DataBindings.Add("text", mybdsource, "评价内容");
            tb_patient.DataBindings.Add("text", mybdsource, "病人姓名");
            cmb_score.DataBindings.Add("text", mybdsource, "等级");
            cmb_doc.DataBindings.Add("text", mybdsource, "医生");
            dtp_date.DataBindings.Add("value", mybdsource, "评价日期");

            cmb_score.Items.Add("好");
            cmb_score.Items.Add("一般");
            cmb_score.Items.Add("差");
            cmb_score.SelectedIndex = 0;

            DataSet docds = mysql.getds("SELECT NAME FROM tb_doctor;", "doctor");
            for (int i = 0; i < docds.Tables[0].Rows.Count; i++)
            {
                this.cmb_doc.Items.Add(docds.Tables[0].Rows[i][0]);
            }
            this.setFalse();
        }

        private void 删除ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            if (tb_patient.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("DELETE tb_docScore WHERE id=" + Convert.ToInt32(tb_id.Text.Trim()) + ";");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("删除评价成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("删除评价失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的评价！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.setFalse();
            this.init();
        }

        private void 修改ToolStripButton_Click(object sender, EventArgs e)
        {
            this.setTrue();
        }

        private void 保存ToolStripButton_Click(object sender, EventArgs e)
        {
            int rowAffected = 0;
            tb_patient.Enabled = false;
            cmb_doc.Enabled = false;
            if (tb_patient.Text != "")
            {
                try
                {
                    rowAffected = mysql.getcom("UPDATE tb_docScore SET comments='"+tb_comment.Text.Trim()+"',score='"+cmb_score.SelectedItem.ToString()
                        +"',comDate='"+dtp_date.Value.ToShortDateString()+"' WHERE id="+Convert.ToInt32(tb_id.Text.Trim())+";");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("数据库异常：" + sqlEx.Message, "数据库异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (rowAffected == 1)
                {
                    MessageBox.Show("修改评价成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            this.setFalse();
            this.init();
        }
    }
}
