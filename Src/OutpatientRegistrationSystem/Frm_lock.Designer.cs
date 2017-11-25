namespace OutpatientRegistrationSystem
{
    partial class Frm_lock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_lock));
            this.tb_psw = new System.Windows.Forms.TextBox();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texbox_userName = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lab_psw = new System.Windows.Forms.Label();
            this.lab_userName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_psw
            // 
            this.tb_psw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_psw.Location = new System.Drawing.Point(101, 147);
            this.tb_psw.Name = "tb_psw";
            this.tb_psw.PasswordChar = '*';
            this.tb_psw.Size = new System.Drawing.Size(105, 21);
            this.tb_psw.TabIndex = 1;
            // 
            // btn_unlock
            // 
            this.btn_unlock.BackColor = System.Drawing.Color.Transparent;
            this.btn_unlock.Location = new System.Drawing.Point(135, 184);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(71, 27);
            this.btn_unlock.TabIndex = 3;
            this.btn_unlock.Text = "解锁";
            this.btn_unlock.UseVisualStyleBackColor = false;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(82, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 78);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // texbox_userName
            // 
            this.texbox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbox_userName.Location = new System.Drawing.Point(101, 112);
            this.texbox_userName.Name = "texbox_userName";
            this.texbox_userName.Size = new System.Drawing.Size(105, 21);
            this.texbox_userName.TabIndex = 25;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(31, 184);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(71, 27);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lab_psw
            // 
            this.lab_psw.AutoSize = true;
            this.lab_psw.Location = new System.Drawing.Point(29, 149);
            this.lab_psw.Name = "lab_psw";
            this.lab_psw.Size = new System.Drawing.Size(65, 12);
            this.lab_psw.TabIndex = 22;
            this.lab_psw.Text = "用户密码：";
            // 
            // lab_userName
            // 
            this.lab_userName.AutoSize = true;
            this.lab_userName.Location = new System.Drawing.Point(29, 114);
            this.lab_userName.Name = "lab_userName";
            this.lab_userName.Size = new System.Drawing.Size(65, 12);
            this.lab_userName.TabIndex = 21;
            this.lab_userName.Text = "用户工号：";
            // 
            // Frm_lock
            // 
            this.AcceptButton = this.btn_unlock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(241, 224);
            this.Controls.Add(this.texbox_userName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lab_psw);
            this.Controls.Add(this.lab_userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.tb_psw);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_lock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统锁定";
            this.Load += new System.EventHandler(this.Frm_lock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_psw;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox texbox_userName;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lab_psw;
        private System.Windows.Forms.Label lab_userName;

    }
}