using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_docQuery : Form
    {
        sqlHelper mysql = new sqlHelper();
        private string Mtable = "doctor";
        BindingSource bdsource = new BindingSource();
        private int flag = 1;

        public Frm_docQuery()
        {
            InitializeComponent();
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

        private void btn_addpatient_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_patient") == true)
                return;
            Frm_patient frm = new Frm_patient();
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

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_appointment") == true)
                return;
            Frm_appointment frm = new Frm_appointment();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btn_modifyDoc_Click(object sender, EventArgs e)
        {
            if (this.checkchildfrm("Frm_doctor") == true)
                return;
            Frm_doctor frm = new Frm_doctor();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void init(string Mstr)
        {
            DataSet myds = mysql.getds(Mstr, Mtable);
            bdsource.DataSource = myds.Tables[0];
            this.dataGridView1.DataSource = bdsource;
            if (flag == 1)
            {
                this.databing();
                flag = 0;
            }
        }

        private void databing()
        {
            tb_no.DataBindings.Add("text", bdsource, "医生工号");
            tb_name.DataBindings.Add("text", bdsource, "姓名");
            tb_title.DataBindings.Add("text", bdsource, "职称");
            tb_dept.DataBindings.Add("text", bdsource, "所属科室");
            rtb_spec.DataBindings.Add("text", bdsource, "擅长");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rdo_dept.Checked)
            {
                this.init("SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
                    + "FROM tb_doctor d1 JOIN tb_dept d2 ON d1.deptNo=d2.NO "
                    + "WHERE d2.NAME='" + cmb_schDept.SelectedItem.ToString() + "' AND d1.deptNo=d2.NO;");
            }
            if (rdo_title.Checked)
            {
                this.init("SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
                    + "FROM tb_doctor d1 JOIN tb_dept d2 ON d1.deptNo=d2.NO "
                    + "WHERE d1.title='" + cmb_schTitle.SelectedItem.ToString() + "' AND d1.deptNo=d2.NO;");
            }
            if (rdo_no.Checked)
            {
                this.init("SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长 "
                    + "FROM tb_doctor d1 JOIN tb_dept d2 ON d1.deptNo=d2.NO "
                    + "WHERE d1.No='" + tb_schNo.Text.Trim() + "' AND d1.deptNo=d2.NO;");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_schNo.Text = "";
            cmb_searchName.Text = "";
            cmb_schDept.SelectedIndex = 0;
            cmb_schTitle.SelectedIndex = 0;
            rdo_dept.Select();
        }

        private void Frm_docQuery_Load(object sender, EventArgs e)
        {
            //添加已有医生供检索
            DataSet getnameds = mysql.getds("SELECT NAME FROM tb_doctor;", "doctor");
            for (int i = 0; i < getnameds.Tables[0].Rows.Count; i++)
            {
                this.cmb_searchName.Items.Add(getnameds.Tables[0].Rows[i][0]);
            }
            this.cmb_searchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmb_searchName.AutoCompleteSource = AutoCompleteSource.ListItems;

            //添加科室
            DataSet partds = mysql.getds("SELECT NAME FROM tb_dept;", "department");
            for (int i = 0; i < partds.Tables[0].Rows.Count; i++)
            {
                this.cmb_schDept.Items.Add(partds.Tables[0].Rows[i][0]);
            }
            cmb_schDept.SelectedIndex = 0;

            //添加职称
            cmb_schTitle.Items.Add("住院医师");
            cmb_schTitle.Items.Add("主治医师");
            cmb_schTitle.Items.Add("副主任医师");
            cmb_schTitle.Items.Add("主任医师");
            cmb_schTitle.SelectedIndex = 0;

            rdo_dept.Select();
        }

        private void cmb_searchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempstr = cmb_searchName.Text;
            DataSet chanagenameds = mysql.getds("SELECT d1.No no,d1.NAME name ,d1.title title,d2.NAME dept,d1.specialty specialty FROM tb_doctor d1 JOIN tb_dept d2 ON d1.deptNo=d2.NO "
                + "WHERE d1.NAME='" + tempstr + "' AND d1.deptNo=d2.NO;", "doctor");
            tb_no.Text = chanagenameds.Tables[0].Rows[0]["no"].ToString();
            tb_name.Text = chanagenameds.Tables[0].Rows[0]["name"].ToString();
            tb_title.Text = chanagenameds.Tables[0].Rows[0]["title"].ToString();
            tb_dept.Text = chanagenameds.Tables[0].Rows[0]["dept"].ToString();
            rtb_spec.Text = chanagenameds.Tables[0].Rows[0]["specialty"].ToString();
        }
    }
}
