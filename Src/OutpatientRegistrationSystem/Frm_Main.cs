using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要退出系统吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            TreeNode tr = new TreeNode("日常工作", 0, 1);
            tr.Nodes.Add("", "患者登记", 0, 1);
            tr.Nodes.Add("", "患者预约", 0, 1);
            tr.Nodes.Add("", "前台交费", 0, 1);
            tr.Nodes.Add("", "欠费催款", 0, 1);

            TreeNode tr1 = new TreeNode("医师服务", 0, 1);
            tr1.Nodes.Add("", "待添加", 0, 1);   //待添加

            TreeNode tr2 = new TreeNode("门诊统计", 0, 1);
            tr2.Nodes.Add("", "按科室统计", 0, 1);
            tr2.Nodes.Add("", "每日统计", 0, 1);
            tr2.Nodes.Add("", "交接班汇总", 0, 1);

            TreeNode tr3 = new TreeNode("基本设置", 0, 1);
            tr3.Nodes.Add("", "检验设置", 0, 1);
            tr3.Nodes.Add("", "检查设置", 0, 1);
            tr3.Nodes.Add("", "科室设置", 0, 1);
            tr3.Nodes.Add("", "员工值班设置", 0, 1);
            tr3.Nodes.Add("", "挂号设置", 0, 1);
            tr3.Nodes.Add("", "用户管理", 0, 1);

            treeView1.Nodes.Add(tr);
            tr.ExpandAll();
            treeView1.Nodes.Add(tr1);
            tr1.ExpandAll();
            treeView1.Nodes.Add(tr2);
            tr2.ExpandAll();
            treeView1.Nodes.Add(tr3);
            tr3.ExpandAll();

            toolStripStatusLabel_operater.Text  = "操作员："+userhelp.operaterNo;
            toolStripStatusLabel_loginTime.Text = "登录时间："+DateTime.Now.ToString("yyyy年MM月dd日 hh:mm");
            toolStripStatusLabel_curTime.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy年MM月dd日 hh:mm");
            this.timer1.Interval=1000;
            this.timer1.Start();
        }

        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)
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

      private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "患者登记":
                    {
                        if (this.checkchildfrm("Frm_patient") == true)
                            return;
                        Frm_patient frm = new Frm_patient();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "患者预约":
                    {
                        if (this.checkchildfrm("Frm_appointment") == true)
                            return;
                        Frm_appointment frm = new Frm_appointment();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "前台交费":
                    {
                        if (this.checkchildfrm("Frm_payment") == true)
                            return;
                        Frm_payment frm = new Frm_payment();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "欠费催款":
                    {
                        if (this.checkchildfrm("Frm_needpay") == true)
                            return;
                        Frm_needpay frm = new Frm_needpay();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                //case "开医令":
                //    {
                //        if (this.checkchildfrm("Frm_doccommand") == true)
                //            return;
                //        Frm_doccommand frm = new Frm_doccommand();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "按科室统计":
                //    {
                //        if (this.checkchildfrm("Frm_countdepart") == true)
                //            return;
                //        Frm_countdepart frm = new Frm_countdepart();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "每日统计":
                //    {
                //        if (this.checkchildfrm("Frm_countday") == true)
                //            return;
                //        Frm_countday frm = new Frm_countday();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "检验设置":
                //    {
                //        if (this.checkchildfrm("Frm_check") == true)
                //            return;
                //        Frm_check frm = new Frm_check();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "检查设置":
                //    {
                //        if (this.checkchildfrm("Frm_treat") == true)
                //            return;
                //        Frm_treat frm = new Frm_treat();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "科室设置":
                //    {
                //        if (this.checkchildfrm("Frm_department") == true)
                //            return;
                //        Frm_department frm = new Frm_department();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "员工值班设置":
                //    {
                //        if (this.checkchildfrm("Frm_onduty") == true)
                //            return;
                //        Frm_onduty frm = new Frm_onduty();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "挂号设置":
                //    {
                //        if (this.checkchildfrm("Frm_regmanage") == true)
                //            return;
                //        Frm_regmanage frm = new Frm_regmanage();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                //case "用户管理":
                //    {
                //        if (this.checkchildfrm("Frm_usermanage") == true)
                //            return;
                //        Frm_usermanage frm = new Frm_usermanage();
                //        frm.MdiParent = this;
                //        frm.Show();
                //        break;
                //    }
                default: 
                    return;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.toolStripStatusLabel_curTime.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy年MM月dd日 hh:mm");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

    }
}
