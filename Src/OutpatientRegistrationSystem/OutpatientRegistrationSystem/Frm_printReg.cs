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
    public partial class Frm_printReg : Form
    {
        sqlHelper mysql = new sqlHelper();
        public Frm_printReg()
        {
            InitializeComponent();
        }

        private void Frm_printReg_Load(object sender, EventArgs e)
        {
            try
            {/*
                SqlConnection mycon = mysql.getcon();
                mycon.Open();
                //SqlDataAdapter da = new SqlDataAdapter("select * from patient where patientno='" + operateinfo.patientno + "' ", mycon);
                DataSet myds = new DataSet();
                da.Fill(myds, "patient");
                string reportpath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
                reportpath += @"\CRT_reg.rpt";
                crystalReportViewer1.Load(reportpath);
                crystalReportViewer1.SetDataSource(myds.Tables[0].DefaultView);
                this.crystalReportViewer1.ReportSource = crystalReportViewer1;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误：" + ex.Message.ToString());
            }
        }
    }
}
