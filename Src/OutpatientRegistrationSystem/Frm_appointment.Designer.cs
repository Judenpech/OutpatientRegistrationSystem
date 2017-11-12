namespace OutpatientRegistrationSystem
{
    partial class Frm_appointment
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
            this.cmb_docname = new System.Windows.Forms.ComboBox();
            this.cmb_regname = new System.Windows.Forms.ComboBox();
            this.cmb_docdiscipline = new System.Windows.Forms.ComboBox();
            this.dtp_thisdate = new System.Windows.Forms.DateTimePicker();
            this.txt_cellphone = new System.Windows.Forms.TextBox();
            this.dtp_thistime = new System.Windows.Forms.DateTimePicker();
            this.btn_addnewpatient = new System.Windows.Forms.Button();
            this.txt_cardname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_sidno = new System.Windows.Forms.TextBox();
            this.btn_addappointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_regfee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.tb_patientNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_docname
            // 
            this.cmb_docname.FormattingEnabled = true;
            this.cmb_docname.Location = new System.Drawing.Point(80, 18);
            this.cmb_docname.Name = "cmb_docname";
            this.cmb_docname.Size = new System.Drawing.Size(120, 20);
            this.cmb_docname.TabIndex = 13;
            // 
            // cmb_regname
            // 
            this.cmb_regname.FormattingEnabled = true;
            this.cmb_regname.Location = new System.Drawing.Point(83, 49);
            this.cmb_regname.Name = "cmb_regname";
            this.cmb_regname.Size = new System.Drawing.Size(117, 20);
            this.cmb_regname.TabIndex = 11;
            // 
            // cmb_docdiscipline
            // 
            this.cmb_docdiscipline.FormattingEnabled = true;
            this.cmb_docdiscipline.Location = new System.Drawing.Point(281, 18);
            this.cmb_docdiscipline.Name = "cmb_docdiscipline";
            this.cmb_docdiscipline.Size = new System.Drawing.Size(120, 20);
            this.cmb_docdiscipline.TabIndex = 10;
            // 
            // dtp_thisdate
            // 
            this.dtp_thisdate.CustomFormat = "yyyy-MM-dd";
            this.dtp_thisdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thisdate.Location = new System.Drawing.Point(482, 17);
            this.dtp_thisdate.Name = "dtp_thisdate";
            this.dtp_thisdate.Size = new System.Drawing.Size(129, 21);
            this.dtp_thisdate.TabIndex = 9;
            // 
            // txt_cellphone
            // 
            this.txt_cellphone.Location = new System.Drawing.Point(80, 58);
            this.txt_cellphone.Name = "txt_cellphone";
            this.txt_cellphone.Size = new System.Drawing.Size(128, 21);
            this.txt_cellphone.TabIndex = 19;
            // 
            // dtp_thistime
            // 
            this.dtp_thistime.CustomFormat = "hh:mm";
            this.dtp_thistime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thistime.Location = new System.Drawing.Point(697, 17);
            this.dtp_thistime.Name = "dtp_thistime";
            this.dtp_thistime.Size = new System.Drawing.Size(117, 21);
            this.dtp_thistime.TabIndex = 7;
            // 
            // btn_addnewpatient
            // 
            this.btn_addnewpatient.Location = new System.Drawing.Point(749, 53);
            this.btn_addnewpatient.Name = "btn_addnewpatient";
            this.btn_addnewpatient.Size = new System.Drawing.Size(75, 23);
            this.btn_addnewpatient.TabIndex = 20;
            this.btn_addnewpatient.Text = "添加新病人资料";
            this.btn_addnewpatient.UseVisualStyleBackColor = true;
            this.btn_addnewpatient.Click += new System.EventHandler(this.btn_addnewpatient_Click);
            // 
            // txt_cardname
            // 
            this.txt_cardname.Location = new System.Drawing.Point(529, 19);
            this.txt_cardname.Name = "txt_cardname";
            this.txt_cardname.Size = new System.Drawing.Size(170, 21);
            this.txt_cardname.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "挂号费用：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "预约医生：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(458, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 12;
            this.label18.Text = "就诊卡号：";
            // 
            // txt_sidno
            // 
            this.txt_sidno.Location = new System.Drawing.Point(529, 54);
            this.txt_sidno.Name = "txt_sidno";
            this.txt_sidno.Size = new System.Drawing.Size(170, 21);
            this.txt_sidno.TabIndex = 10;
            // 
            // btn_addappointment
            // 
            this.btn_addappointment.Location = new System.Drawing.Point(754, 459);
            this.btn_addappointment.Name = "btn_addappointment";
            this.btn_addappointment.Size = new System.Drawing.Size(75, 23);
            this.btn_addappointment.TabIndex = 22;
            this.btn_addappointment.Text = "添加预约";
            this.btn_addappointment.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "预约科室：";
            // 
            // cmb_regfee
            // 
            this.cmb_regfee.FormattingEnabled = true;
            this.cmb_regfee.Location = new System.Drawing.Point(284, 49);
            this.cmb_regfee.Name = "cmb_regfee";
            this.cmb_regfee.Size = new System.Drawing.Size(117, 20);
            this.cmb_regfee.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "挂号名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "预约日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "预约时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "联系电话：";
            // 
            // cmb_name
            // 
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(80, 22);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(93, 20);
            this.cmb_name.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_regfee);
            this.groupBox2.Controls.Add(this.cmb_docname);
            this.groupBox2.Controls.Add(this.cmb_regname);
            this.groupBox2.Controls.Add(this.cmb_docdiscipline);
            this.groupBox2.Controls.Add(this.dtp_thisdate);
            this.groupBox2.Controls.Add(this.dtp_thistime);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 109);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预约信息";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(226, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "卡类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "病人姓名：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(435, 217);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(413, 223);
            this.dataGridView2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(424, 223);
            this.dataGridView1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(446, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "身份证号码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_patientNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_cardtype);
            this.groupBox1.Controls.Add(this.btn_addnewpatient);
            this.groupBox1.Controls.Add(this.txt_cellphone);
            this.groupBox1.Controls.Add(this.txt_cardname);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_sidno);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmb_name);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 89);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人资料";
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Location = new System.Drawing.Point(282, 20);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(117, 20);
            this.cmb_cardtype.TabIndex = 92;
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(282, 54);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(117, 21);
            this.tb_patientNo.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 96;
            this.label12.Text = "患者编号：";
            // 
            // Frm_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.btn_addappointment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_appointment";
            this.Text = " 患者预约 ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_docname;
        private System.Windows.Forms.ComboBox cmb_regname;
        private System.Windows.Forms.ComboBox cmb_docdiscipline;
        private System.Windows.Forms.DateTimePicker dtp_thisdate;
        private System.Windows.Forms.TextBox txt_cellphone;
        private System.Windows.Forms.DateTimePicker dtp_thistime;
        private System.Windows.Forms.Button btn_addnewpatient;
        private System.Windows.Forms.TextBox txt_cardname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_sidno;
        private System.Windows.Forms.Button btn_addappointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_regfee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_cardtype;
        private System.Windows.Forms.TextBox tb_patientNo;
        private System.Windows.Forms.Label label12;

    }
}