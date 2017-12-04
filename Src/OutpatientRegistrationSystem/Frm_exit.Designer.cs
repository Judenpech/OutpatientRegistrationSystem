namespace OutpatientRegistrationSystem
{
    partial class Frm_exit
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
            this.rdo_exitSystem = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rdo_restartWindows = new System.Windows.Forms.RadioButton();
            this.rdo_closeWindows = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdo_exitSystem
            // 
            this.rdo_exitSystem.AutoSize = true;
            this.rdo_exitSystem.Location = new System.Drawing.Point(104, 85);
            this.rdo_exitSystem.Name = "rdo_exitSystem";
            this.rdo_exitSystem.Size = new System.Drawing.Size(149, 16);
            this.rdo_exitSystem.TabIndex = 0;
            this.rdo_exitSystem.TabStop = true;
            this.rdo_exitSystem.Text = "退出本系统回到Windows";
            this.rdo_exitSystem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择您需要执行的操作：";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(248, 200);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 27);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(146, 200);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 27);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rdo_restartWindows
            // 
            this.rdo_restartWindows.AutoSize = true;
            this.rdo_restartWindows.Location = new System.Drawing.Point(104, 119);
            this.rdo_restartWindows.Name = "rdo_restartWindows";
            this.rdo_restartWindows.Size = new System.Drawing.Size(107, 16);
            this.rdo_restartWindows.TabIndex = 5;
            this.rdo_restartWindows.TabStop = true;
            this.rdo_restartWindows.Text = "重新启动计算机";
            this.rdo_restartWindows.UseVisualStyleBackColor = true;
            // 
            // rdo_closeWindows
            // 
            this.rdo_closeWindows.AutoSize = true;
            this.rdo_closeWindows.Location = new System.Drawing.Point(104, 150);
            this.rdo_closeWindows.Name = "rdo_closeWindows";
            this.rdo_closeWindows.Size = new System.Drawing.Size(83, 16);
            this.rdo_closeWindows.TabIndex = 6;
            this.rdo_closeWindows.TabStop = true;
            this.rdo_closeWindows.Text = "关闭计算机";
            this.rdo_closeWindows.UseVisualStyleBackColor = true;
            // 
            // Frm_exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 252);
            this.Controls.Add(this.rdo_closeWindows);
            this.Controls.Add(this.rdo_restartWindows);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_exitSystem);
            this.Name = "Frm_exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退出系统";
            this.Load += new System.EventHandler(this.Frm_exit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_exitSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rdo_restartWindows;
        private System.Windows.Forms.RadioButton rdo_closeWindows;
    }
}