namespace OutpatientRegistrationSystem
{
    partial class Frm_deptQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_deptQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_dscp = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_schNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_dscp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "科室信息";
            // 
            // rtb_dscp
            // 
            this.rtb_dscp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_dscp.Location = new System.Drawing.Point(80, 53);
            this.rtb_dscp.Name = "rtb_dscp";
            this.rtb_dscp.Size = new System.Drawing.Size(423, 96);
            this.rtb_dscp.TabIndex = 5;
            this.rtb_dscp.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "科室描述：";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(80, 26);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(119, 21);
            this.tb_id.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(364, 26);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(139, 21);
            this.tb_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "科室编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "科室名称：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btn_search);
            this.groupBox4.Controls.Add(this.cmb_searchName);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Controls.Add(this.tb_schNo);
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 104);
            this.groupBox4.TabIndex = 107;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询方式";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(428, 60);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 111;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_searchName
            // 
            this.cmb_searchName.FormattingEnabled = true;
            this.cmb_searchName.Location = new System.Drawing.Point(397, 25);
            this.cmb_searchName.Name = "cmb_searchName";
            this.cmb_searchName.Size = new System.Drawing.Size(106, 20);
            this.cmb_searchName.TabIndex = 105;
            this.cmb_searchName.SelectedIndexChanged += new System.EventHandler(this.cmb_searchName_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(252, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(137, 12);
            this.label25.TabIndex = 104;
            this.label25.Text = "输入科室名称自动检索：";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(333, 60);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 27);
            this.btn_clear.TabIndex = 106;
            this.btn_clear.Text = "重置";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_schNo
            // 
            this.tb_schNo.Location = new System.Drawing.Point(111, 25);
            this.tb_schNo.Name = "tb_schNo";
            this.tb_schNo.Size = new System.Drawing.Size(115, 21);
            this.tb_schNo.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 113;
            this.label4.Text = "根据编号查询：";
            // 
            // Frm_deptQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 285);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_deptQuery";
            this.Text = "科室查询";
            this.Load += new System.EventHandler(this.Frm_deptQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_dscp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_searchName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_schNo;
        private System.Windows.Forms.Label label4;
    }
}