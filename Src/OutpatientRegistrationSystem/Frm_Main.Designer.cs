namespace OutpatientRegistrationSystem
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_curTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_operater = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_loginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_prompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.锁定toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_curTime,
            this.toolStripStatusLabel_operater,
            this.toolStripStatusLabel_loginTime,
            this.toolStripStatusLabel_prompt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(776, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_curTime
            // 
            this.toolStripStatusLabel_curTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_curTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel_curTime.Image")));
            this.toolStripStatusLabel_curTime.Name = "toolStripStatusLabel_curTime";
            this.toolStripStatusLabel_curTime.Size = new System.Drawing.Size(76, 21);
            this.toolStripStatusLabel_curTime.Text = "当前时间";
            // 
            // toolStripStatusLabel_operater
            // 
            this.toolStripStatusLabel_operater.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_operater.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel_operater.Image")));
            this.toolStripStatusLabel_operater.Name = "toolStripStatusLabel_operater";
            this.toolStripStatusLabel_operater.Size = new System.Drawing.Size(64, 21);
            this.toolStripStatusLabel_operater.Text = "操作员";
            // 
            // toolStripStatusLabel_loginTime
            // 
            this.toolStripStatusLabel_loginTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_loginTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel_loginTime.Image")));
            this.toolStripStatusLabel_loginTime.Name = "toolStripStatusLabel_loginTime";
            this.toolStripStatusLabel_loginTime.Size = new System.Drawing.Size(76, 21);
            this.toolStripStatusLabel_loginTime.Text = "登录时间";
            // 
            // toolStripStatusLabel_prompt
            // 
            this.toolStripStatusLabel_prompt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel_prompt.Image")));
            this.toolStripStatusLabel_prompt.Name = "toolStripStatusLabel_prompt";
            this.toolStripStatusLabel_prompt.Size = new System.Drawing.Size(72, 21);
            this.toolStripStatusLabel_prompt.Text = "温馨提示";
            this.toolStripStatusLabel_prompt.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.锁定toolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.关于我们toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(776, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 锁定toolStripMenuItem
            // 
            this.锁定toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("锁定toolStripMenuItem.Image")));
            this.锁定toolStripMenuItem.Name = "锁定toolStripMenuItem";
            this.锁定toolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.锁定toolStripMenuItem.Text = "系统锁定";
            this.锁定toolStripMenuItem.Click += new System.EventHandler(this.锁定toolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("注销ToolStripMenuItem.Image")));
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.注销ToolStripMenuItem.Text = "注销登录";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.退出ToolStripMenuItem.Text = "退出系统";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 关于我们toolStripMenuItem
            // 
            this.关于我们toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于我们toolStripMenuItem.Image")));
            this.关于我们toolStripMenuItem.Name = "关于我们toolStripMenuItem";
            this.关于我们toolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.关于我们toolStripMenuItem.Text = "关于我们";
            this.关于我们toolStripMenuItem.Click += new System.EventHandler(this.关于我们toolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 26);
            this.treeView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(151, 519);
            this.treeView1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "患者登记.png");
            this.imageList1.Images.SetKeyName(1, "患者挂号.png");
            this.imageList1.Images.SetKeyName(2, "患者预约.png");
            this.imageList1.Images.SetKeyName(3, "前台缴费.png");
            this.imageList1.Images.SetKeyName(4, "欠费催款.png");
            this.imageList1.Images.SetKeyName(5, "评价管理.png");
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 571);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "门诊预约挂号系统 -【主页】";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_operater;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_loginTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_curTime;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem 锁定toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们toolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_prompt;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        
    }
}