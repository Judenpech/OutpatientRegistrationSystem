﻿namespace OutpatientRegistrationSystem
{
    partial class Frm_operator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_operator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_confirmPsw = new System.Windows.Forms.TextBox();
            this.tb_newPsw = new System.Windows.Forms.TextBox();
            this.tb_oldPsw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_no);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(325, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(57, 21);
            this.tb_no.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(99, 21);
            this.tb_no.TabIndex = 13;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(214, 21);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(99, 21);
            this.tb_name.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.tb_confirmPsw);
            this.groupBox2.Controls.Add(this.tb_newPsw);
            this.groupBox2.Controls.Add(this.tb_oldPsw);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 183);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改密码";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(47, 135);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 29);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "重置";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(199, 135);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(79, 29);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_confirmPsw
            // 
            this.tb_confirmPsw.Location = new System.Drawing.Point(127, 98);
            this.tb_confirmPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_confirmPsw.Name = "tb_confirmPsw";
            this.tb_confirmPsw.Size = new System.Drawing.Size(152, 21);
            this.tb_confirmPsw.TabIndex = 5;
            // 
            // tb_newPsw
            // 
            this.tb_newPsw.Location = new System.Drawing.Point(127, 67);
            this.tb_newPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_newPsw.Name = "tb_newPsw";
            this.tb_newPsw.Size = new System.Drawing.Size(152, 21);
            this.tb_newPsw.TabIndex = 4;
            // 
            // tb_oldPsw
            // 
            this.tb_oldPsw.Location = new System.Drawing.Point(127, 33);
            this.tb_oldPsw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_oldPsw.Name = "tb_oldPsw";
            this.tb_oldPsw.Size = new System.Drawing.Size(152, 21);
            this.tb_oldPsw.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "确认新密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "输入新密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "输入原密码：";
            // 
            // Frm_operator
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_operator";
            this.Text = "操作员设置";
            this.Load += new System.EventHandler(this.Frm_operator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tb_confirmPsw;
        private System.Windows.Forms.TextBox tb_newPsw;
        private System.Windows.Forms.TextBox tb_oldPsw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.TextBox tb_name;
    }
}