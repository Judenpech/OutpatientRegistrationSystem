namespace OutpatientRegistrationSystem
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.texbox_psw = new System.Windows.Forms.TextBox();
            this.texbox_userName = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lab_psw = new System.Windows.Forms.Label();
            this.lab_userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdo_remote = new System.Windows.Forms.RadioButton();
            this.rdo_backup = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_local = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // texbox_psw
            // 
            this.texbox_psw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbox_psw.Location = new System.Drawing.Point(95, 76);
            this.texbox_psw.Name = "texbox_psw";
            this.texbox_psw.PasswordChar = '*';
            this.texbox_psw.Size = new System.Drawing.Size(122, 21);
            this.texbox_psw.TabIndex = 20;
            // 
            // texbox_userName
            // 
            this.texbox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbox_userName.Location = new System.Drawing.Point(95, 38);
            this.texbox_userName.Name = "texbox_userName";
            this.texbox_userName.Size = new System.Drawing.Size(122, 21);
            this.texbox_userName.TabIndex = 19;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(459, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 27);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(459, 333);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(87, 27);
            this.btn_logIn.TabIndex = 17;
            this.btn_logIn.Text = "登录";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // lab_psw
            // 
            this.lab_psw.AutoSize = true;
            this.lab_psw.Location = new System.Drawing.Point(20, 80);
            this.lab_psw.Name = "lab_psw";
            this.lab_psw.Size = new System.Drawing.Size(65, 12);
            this.lab_psw.TabIndex = 16;
            this.lab_psw.Text = "用户密码：";
            // 
            // lab_userName
            // 
            this.lab_userName.AutoSize = true;
            this.lab_userName.Location = new System.Drawing.Point(20, 42);
            this.lab_userName.Name = "lab_userName";
            this.lab_userName.Size = new System.Drawing.Size(65, 12);
            this.lab_userName.TabIndex = 15;
            this.lab_userName.Text = "用户工号：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 283);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rdo_remote
            // 
            this.rdo_remote.AutoSize = true;
            this.rdo_remote.Location = new System.Drawing.Point(19, 28);
            this.rdo_remote.Name = "rdo_remote";
            this.rdo_remote.Size = new System.Drawing.Size(71, 16);
            this.rdo_remote.TabIndex = 22;
            this.rdo_remote.TabStop = true;
            this.rdo_remote.Text = "远程登录";
            this.rdo_remote.UseVisualStyleBackColor = true;
            // 
            // rdo_backup
            // 
            this.rdo_backup.AutoSize = true;
            this.rdo_backup.Location = new System.Drawing.Point(19, 60);
            this.rdo_backup.Name = "rdo_backup";
            this.rdo_backup.Size = new System.Drawing.Size(71, 16);
            this.rdo_backup.TabIndex = 23;
            this.rdo_backup.TabStop = true;
            this.rdo_backup.Text = "后备登录";
            this.rdo_backup.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-3, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "OUTPATIENT REGISTRATION SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "VERSION 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_local);
            this.groupBox1.Controls.Add(this.rdo_backup);
            this.groupBox1.Controls.Add(this.rdo_remote);
            this.groupBox1.Location = new System.Drawing.Point(81, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录模式";
            // 
            // rdo_local
            // 
            this.rdo_local.AutoSize = true;
            this.rdo_local.Location = new System.Drawing.Point(19, 91);
            this.rdo_local.Name = "rdo_local";
            this.rdo_local.Size = new System.Drawing.Size(71, 16);
            this.rdo_local.TabIndex = 24;
            this.rdo_local.TabStop = true;
            this.rdo_local.Text = "本地登录";
            this.rdo_local.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.texbox_userName);
            this.groupBox2.Controls.Add(this.lab_userName);
            this.groupBox2.Controls.Add(this.lab_psw);
            this.groupBox2.Controls.Add(this.texbox_psw);
            this.groupBox2.Location = new System.Drawing.Point(197, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 125);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // Frm_login
            // 
            this.AcceptButton = this.btn_logIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(562, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_login";
            this.Text = "医院门诊预约挂号系统";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texbox_psw;
        private System.Windows.Forms.TextBox texbox_userName;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Label lab_psw;
        private System.Windows.Forms.Label lab_userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdo_remote;
        private System.Windows.Forms.RadioButton rdo_backup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_local;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}