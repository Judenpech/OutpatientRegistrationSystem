namespace OutpatientRegistrationSystem
{
    partial class Frm_patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_patient));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_regno = new System.Windows.Forms.Button();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.btn_modifypatient = new System.Windows.Forms.Button();
            this.btn_addpatient = new System.Windows.Forms.Button();
            this.tb_operate = new System.Windows.Forms.TextBox();
            this.tb_hispass = new System.Windows.Forms.TextBox();
            this.cmb_cardtype = new System.Windows.Forms.ComboBox();
            this.tb_firstphone1 = new System.Windows.Forms.TextBox();
            this.tb_firstman1 = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_cellphone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dtp_recdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_firstman2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_firstphone2 = new System.Windows.Forms.TextBox();
            this.tb_nation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_patientNo = new System.Windows.Forms.Button();
            this.tb_patientNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_cardNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nationality = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_searchId = new System.Windows.Forms.TextBox();
            this.btn_searchId = new System.Windows.Forms.Button();
            this.tb_searchPatienNo = new System.Windows.Forms.TextBox();
            this.btn_searchPatientNo = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(82, 24);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(164, 28);
            this.tb_name.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regno);
            this.groupBox1.Controls.Add(this.btn_appointment);
            this.groupBox1.Controls.Add(this.btn_modifypatient);
            this.groupBox1.Controls.Add(this.btn_addpatient);
            this.groupBox1.Location = new System.Drawing.Point(622, 440);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(396, 126);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作类型";
            // 
            // btn_regno
            // 
            this.btn_regno.Location = new System.Drawing.Point(226, 27);
            this.btn_regno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regno.Name = "btn_regno";
            this.btn_regno.Size = new System.Drawing.Size(112, 40);
            this.btn_regno.TabIndex = 3;
            this.btn_regno.Text = "病人挂号";
            this.btn_regno.UseVisualStyleBackColor = true;
            this.btn_regno.Click += new System.EventHandler(this.btn_regno_Click);
            // 
            // btn_appointment
            // 
            this.btn_appointment.Location = new System.Drawing.Point(226, 75);
            this.btn_appointment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(112, 39);
            this.btn_appointment.TabIndex = 2;
            this.btn_appointment.Text = "病人预约";
            this.btn_appointment.UseVisualStyleBackColor = true;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // btn_modifypatient
            // 
            this.btn_modifypatient.Location = new System.Drawing.Point(63, 75);
            this.btn_modifypatient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifypatient.Name = "btn_modifypatient";
            this.btn_modifypatient.Size = new System.Drawing.Size(106, 40);
            this.btn_modifypatient.TabIndex = 1;
            this.btn_modifypatient.Text = "修改病人";
            this.btn_modifypatient.UseVisualStyleBackColor = true;
            this.btn_modifypatient.Click += new System.EventHandler(this.btn_modifypatient_Click);
            // 
            // btn_addpatient
            // 
            this.btn_addpatient.Location = new System.Drawing.Point(62, 27);
            this.btn_addpatient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addpatient.Name = "btn_addpatient";
            this.btn_addpatient.Size = new System.Drawing.Size(106, 40);
            this.btn_addpatient.TabIndex = 0;
            this.btn_addpatient.Text = "添加病人";
            this.btn_addpatient.UseVisualStyleBackColor = true;
            this.btn_addpatient.Click += new System.EventHandler(this.btn_addpatient_Click);
            // 
            // tb_operate
            // 
            this.tb_operate.Location = new System.Drawing.Point(696, 271);
            this.tb_operate.Margin = new System.Windows.Forms.Padding(4);
            this.tb_operate.Multiline = true;
            this.tb_operate.Name = "tb_operate";
            this.tb_operate.Size = new System.Drawing.Size(312, 152);
            this.tb_operate.TabIndex = 93;
            // 
            // tb_hispass
            // 
            this.tb_hispass.Location = new System.Drawing.Point(698, 89);
            this.tb_hispass.Margin = new System.Windows.Forms.Padding(4);
            this.tb_hispass.Multiline = true;
            this.tb_hispass.Name = "tb_hispass";
            this.tb_hispass.Size = new System.Drawing.Size(312, 136);
            this.tb_hispass.TabIndex = 92;
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Location = new System.Drawing.Point(106, 50);
            this.cmb_cardtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(174, 26);
            this.cmb_cardtype.TabIndex = 91;
            this.cmb_cardtype.SelectedIndexChanged += new System.EventHandler(this.cmb_cardtype_SelectedIndexChanged);
            // 
            // tb_firstphone1
            // 
            this.tb_firstphone1.Location = new System.Drawing.Point(488, 237);
            this.tb_firstphone1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstphone1.Name = "tb_firstphone1";
            this.tb_firstphone1.Size = new System.Drawing.Size(182, 28);
            this.tb_firstphone1.TabIndex = 87;
            // 
            // tb_firstman1
            // 
            this.tb_firstman1.Location = new System.Drawing.Point(126, 237);
            this.tb_firstman1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstman1.Name = "tb_firstman1";
            this.tb_firstman1.Size = new System.Drawing.Size(174, 28);
            this.tb_firstman1.TabIndex = 85;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(126, 134);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(198, 28);
            this.tb_email.TabIndex = 84;
            // 
            // tb_cellphone
            // 
            this.tb_cellphone.Location = new System.Drawing.Point(488, 134);
            this.tb_cellphone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cellphone.Name = "tb_cellphone";
            this.tb_cellphone.Size = new System.Drawing.Size(182, 28);
            this.tb_cellphone.TabIndex = 80;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(126, 182);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(339, 28);
            this.tb_address.TabIndex = 78;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(111, 108);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(236, 28);
            this.tb_id.TabIndex = 77;
            // 
            // dtp_recdate
            // 
            this.dtp_recdate.Location = new System.Drawing.Point(826, 21);
            this.dtp_recdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_recdate.Name = "dtp_recdate";
            this.dtp_recdate.Size = new System.Drawing.Size(170, 28);
            this.dtp_recdate.TabIndex = 75;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(507, 26);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(164, 28);
            this.dtp_birthday.TabIndex = 74;
            this.dtp_birthday.ValueChanged += new System.EventHandler(this.dtp_birthday_ValueChanged);
            // 
            // cmb_sex
            // 
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(318, 26);
            this.cmb_sex.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(110, 26);
            this.cmb_sex.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 70;
            this.label20.Text = "卡类型：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(693, 248);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 18);
            this.label19.TabIndex = 69;
            this.label19.Text = "手术史：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(694, 61);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 18);
            this.label18.TabIndex = 68;
            this.label18.Text = "过敏史：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(381, 246);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 18);
            this.label16.TabIndex = 66;
            this.label16.Text = "联系电话：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 243);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 18);
            this.label14.TabIndex = 64;
            this.label14.Text = "紧急联系人1：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "E-mail：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 59;
            this.label9.Text = "家庭住址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "身份证号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "生日：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "登记日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tb_hispass);
            this.groupBox2.Controls.Add(this.tb_operate);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tb_firstman2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb_firstphone2);
            this.groupBox2.Controls.Add(this.tb_nation);
            this.groupBox2.Controls.Add(this.dtp_birthday);
            this.groupBox2.Controls.Add(this.cmb_sex);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_nationality);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_age);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtp_recdate);
            this.groupBox2.Controls.Add(this.tb_firstman1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_cellphone);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_address);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_firstphone1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 181);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1018, 581);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // tb_firstman2
            // 
            this.tb_firstman2.Location = new System.Drawing.Point(126, 292);
            this.tb_firstman2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstman2.Name = "tb_firstman2";
            this.tb_firstman2.Size = new System.Drawing.Size(174, 28);
            this.tb_firstman2.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 298);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 18);
            this.label15.TabIndex = 97;
            this.label15.Text = "紧急联系人2：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(381, 303);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 98;
            this.label17.Text = "联系电话：";
            // 
            // tb_firstphone2
            // 
            this.tb_firstphone2.Location = new System.Drawing.Point(488, 296);
            this.tb_firstphone2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstphone2.Name = "tb_firstphone2";
            this.tb_firstphone2.Size = new System.Drawing.Size(182, 28);
            this.tb_firstphone2.TabIndex = 100;
            // 
            // tb_nation
            // 
            this.tb_nation.Location = new System.Drawing.Point(543, 74);
            this.tb_nation.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nation.Name = "tb_nation";
            this.tb_nation.Size = new System.Drawing.Size(128, 28);
            this.tb_nation.TabIndex = 96;
            this.tb_nation.Text = "汉";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 95;
            this.label11.Text = "民族：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 94;
            this.label10.Text = "岁";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_patientNo);
            this.groupBox3.Controls.Add(this.tb_patientNo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tb_cardNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmb_cardtype);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.tb_id);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(18, 332);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(580, 234);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // btn_patientNo
            // 
            this.btn_patientNo.Location = new System.Drawing.Point(420, 159);
            this.btn_patientNo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_patientNo.Name = "btn_patientNo";
            this.btn_patientNo.Size = new System.Drawing.Size(130, 34);
            this.btn_patientNo.TabIndex = 96;
            this.btn_patientNo.Text = "生成患者编号";
            this.btn_patientNo.UseVisualStyleBackColor = true;
            this.btn_patientNo.Click += new System.EventHandler(this.btn_patientNo_Click);
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(396, 50);
            this.tb_patientNo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(174, 28);
            this.tb_patientNo.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 94;
            this.label12.Text = "患者编号：";
            // 
            // tb_cardNo
            // 
            this.tb_cardNo.Location = new System.Drawing.Point(111, 162);
            this.tb_cardNo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_cardNo.Name = "tb_cardNo";
            this.tb_cardNo.Size = new System.Drawing.Size(174, 28);
            this.tb_cardNo.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 92;
            this.label7.Text = "就诊卡号：";
            // 
            // tb_nationality
            // 
            this.tb_nationality.Location = new System.Drawing.Point(318, 76);
            this.tb_nationality.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nationality.Name = "tb_nationality";
            this.tb_nationality.Size = new System.Drawing.Size(110, 28);
            this.tb_nationality.TabIndex = 92;
            this.tb_nationality.Text = "中国";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(258, 82);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 18);
            this.label21.TabIndex = 66;
            this.label21.Text = "国籍：";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(82, 76);
            this.tb_age.Margin = new System.Windows.Forms.Padding(4);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(55, 28);
            this.tb_age.TabIndex = 65;
            this.tb_age.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "年龄：";
            // 
            // tb_searchId
            // 
            this.tb_searchId.Location = new System.Drawing.Point(28, 44);
            this.tb_searchId.Margin = new System.Windows.Forms.Padding(4);
            this.tb_searchId.Name = "tb_searchId";
            this.tb_searchId.Size = new System.Drawing.Size(234, 28);
            this.tb_searchId.TabIndex = 99;
            // 
            // btn_searchId
            // 
            this.btn_searchId.Location = new System.Drawing.Point(294, 44);
            this.btn_searchId.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchId.Name = "btn_searchId";
            this.btn_searchId.Size = new System.Drawing.Size(190, 34);
            this.btn_searchId.TabIndex = 100;
            this.btn_searchId.Text = "根据身份证号搜索";
            this.btn_searchId.UseVisualStyleBackColor = true;
            this.btn_searchId.Click += new System.EventHandler(this.btn_searchId_Click);
            // 
            // tb_searchPatienNo
            // 
            this.tb_searchPatienNo.Location = new System.Drawing.Point(28, 102);
            this.tb_searchPatienNo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_searchPatienNo.Name = "tb_searchPatienNo";
            this.tb_searchPatienNo.Size = new System.Drawing.Size(234, 28);
            this.tb_searchPatienNo.TabIndex = 101;
            // 
            // btn_searchPatientNo
            // 
            this.btn_searchPatientNo.Location = new System.Drawing.Point(294, 102);
            this.btn_searchPatientNo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searchPatientNo.Name = "btn_searchPatientNo";
            this.btn_searchPatientNo.Size = new System.Drawing.Size(190, 34);
            this.btn_searchPatientNo.TabIndex = 102;
            this.btn_searchPatientNo.Text = "根据患者编号搜索";
            this.btn_searchPatientNo.UseVisualStyleBackColor = true;
            this.btn_searchPatientNo.Click += new System.EventHandler(this.btn_searchPatientNo_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(554, 56);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(170, 18);
            this.label25.TabIndex = 104;
            this.label25.Text = "输入姓名自动检索：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Controls.Add(this.cmb_searchName);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.tb_searchId);
            this.groupBox4.Controls.Add(this.btn_searchPatientNo);
            this.groupBox4.Controls.Add(this.btn_searchId);
            this.groupBox4.Controls.Add(this.tb_searchPatienNo);
            this.groupBox4.Location = new System.Drawing.Point(13, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1018, 159);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "搜索已有病人信息";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(883, 97);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(113, 34);
            this.btn_clear.TabIndex = 106;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmb_searchName
            // 
            this.cmb_searchName.FormattingEnabled = true;
            this.cmb_searchName.Location = new System.Drawing.Point(732, 51);
            this.cmb_searchName.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_searchName.Name = "cmb_searchName";
            this.cmb_searchName.Size = new System.Drawing.Size(264, 26);
            this.cmb_searchName.TabIndex = 105;
            this.cmb_searchName.SelectedIndexChanged += new System.EventHandler(this.cmb_searchName_SelectedIndexChanged);
            // 
            // Frm_patient
            // 
            this.AcceptButton = this.btn_addpatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1042, 767);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_patient";
            this.Text = "患者登记";
            this.Load += new System.EventHandler(this.Frm_patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_regno;
        private System.Windows.Forms.Button btn_appointment;
        private System.Windows.Forms.Button btn_modifypatient;
        private System.Windows.Forms.Button btn_addpatient;
        private System.Windows.Forms.TextBox tb_operate;
        private System.Windows.Forms.TextBox tb_hispass;
        private System.Windows.Forms.ComboBox cmb_cardtype;
        private System.Windows.Forms.TextBox tb_firstphone1;
        private System.Windows.Forms.TextBox tb_firstman1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_cellphone;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DateTimePicker dtp_recdate;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_nationality;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cardNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_patientNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_firstman2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_firstphone2;
        private System.Windows.Forms.TextBox tb_searchId;
        private System.Windows.Forms.Button btn_searchId;
        private System.Windows.Forms.TextBox tb_searchPatienNo;
        private System.Windows.Forms.Button btn_searchPatientNo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_patientNo;
        private System.Windows.Forms.ComboBox cmb_searchName;
        private System.Windows.Forms.Button btn_clear;


    }
}