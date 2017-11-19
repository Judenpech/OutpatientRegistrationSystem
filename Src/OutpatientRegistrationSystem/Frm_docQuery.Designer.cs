namespace OutpatientRegistrationSystem
{
    partial class Frm_docQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_docQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.rtb_spec = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.rdo_title = new System.Windows.Forms.RadioButton();
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdo_no = new System.Windows.Forms.RadioButton();
            this.rdo_dept = new System.Windows.Forms.RadioButton();
            this.cmb_schDept = new System.Windows.Forms.ComboBox();
            this.tb_schNo = new System.Windows.Forms.TextBox();
            this.cmb_schTitle = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_modifyDoc = new System.Windows.Forms.Button();
            this.btn_addpatient = new System.Windows.Forms.Button();
            this.btn_regno = new System.Windows.Forms.Button();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_dept);
            this.groupBox1.Controls.Add(this.tb_title);
            this.groupBox1.Controls.Add(this.rtb_spec);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_no);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Location = new System.Drawing.Point(373, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(399, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "医生信息";
            // 
            // tb_dept
            // 
            this.tb_dept.Location = new System.Drawing.Point(275, 45);
            this.tb_dept.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(113, 21);
            this.tb_dept.TabIndex = 15;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(61, 45);
            this.tb_title.Margin = new System.Windows.Forms.Padding(2);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(122, 21);
            this.tb_title.TabIndex = 14;
            // 
            // rtb_spec
            // 
            this.rtb_spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_spec.Location = new System.Drawing.Point(61, 77);
            this.rtb_spec.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_spec.Name = "rtb_spec";
            this.rtb_spec.Size = new System.Drawing.Size(327, 109);
            this.rtb_spec.TabIndex = 13;
            this.rtb_spec.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "擅长：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "职称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "所属科室：";
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(61, 18);
            this.tb_no.Margin = new System.Windows.Forms.Padding(2);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(122, 21);
            this.tb_no.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(275, 18);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(113, 21);
            this.tb_name.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_search);
            this.groupBox4.Controls.Add(this.rdo_title);
            this.groupBox4.Controls.Add(this.cmb_searchName);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Controls.Add(this.rdo_no);
            this.groupBox4.Controls.Add(this.rdo_dept);
            this.groupBox4.Controls.Add(this.cmb_schDept);
            this.groupBox4.Controls.Add(this.tb_schNo);
            this.groupBox4.Controls.Add(this.cmb_schTitle);
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 144);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询方式";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(472, 99);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 27);
            this.btn_search.TabIndex = 111;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rdo_title
            // 
            this.rdo_title.AutoSize = true;
            this.rdo_title.Location = new System.Drawing.Point(18, 66);
            this.rdo_title.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_title.Name = "rdo_title";
            this.rdo_title.Size = new System.Drawing.Size(95, 16);
            this.rdo_title.TabIndex = 113;
            this.rdo_title.TabStop = true;
            this.rdo_title.Text = "根据职称查询";
            this.rdo_title.UseVisualStyleBackColor = true;
            // 
            // cmb_searchName
            // 
            this.cmb_searchName.FormattingEnabled = true;
            this.cmb_searchName.Location = new System.Drawing.Point(397, 25);
            this.cmb_searchName.Name = "cmb_searchName";
            this.cmb_searchName.Size = new System.Drawing.Size(151, 20);
            this.cmb_searchName.TabIndex = 105;
            this.cmb_searchName.SelectedIndexChanged += new System.EventHandler(this.cmb_searchName_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(274, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 12);
            this.label25.TabIndex = 104;
            this.label25.Text = "输入姓名自动检索：";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(383, 99);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 27);
            this.btn_clear.TabIndex = 106;
            this.btn_clear.Text = "重置";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdo_no
            // 
            this.rdo_no.AutoSize = true;
            this.rdo_no.Location = new System.Drawing.Point(18, 111);
            this.rdo_no.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_no.Name = "rdo_no";
            this.rdo_no.Size = new System.Drawing.Size(95, 16);
            this.rdo_no.TabIndex = 112;
            this.rdo_no.TabStop = true;
            this.rdo_no.Text = "根据工号查询";
            this.rdo_no.UseVisualStyleBackColor = true;
            // 
            // rdo_dept
            // 
            this.rdo_dept.AutoSize = true;
            this.rdo_dept.Location = new System.Drawing.Point(18, 25);
            this.rdo_dept.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_dept.Name = "rdo_dept";
            this.rdo_dept.Size = new System.Drawing.Size(95, 16);
            this.rdo_dept.TabIndex = 111;
            this.rdo_dept.TabStop = true;
            this.rdo_dept.Text = "根据科室查询";
            this.rdo_dept.UseVisualStyleBackColor = true;
            // 
            // cmb_schDept
            // 
            this.cmb_schDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_schDept.FormattingEnabled = true;
            this.cmb_schDept.Location = new System.Drawing.Point(130, 25);
            this.cmb_schDept.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_schDept.Name = "cmb_schDept";
            this.cmb_schDept.Size = new System.Drawing.Size(115, 20);
            this.cmb_schDept.TabIndex = 109;
            // 
            // tb_schNo
            // 
            this.tb_schNo.Location = new System.Drawing.Point(130, 107);
            this.tb_schNo.Name = "tb_schNo";
            this.tb_schNo.Size = new System.Drawing.Size(115, 21);
            this.tb_schNo.TabIndex = 101;
            // 
            // cmb_schTitle
            // 
            this.cmb_schTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_schTitle.FormattingEnabled = true;
            this.cmb_schTitle.Location = new System.Drawing.Point(130, 65);
            this.cmb_schTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_schTitle.Name = "cmb_schTitle";
            this.cmb_schTitle.Size = new System.Drawing.Size(115, 20);
            this.cmb_schTitle.TabIndex = 110;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(361, 199);
            this.dataGridView1.TabIndex = 107;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_modifyDoc);
            this.groupBox2.Controls.Add(this.btn_addpatient);
            this.groupBox2.Controls.Add(this.btn_regno);
            this.groupBox2.Controls.Add(this.btn_appointment);
            this.groupBox2.Location = new System.Drawing.Point(580, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(192, 144);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作类型";
            // 
            // btn_modifyDoc
            // 
            this.btn_modifyDoc.Location = new System.Drawing.Point(19, 85);
            this.btn_modifyDoc.Name = "btn_modifyDoc";
            this.btn_modifyDoc.Size = new System.Drawing.Size(75, 27);
            this.btn_modifyDoc.TabIndex = 7;
            this.btn_modifyDoc.Text = "医生管理";
            this.btn_modifyDoc.UseVisualStyleBackColor = true;
            this.btn_modifyDoc.Click += new System.EventHandler(this.btn_modifyDoc_Click);
            // 
            // btn_addpatient
            // 
            this.btn_addpatient.Location = new System.Drawing.Point(19, 45);
            this.btn_addpatient.Name = "btn_addpatient";
            this.btn_addpatient.Size = new System.Drawing.Size(75, 27);
            this.btn_addpatient.TabIndex = 6;
            this.btn_addpatient.Text = "添加病人";
            this.btn_addpatient.UseVisualStyleBackColor = true;
            this.btn_addpatient.Click += new System.EventHandler(this.btn_addpatient_Click);
            // 
            // btn_regno
            // 
            this.btn_regno.Location = new System.Drawing.Point(105, 45);
            this.btn_regno.Name = "btn_regno";
            this.btn_regno.Size = new System.Drawing.Size(75, 27);
            this.btn_regno.TabIndex = 5;
            this.btn_regno.Text = "病人挂号";
            this.btn_regno.UseVisualStyleBackColor = true;
            this.btn_regno.Click += new System.EventHandler(this.btn_regno_Click);
            // 
            // btn_appointment
            // 
            this.btn_appointment.Location = new System.Drawing.Point(105, 85);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(75, 27);
            this.btn_appointment.TabIndex = 4;
            this.btn_appointment.Text = "病人预约";
            this.btn_appointment.UseVisualStyleBackColor = true;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // Frm_docQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(780, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_docQuery";
            this.Text = "医生查询";
            this.Load += new System.EventHandler(this.Frm_docQuery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.RichTextBox rtb_spec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_searchName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_schNo;
        private System.Windows.Forms.ComboBox cmb_schTitle;
        private System.Windows.Forms.ComboBox cmb_schDept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdo_dept;
        private System.Windows.Forms.RadioButton rdo_title;
        private System.Windows.Forms.RadioButton rdo_no;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_regno;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.Button btn_addpatient;
        private System.Windows.Forms.Button btn_modifyDoc;
        private System.Windows.Forms.TextBox tb_dept;
    }
}