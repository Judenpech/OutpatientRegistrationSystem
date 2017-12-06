using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Excel = Microsoft.Office.Interop.Excel;

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

        //public static bool OutToExcelFromDataGridView(string title, DataGridView dgv, bool isShowExcel)
        //{
        //    int titleColumnSpan = 4;//标题的跨列数
        //    string fileName = "科室信息";//保存的excel文件名
        //    int columnIndex = 1;//列索引
        //    if (dgv.Rows.Count == 0)
        //        return false;
        //    /*保存对话框*/
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    sfd.Filter = "导出Excel(*.xls)|*.xlsx";
        //    sfd.FileName = title + DateTime.Now.ToString("yyyyMMddhhmmss");

        //    if (sfd.ShowDialog() == DialogResult.OK)
        //    {
        //        fileName = sfd.FileName;
        //        /*建立Excel对象*/
        //        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        //        if (excel == null)
        //        {
        //            MessageBox.Show("无法创建Excel对象,可能您的计算机未安装Excel!");
        //            return false;
        //        }
        //        try
        //        {
        //            excel.Application.Workbooks.Add(true);
        //            excel.Visible = isShowExcel;
        //            /*分析标题的跨列数*/
        //            foreach (DataGridViewColumn column in dgv.Columns)
        //            {

        //                if (column.Visible == true)
        //                    titleColumnSpan++;
        //            }
        //            /*合并标题单元格*/
        //            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
        //            //worksheet.get_Range("A1", "C10").Merge();           
        //            worksheet.get_Range(worksheet.Cells[1, 1] as Range, worksheet.Cells[1, titleColumnSpan] as Range).Merge();
        //            /*生成标题*/
        //            excel.Cells[1, 1] = title;
        //            (excel.Cells[1, 1] as Range).HorizontalAlignment = XlHAlign.xlHAlignCenter;//标题居中
        //            //生成字段名称
        //            columnIndex = 1;
        //            for (int i = 0; i < dgv.ColumnCount; i++)
        //            {
        //                if (dgv.Columns[i].Visible == true && dgv.Columns[i].HeaderText != "删除")
        //                {
        //                    excel.Cells[2, columnIndex] = dgv.Columns[i].HeaderText;
        //                    (excel.Cells[2, columnIndex] as Range).HorizontalAlignment = XlHAlign.xlHAlignCenter;//字段居中
        //                    columnIndex++;
        //                }
        //            }
        //            //填充数据             
        //            for (int i = 0; i < dgv.RowCount; i++)
        //            {
        //                columnIndex = 1;
        //                for (int j = 0; j < dgv.ColumnCount; j++)
        //                {
        //                    if (dgv.Columns[j].Visible == true && dgv.Columns[j].HeaderText != "删除")
        //                    {
        //                        if (dgv[j, i].ValueType == typeof(string))
        //                        {
        //                            excel.Cells[i + 3, columnIndex] = "'" + dgv[j, i].Value.ToString();
        //                        }
        //                        else
        //                        {
        //                            excel.Cells[i + 3, columnIndex] = dgv[j, i].Value.ToString();
        //                        }
        //                        (excel.Cells[i + 3, columnIndex] as Range).HorizontalAlignment = XlHAlign.xlHAlignLeft;//字段居中
        //                        columnIndex++;
        //                    }
        //                }
        //            }
        //            worksheet.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //        }
        //        catch { }
        //        finally
        //        {
        //            excel.Quit();
        //            excel = null;
        //            GC.Collect();
        //        }
        //        KillProcess("Excel");
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private static void KillProcess(string processName)//杀死与Excel相关的进程
        //{
        //    System.Diagnostics.Process myproc = new System.Diagnostics.Process();//得到所有打开的进程
        //    try
        //    {
        //        foreach (System.Diagnostics.Process thisproc in System.Diagnostics.Process.GetProcessesByName(processName))
        //        {
        //            if (!thisproc.CloseMainWindow())
        //            {
        //                thisproc.Kill();
        //            }
        //        }
        //    }
        //    catch (Exception Exc)
        //    {
        //        throw new Exception("", Exc);
        //    }
        //}
    }
}
