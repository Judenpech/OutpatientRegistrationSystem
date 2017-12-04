namespace OutpatientRegistrationSystem
{
    partial class Frm_systemRebuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_systemRebuild));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.ckb_clearBusiness = new System.Windows.Forms.CheckBox();
            this.ckb_clearBasic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_clearBasic);
            this.groupBox1.Controls.Add(this.ckb_clearBusiness);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户密码：";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(83, 227);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 21);
            this.tb_password.TabIndex = 2;
            // 
            // btn_rebuild
            // 
            this.btn_rebuild.Location = new System.Drawing.Point(224, 225);
            this.btn_rebuild.Name = "btn_rebuild";
            this.btn_rebuild.Size = new System.Drawing.Size(75, 23);
            this.btn_rebuild.TabIndex = 3;
            this.btn_rebuild.Text = "重建";
            this.btn_rebuild.UseVisualStyleBackColor = true;
            this.btn_rebuild.Click += new System.EventHandler(this.btn_rebuild_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(324, 225);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            // Frm_systemRebuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_rebuild);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_systemRebuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统重建";
            this.Load += new System.EventHandler(this.Frm_systemRebuild_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_rebuild;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.CheckBox ckb_clearBasic;
        private System.Windows.Forms.CheckBox ckb_clearBusiness;
    }
}