﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            DialogResult dr = MessageBox.Show("您确定要注销登录吗?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            TreeNode tr = new TreeNode("导医服务", 0, 1);
            tr.Nodes.Add("", "患者登记", 0, 1);
            tr.Nodes.Add("", "患者挂号", 0, 1);
            tr.Nodes.Add("", "患者预约", 0, 1);
            tr.Nodes.Add("", "前台缴费", 0, 1);
            tr.Nodes.Add("", "欠费催款", 0, 1);

            TreeNode tr1 = new TreeNode("查询服务", 0, 1);
            tr1.Nodes.Add("", "科室查询", 0, 1);
            tr1.Nodes.Add("", "医生查询", 0, 1);   

            TreeNode tr2 = new TreeNode("门诊统计", 0, 1);
            tr2.Nodes.Add("", "科室统计", 0, 1);
            tr2.Nodes.Add("", "每日统计", 0, 1);

            TreeNode tr3 = new TreeNode("基本设置", 0, 1);
            tr3.Nodes.Add("", "挂号设置", 0, 1);
            tr3.Nodes.Add("", "科室管理", 0, 1);
            tr3.Nodes.Add("", "医生管理", 0, 1);
            tr3.Nodes.Add("", "评价管理", 0, 1);
            tr3.Nodes.Add("", "操作员设置", 0, 1);

            treeView1.Nodes.Add(tr);
            tr.ExpandAll();
            treeView1.Nodes.Add(tr1);
            tr1.ExpandAll();
            treeView1.Nodes.Add(tr2);
            tr2.ExpandAll();
            treeView1.Nodes.Add(tr3);
            tr3.ExpandAll();

            for (int i = 0,k=0; i < treeView1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++,k++)
                {
                    if (k == 5) break; //待修改删除
                    treeView1.Nodes[i].Nodes[j].ImageIndex =k ;
                }
            }

            toolStripStatusLabel_operater.Text = "【操作员】" + userHelper.operatorNo+"（"+userHelper.operatorName+"）";
            toolStripStatusLabel_loginTime.Text = "【登录时间】" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            toolStripStatusLabel_curTime.Text = "【系统当前时间】" + DateTime.Now.ToString("HH:mm");
            this.timer1.Interval = 1000;
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
                case "患者挂号":
                    {
                        if (this.checkchildfrm("Frm_registration") == true)
                            return;
                        Frm_registration frm = new Frm_registration();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "前台缴费":
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
                case "评价管理":
                    {
                        if (this.checkchildfrm("Frm_docScore") == true)
                            return;
                        Frm_docScore frm = new Frm_docScore();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "科室查询":
                    {
                        if (this.checkchildfrm("Frm_deptQuery") == true)
                            return;
                        Frm_deptQuery frm = new Frm_deptQuery();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "医生查询":
                    {
                        if (this.checkchildfrm("Frm_docQuery") == true)
                            return;
                        Frm_docQuery frm = new Frm_docQuery();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "科室统计":
                    {
                        if (this.checkchildfrm("Frm_countdept") == true)
                            return;
                        Frm_countdept frm = new Frm_countdept();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "每日统计":
                    {
                        if (this.checkchildfrm("Frm_countday") == true)
                            return;
                        Frm_countday frm = new Frm_countday();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "挂号设置":
                    {
                        if (this.checkchildfrm("Frm_regsetting") == true)
                            return;
                        Frm_regsetting frm = new Frm_regsetting();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "科室管理":
                    {
                        if (this.checkchildfrm("Frm_department") == true)
                            return;
                        Frm_department frm = new Frm_department();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "医生管理":
                    {
                        if (this.checkchildfrm("Frm_doctor") == true)
                            return;
                        Frm_doctor frm = new Frm_doctor();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                case "操作员设置":
                    {
                        if (this.checkchildfrm("Frm_operator") == true)
                            return;
                        Frm_operator frm = new Frm_operator();
                        frm.MdiParent = this;
                        frm.Show();
                        break;
                    }
                default:
                    return;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.toolStripStatusLabel_curTime.Text = "【系统当前时间】" + DateTime.Now.ToString("HH:mm");
        }

        private void 锁定toolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定要锁定系统吗?", "锁定确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Frm_lock frm = new Frm_lock();
                this.Enabled = false;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.Enabled = true;
                }
            }
        }

        private void 关于我们toolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/jl223vy");
        }
    }
}
