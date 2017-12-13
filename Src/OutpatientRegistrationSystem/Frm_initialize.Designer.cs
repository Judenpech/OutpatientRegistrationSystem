namespace OutpatientRegistrationSystem
{
    partial class Frm_initialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_initialize));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.ckb_closeconfirm = new System.Windows.Forms.CheckBox();
            this.ckb_voice = new System.Windows.Forms.CheckBox();
            this.ckb_clientmoni = new System.Windows.Forms.CheckBox();
            this.tb_signupcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hospitalName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckb_clearBasic = new System.Windows.Forms.CheckBox();
            this.ckb_clearBusiness = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_run = new System.Windows.Forms.Button();
            this.tb_specPsw = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtb_sql = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_optimize = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_runclear = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 293);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.ckb_closeconfirm);
            this.tabPage1.Controls.Add(this.ckb_voice);
            this.tabPage1.Controls.Add(this.ckb_clientmoni);
            this.tabPage1.Controls.Add(this.tb_signupcode);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_address);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_hospitalName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.btn_ok);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "医院注册";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(5, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "重启系统后生效";
            // 
            // ckb_closeconfirm
            // 
            this.ckb_closeconfirm.AutoSize = true;
            this.ckb_closeconfirm.Location = new System.Drawing.Point(104, 195);
            this.ckb_closeconfirm.Name = "ckb_closeconfirm";
            this.ckb_closeconfirm.Size = new System.Drawing.Size(120, 16);
            this.ckb_closeconfirm.TabIndex = 14;
            this.ckb_closeconfirm.Text = "关闭系统需要确认";
            this.ckb_closeconfirm.UseVisualStyleBackColor = true;
            // 
            // ckb_voice
            // 
            this.ckb_voice.AutoSize = true;
            this.ckb_voice.Location = new System.Drawing.Point(251, 195);
            this.ckb_voice.Name = "ckb_voice";
            this.ckb_voice.Size = new System.Drawing.Size(108, 16);
            this.ckb_voice.TabIndex = 11;
            this.ckb_voice.Text = "启用语音报价器";
            this.ckb_voice.UseVisualStyleBackColor = true;
            // 
            // ckb_clientmoni
            // 
            this.ckb_clientmoni.AutoSize = true;
            this.ckb_clientmoni.Location = new System.Drawing.Point(251, 163);
            this.ckb_clientmoni.Name = "ckb_clientmoni";
            this.ckb_clientmoni.Size = new System.Drawing.Size(108, 16);
            this.ckb_clientmoni.TabIndex = 10;
            this.ckb_clientmoni.Text = "启用客户屏显示";
            this.ckb_clientmoni.UseVisualStyleBackColor = true;
            // 
            // tb_signupcode
            // 
            this.tb_signupcode.Enabled = false;
            this.tb_signupcode.Location = new System.Drawing.Point(136, 24);
            this.tb_signupcode.Name = "tb_signupcode";
            this.tb_signupcode.Size = new System.Drawing.Size(204, 21);
            this.tb_signupcode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "注册码：";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(136, 99);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(204, 58);
            this.tb_address.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "医院地址：";
            // 
            // tb_hospitalName
            // 
            this.tb_hospitalName.Location = new System.Drawing.Point(136, 62);
            this.tb_hospitalName.Name = "tb_hospitalName";
            this.tb_hospitalName.Size = new System.Drawing.Size(204, 21);
            this.tb_hospitalName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "医院名称：";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(205, 232);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 27);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "重置";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(310, 232);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 27);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage2.Controls.Add(this.btn_rebuild);
            this.tabPage2.Controls.Add(this.tb_password);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "系统重建";
            // 
            // btn_rebuild
            // 
            this.btn_rebuild.Location = new System.Drawing.Point(303, 228);
            this.btn_rebuild.Name = "btn_rebuild";
            this.btn_rebuild.Size = new System.Drawing.Size(75, 25);
            this.btn_rebuild.TabIndex = 8;
            this.btn_rebuild.Text = "重建";
            this.btn_rebuild.UseVisualStyleBackColor = true;
            this.btn_rebuild.Click += new System.EventHandler(this.btn_rebuild_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Info;
            this.tb_password.Location = new System.Drawing.Point(79, 228);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 21);
            this.tb_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "用户密码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ckb_clearBasic);
            this.groupBox1.Controls.Add(this.ckb_clearBusiness);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // ckb_clearBasic
            // 
            this.ckb_clearBasic.AutoSize = true;
            this.ckb_clearBasic.Location = new System.Drawing.Point(161, 156);
            this.ckb_clearBasic.Name = "ckb_clearBasic";
            this.ckb_clearBasic.Size = new System.Drawing.Size(96, 16);
            this.ckb_clearBasic.TabIndex = 4;
            this.ckb_clearBasic.Text = "清空基础资料";
            this.ckb_clearBasic.UseVisualStyleBackColor = true;
            // 
            // ckb_clearBusiness
            // 
            this.ckb_clearBusiness.AutoSize = true;
            this.ckb_clearBusiness.Location = new System.Drawing.Point(37, 156);
            this.ckb_clearBusiness.Name = "ckb_clearBusiness";
            this.ckb_clearBusiness.Size = new System.Drawing.Size(96, 16);
            this.ckb_clearBusiness.TabIndex = 3;
            this.ckb_clearBusiness.Text = "清空业务数据";
            this.ckb_clearBusiness.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(58, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "警告：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_run);
            this.tabPage3.Controls.Add(this.tb_specPsw);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.rtb_sql);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(404, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "高级";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(306, 222);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 27);
            this.btn_run.TabIndex = 10;
            this.btn_run.Text = "执行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tb_specPsw
            // 
            this.tb_specPsw.BackColor = System.Drawing.Color.Snow;
            this.tb_specPsw.Location = new System.Drawing.Point(86, 228);
            this.tb_specPsw.Name = "tb_specPsw";
            this.tb_specPsw.PasswordChar = '*';
            this.tb_specPsw.Size = new System.Drawing.Size(100, 21);
            this.tb_specPsw.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "特殊密码：";
            // 
            // rtb_sql
            // 
            this.rtb_sql.Location = new System.Drawing.Point(31, 96);
            this.rtb_sql.Name = "rtb_sql";
            this.rtb_sql.Size = new System.Drawing.Size(336, 96);
            this.rtb_sql.TabIndex = 3;
            this.rtb_sql.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "执行SQL语句：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(29, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtp_Date);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.btn_optimize);
            this.tabPage4.Controls.Add(this.btn_backup);
            this.tabPage4.Controls.Add(this.btn_runclear);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(404, 267);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "数据清理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "yyyy-MM-dd";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(275, 124);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(104, 21);
            this.dtp_Date.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "label15";
            // 
            // btn_optimize
            // 
            this.btn_optimize.Location = new System.Drawing.Point(52, 196);
            this.btn_optimize.Name = "btn_optimize";
            this.btn_optimize.Size = new System.Drawing.Size(179, 27);
            this.btn_optimize.TabIndex = 13;
            this.btn_optimize.Text = "第四步：数据优化";
            this.btn_optimize.UseVisualStyleBackColor = true;
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(52, 72);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(179, 27);
            this.btn_backup.TabIndex = 12;
            this.btn_backup.Text = "第一步：数据备份";
            this.btn_backup.UseVisualStyleBackColor = true;
            // 
            // btn_runclear
            // 
            this.btn_runclear.Location = new System.Drawing.Point(52, 163);
            this.btn_runclear.Name = "btn_runclear";
            this.btn_runclear.Size = new System.Drawing.Size(179, 27);
            this.btn_runclear.TabIndex = 11;
            this.btn_runclear.Text = "第三步：执行清理";
            this.btn_runclear.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(19, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "label14";
            // 
            // Frm_initialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 294);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_initialize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统初始化";
            this.Load += new System.EventHandler(this.Frm_initialize_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_rebuild;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_clearBasic;
        private System.Windows.Forms.CheckBox ckb_clearBusiness;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_signupcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_hospitalName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckb_voice;
        private System.Windows.Forms.CheckBox ckb_clientmoni;
        private System.Windows.Forms.CheckBox ckb_closeconfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TextBox tb_specPsw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtb_sql;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_optimize;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_runclear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}