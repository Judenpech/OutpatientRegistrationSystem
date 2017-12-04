namespace OutpatientRegistrationSystem
{
    partial class Frm_payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_payment));
            this.cmb_paymentallman = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_cardType = new System.Windows.Forms.ComboBox();
            this.tb_cardNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_patientNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_ticketNo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtp_paydate = new System.Windows.Forms.DateTimePicker();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_doctor = new System.Windows.Forms.TextBox();
            this.tb_patientname = new System.Windows.Forms.TextBox();
            this.tb_regNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_diagFee = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_regFee = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_creditLimit = new System.Windows.Forms.TextBox();
            this.tb_checkFee = new System.Windows.Forms.TextBox();
            this.tb_examFee = new System.Windows.Forms.TextBox();
            this.tb_balance = new System.Windows.Forms.TextBox();
            this.tb_medicineFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_payprint = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_recharge = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_needpay = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_paymentallman
            // 
            this.cmb_paymentallman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paymentallman.FormattingEnabled = true;
            this.cmb_paymentallman.Location = new System.Drawing.Point(321, 9);
            this.cmb_paymentallman.Name = "cmb_paymentallman";
            this.cmb_paymentallman.Size = new System.Drawing.Size(121, 20);
            this.cmb_paymentallman.TabIndex = 16;
            this.cmb_paymentallman.SelectedIndexChanged += new System.EventHandler(this.cmb_paymentallman_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(214, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 12);
            this.label21.TabIndex = 15;
            this.label21.Text = "未缴费病人列表：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(212, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 14;
            this.label20.Text = "详细费用查看：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_cardType);
            this.groupBox2.Controls.Add(this.tb_cardNo);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tb_patientNo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_ticketNo);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.dtp_paydate);
            this.groupBox2.Controls.Add(this.tb_dept);
            this.groupBox2.Controls.Add(this.tb_doctor);
            this.groupBox2.Controls.Add(this.tb_patientname);
            this.groupBox2.Controls.Add(this.tb_regNo);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 403);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缴费信息";
            // 
            // cmb_cardType
            // 
            this.cmb_cardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cardType.FormattingEnabled = true;
            this.cmb_cardType.Location = new System.Drawing.Point(74, 170);
            this.cmb_cardType.Name = "cmb_cardType";
            this.cmb_cardType.Size = new System.Drawing.Size(112, 20);
            this.cmb_cardType.TabIndex = 98;
            // 
            // tb_cardNo
            // 
            this.tb_cardNo.Location = new System.Drawing.Point(74, 245);
            this.tb_cardNo.Name = "tb_cardNo";
            this.tb_cardNo.Size = new System.Drawing.Size(112, 21);
            this.tb_cardNo.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 96;
            this.label17.Text = "就诊卡号：";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(74, 209);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(112, 21);
            this.tb_id.TabIndex = 95;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 94;
            this.label18.Text = "身份证号码：";
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(74, 64);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(112, 21);
            this.tb_patientNo.TabIndex = 23;
            this.tb_patientNo.TextChanged += new System.EventHandler(this.tb_patientNo_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "患者编号：";
            // 
            // tb_ticketNo
            // 
            this.tb_ticketNo.Location = new System.Drawing.Point(74, 28);
            this.tb_ticketNo.Name = "tb_ticketNo";
            this.tb_ticketNo.Size = new System.Drawing.Size(112, 21);
            this.tb_ticketNo.TabIndex = 21;
            this.tb_ticketNo.TextChanged += new System.EventHandler(this.tb_ticketNo_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 137);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 20;
            this.label23.Text = "挂号号码：";
            // 
            // dtp_paydate
            // 
            this.dtp_paydate.CustomFormat = "yyyy-MM-dd";
            this.dtp_paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_paydate.Location = new System.Drawing.Point(74, 359);
            this.dtp_paydate.Name = "dtp_paydate";
            this.dtp_paydate.Size = new System.Drawing.Size(112, 21);
            this.dtp_paydate.TabIndex = 19;
            // 
            // tb_dept
            // 
            this.tb_dept.Location = new System.Drawing.Point(74, 319);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(112, 21);
            this.tb_dept.TabIndex = 18;
            // 
            // tb_doctor
            // 
            this.tb_doctor.Location = new System.Drawing.Point(74, 282);
            this.tb_doctor.Name = "tb_doctor";
            this.tb_doctor.Size = new System.Drawing.Size(112, 21);
            this.tb_doctor.TabIndex = 17;
            // 
            // tb_patientname
            // 
            this.tb_patientname.Location = new System.Drawing.Point(74, 98);
            this.tb_patientname.Name = "tb_patientname";
            this.tb_patientname.Size = new System.Drawing.Size(112, 21);
            this.tb_patientname.TabIndex = 12;
            // 
            // tb_regNo
            // 
            this.tb_regNo.Location = new System.Drawing.Point(74, 134);
            this.tb_regNo.Name = "tb_regNo";
            this.tb_regNo.Size = new System.Drawing.Size(112, 21);
            this.tb_regNo.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 363);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "缴费日期：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "卡类型：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "票号：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "科室：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "医师：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "患者姓名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_diagFee);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.tb_regFee);
            this.groupBox1.Controls.Add(this.tb_total);
            this.groupBox1.Controls.Add(this.tb_creditLimit);
            this.groupBox1.Controls.Add(this.tb_checkFee);
            this.groupBox1.Controls.Add(this.tb_examFee);
            this.groupBox1.Controls.Add(this.tb_balance);
            this.groupBox1.Controls.Add(this.tb_medicineFee);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 421);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "总费用";
            // 
            // tb_diagFee
            // 
            this.tb_diagFee.Location = new System.Drawing.Point(86, 94);
            this.tb_diagFee.Name = "tb_diagFee";
            this.tb_diagFee.Size = new System.Drawing.Size(118, 21);
            this.tb_diagFee.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 20;
            this.label22.Text = "诊疗费：";
            // 
            // tb_regFee
            // 
            this.tb_regFee.Location = new System.Drawing.Point(86, 59);
            this.tb_regFee.Name = "tb_regFee";
            this.tb_regFee.Size = new System.Drawing.Size(118, 21);
            this.tb_regFee.TabIndex = 17;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(526, 93);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(118, 21);
            this.tb_total.TabIndex = 14;
            // 
            // tb_creditLimit
            // 
            this.tb_creditLimit.Location = new System.Drawing.Point(527, 24);
            this.tb_creditLimit.Name = "tb_creditLimit";
            this.tb_creditLimit.Size = new System.Drawing.Size(118, 21);
            this.tb_creditLimit.TabIndex = 13;
            // 
            // tb_checkFee
            // 
            this.tb_checkFee.Location = new System.Drawing.Point(307, 60);
            this.tb_checkFee.Name = "tb_checkFee";
            this.tb_checkFee.Size = new System.Drawing.Size(118, 21);
            this.tb_checkFee.TabIndex = 12;
            // 
            // tb_examFee
            // 
            this.tb_examFee.Location = new System.Drawing.Point(307, 25);
            this.tb_examFee.Name = "tb_examFee";
            this.tb_examFee.Size = new System.Drawing.Size(118, 21);
            this.tb_examFee.TabIndex = 11;
            // 
            // tb_balance
            // 
            this.tb_balance.Location = new System.Drawing.Point(527, 57);
            this.tb_balance.Name = "tb_balance";
            this.tb_balance.Size = new System.Drawing.Size(118, 21);
            this.tb_balance.TabIndex = 10;
            // 
            // tb_medicineFee
            // 
            this.tb_medicineFee.Location = new System.Drawing.Point(86, 24);
            this.tb_medicineFee.Name = "tb_medicineFee";
            this.tb_medicineFee.Size = new System.Drawing.Size(118, 21);
            this.tb_medicineFee.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "检查费：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "信用额度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "总计：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "挂号费：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "检验费：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "账户余额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品费：";
            // 
            // btn_payprint
            // 
            this.btn_payprint.Location = new System.Drawing.Point(120, 35);
            this.btn_payprint.Name = "btn_payprint";
            this.btn_payprint.Size = new System.Drawing.Size(75, 27);
            this.btn_payprint.TabIndex = 16;
            this.btn_payprint.Text = "打印付款单";
            this.btn_payprint.UseVisualStyleBackColor = true;
            this.btn_payprint.Click += new System.EventHandler(this.btn_payprint_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(120, 77);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 27);
            this.btn_pay.TabIndex = 15;
            this.btn_pay.Text = "付款";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(213, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(691, 110);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(691, 217);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_recharge
            // 
            this.btn_recharge.Location = new System.Drawing.Point(18, 77);
            this.btn_recharge.Name = "btn_recharge";
            this.btn_recharge.Size = new System.Drawing.Size(75, 27);
            this.btn_recharge.TabIndex = 22;
            this.btn_recharge.Text = "就诊卡充值";
            this.btn_recharge.UseVisualStyleBackColor = true;
            this.btn_recharge.Click += new System.EventHandler(this.btn_recharge_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_needpay);
            this.groupBox3.Controls.Add(this.btn_recharge);
            this.groupBox3.Controls.Add(this.btn_pay);
            this.groupBox3.Controls.Add(this.btn_payprint);
            this.groupBox3.Location = new System.Drawing.Point(690, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 126);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作类型";
            // 
            // btn_needpay
            // 
            this.btn_needpay.Location = new System.Drawing.Point(18, 35);
            this.btn_needpay.Name = "btn_needpay";
            this.btn_needpay.Size = new System.Drawing.Size(75, 27);
            this.btn_needpay.TabIndex = 23;
            this.btn_needpay.Text = "欠费催款";
            this.btn_needpay.UseVisualStyleBackColor = true;
            this.btn_needpay.Click += new System.EventHandler(this.btn_needpay_Click);
            // 
            // Frm_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(909, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmb_paymentallman);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_payment";
            this.Text = "前台缴费";
            this.Load += new System.EventHandler(this.Frm_payment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_paymentallman;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_ticketNo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_paydate;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_doctor;
        private System.Windows.Forms.TextBox tb_patientname;
        private System.Windows.Forms.TextBox tb_regNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_diagFee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_regFee;
        private System.Windows.Forms.Button btn_payprint;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_creditLimit;
        private System.Windows.Forms.TextBox tb_checkFee;
        private System.Windows.Forms.TextBox tb_examFee;
        private System.Windows.Forms.TextBox tb_balance;
        private System.Windows.Forms.TextBox tb_medicineFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_patientNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_cardNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_recharge;
        private System.Windows.Forms.ComboBox cmb_cardType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_needpay;
    }
}