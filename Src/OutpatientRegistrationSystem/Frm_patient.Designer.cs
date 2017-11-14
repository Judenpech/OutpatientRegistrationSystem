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
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(55, 16);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(111, 21);
            this.tb_name.TabIndex = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regno);
            this.groupBox1.Controls.Add(this.btn_appointment);
            this.groupBox1.Controls.Add(this.btn_modifypatient);
            this.groupBox1.Controls.Add(this.btn_addpatient);
            this.groupBox1.Location = new System.Drawing.Point(415, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 84);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作类型";
            // 
            // btn_regno
            // 
            this.btn_regno.Location = new System.Drawing.Point(151, 18);
            this.btn_regno.Name = "btn_regno";
            this.btn_regno.Size = new System.Drawing.Size(75, 27);
            this.btn_regno.TabIndex = 3;
            this.btn_regno.Text = "病人挂号";
            this.btn_regno.UseVisualStyleBackColor = true;
            this.btn_regno.Click += new System.EventHandler(this.btn_regno_Click);
            // 
            // btn_appointment
            // 
            this.btn_appointment.Location = new System.Drawing.Point(151, 50);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(75, 26);
            this.btn_appointment.TabIndex = 2;
            this.btn_appointment.Text = "病人预约";
            this.btn_appointment.UseVisualStyleBackColor = true;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // btn_modifypatient
            // 
            this.btn_modifypatient.Location = new System.Drawing.Point(42, 50);
            this.btn_modifypatient.Name = "btn_modifypatient";
            this.btn_modifypatient.Size = new System.Drawing.Size(71, 27);
            this.btn_modifypatient.TabIndex = 1;
            this.btn_modifypatient.Text = "修改病人";
            this.btn_modifypatient.UseVisualStyleBackColor = true;
            this.btn_modifypatient.Click += new System.EventHandler(this.btn_modifypatient_Click);
            // 
            // btn_addpatient
            // 
            this.btn_addpatient.Location = new System.Drawing.Point(41, 18);
            this.btn_addpatient.Name = "btn_addpatient";
            this.btn_addpatient.Size = new System.Drawing.Size(71, 27);
            this.btn_addpatient.TabIndex = 0;
            this.btn_addpatient.Text = "添加病人";
            this.btn_addpatient.UseVisualStyleBackColor = true;
            this.btn_addpatient.Click += new System.EventHandler(this.btn_addpatient_Click);
            // 
            // tb_operate
            // 
            this.tb_operate.Location = new System.Drawing.Point(456, 193);
            this.tb_operate.Multiline = true;
            this.tb_operate.Name = "tb_operate";
            this.tb_operate.Size = new System.Drawing.Size(209, 103);
            this.tb_operate.TabIndex = 93;
            // 
            // tb_hispass
            // 
            this.tb_hispass.Location = new System.Drawing.Point(457, 72);
            this.tb_hispass.Multiline = true;
            this.tb_hispass.Name = "tb_hispass";
            this.tb_hispass.Size = new System.Drawing.Size(209, 92);
            this.tb_hispass.TabIndex = 92;
            // 
            // cmb_cardtype
            // 
            this.cmb_cardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cardtype.FormattingEnabled = true;
            this.cmb_cardtype.Location = new System.Drawing.Point(71, 33);
            this.cmb_cardtype.Name = "cmb_cardtype";
            this.cmb_cardtype.Size = new System.Drawing.Size(117, 20);
            this.cmb_cardtype.TabIndex = 91;
            this.cmb_cardtype.SelectedIndexChanged += new System.EventHandler(this.cmb_cardtype_SelectedIndexChanged);
            // 
            // tb_firstphone1
            // 
            this.tb_firstphone1.Location = new System.Drawing.Point(325, 158);
            this.tb_firstphone1.Name = "tb_firstphone1";
            this.tb_firstphone1.Size = new System.Drawing.Size(123, 21);
            this.tb_firstphone1.TabIndex = 87;
            // 
            // tb_firstman1
            // 
            this.tb_firstman1.Location = new System.Drawing.Point(84, 158);
            this.tb_firstman1.Name = "tb_firstman1";
            this.tb_firstman1.Size = new System.Drawing.Size(117, 21);
            this.tb_firstman1.TabIndex = 85;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(84, 89);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(133, 21);
            this.tb_email.TabIndex = 84;
            // 
            // tb_cellphone
            // 
            this.tb_cellphone.Location = new System.Drawing.Point(325, 89);
            this.tb_cellphone.Name = "tb_cellphone";
            this.tb_cellphone.Size = new System.Drawing.Size(123, 21);
            this.tb_cellphone.TabIndex = 80;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(84, 121);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(230, 21);
            this.tb_address.TabIndex = 78;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(74, 72);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(159, 21);
            this.tb_id.TabIndex = 77;
            // 
            // dtp_recdate
            // 
            this.dtp_recdate.Location = new System.Drawing.Point(551, 14);
            this.dtp_recdate.Name = "dtp_recdate";
            this.dtp_recdate.Size = new System.Drawing.Size(115, 21);
            this.dtp_recdate.TabIndex = 75;
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(338, 17);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(111, 21);
            this.dtp_birthday.TabIndex = 74;
            this.dtp_birthday.ValueChanged += new System.EventHandler(this.dtp_birthday_ValueChanged);
            // 
            // cmb_sex
            // 
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(212, 17);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(75, 20);
            this.cmb_sex.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 70;
            this.label20.Text = "卡类型：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(454, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 69;
            this.label19.Text = "手术史：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(455, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 68;
            this.label18.Text = "过敏史：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(254, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 66;
            this.label16.Text = "联系电话：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 64;
            this.label14.Text = "紧急联系人1：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 63;
            this.label13.Text = "E-mail：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 59;
            this.label9.Text = "家庭住址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "联系电话：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 55;
            this.label5.Text = "身份证号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 54;
            this.label4.Text = "生日：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "登记日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(19, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 398);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            // 
            // tb_firstman2
            // 
            this.tb_firstman2.Location = new System.Drawing.Point(84, 195);
            this.tb_firstman2.Name = "tb_firstman2";
            this.tb_firstman2.Size = new System.Drawing.Size(117, 21);
            this.tb_firstman2.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 97;
            this.label15.Text = "紧急联系人2：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(254, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 98;
            this.label17.Text = "联系电话：";
            // 
            // tb_firstphone2
            // 
            this.tb_firstphone2.Location = new System.Drawing.Point(325, 197);
            this.tb_firstphone2.Name = "tb_firstphone2";
            this.tb_firstphone2.Size = new System.Drawing.Size(123, 21);
            this.tb_firstphone2.TabIndex = 100;
            // 
            // tb_nation
            // 
            this.tb_nation.Location = new System.Drawing.Point(362, 49);
            this.tb_nation.Name = "tb_nation";
            this.tb_nation.Size = new System.Drawing.Size(87, 21);
            this.tb_nation.TabIndex = 96;
            this.tb_nation.Text = "汉";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 95;
            this.label11.Text = "民族：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
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
            this.groupBox3.Location = new System.Drawing.Point(10, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 156);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            // 
            // btn_patientNo
            // 
            this.btn_patientNo.Location = new System.Drawing.Point(264, 106);
            this.btn_patientNo.Name = "btn_patientNo";
            this.btn_patientNo.Size = new System.Drawing.Size(103, 23);
            this.btn_patientNo.TabIndex = 96;
            this.btn_patientNo.Text = "生成患者编号";
            this.btn_patientNo.UseVisualStyleBackColor = true;
            this.btn_patientNo.Click += new System.EventHandler(this.btn_patientNo_Click);
            // 
            // tb_patientNo
            // 
            this.tb_patientNo.Location = new System.Drawing.Point(264, 33);
            this.tb_patientNo.Name = "tb_patientNo";
            this.tb_patientNo.Size = new System.Drawing.Size(117, 21);
            this.tb_patientNo.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 94;
            this.label12.Text = "患者编号：";
            // 
            // tb_cardNo
            // 
            this.tb_cardNo.Location = new System.Drawing.Point(74, 108);
            this.tb_cardNo.Name = "tb_cardNo";
            this.tb_cardNo.Size = new System.Drawing.Size(117, 21);
            this.tb_cardNo.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 92;
            this.label7.Text = "就诊卡号：";
            // 
            // tb_nationality
            // 
            this.tb_nationality.Location = new System.Drawing.Point(221, 51);
            this.tb_nationality.Name = "tb_nationality";
            this.tb_nationality.Size = new System.Drawing.Size(69, 21);
            this.tb_nationality.TabIndex = 92;
            this.tb_nationality.Text = "中国";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(172, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 66;
            this.label21.Text = "国籍：";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(55, 51);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(38, 21);
            this.tb_age.TabIndex = 65;
            this.tb_age.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 64;
            this.label6.Text = "年龄：";
            // 
            // tb_searchId
            // 
            this.tb_searchId.Location = new System.Drawing.Point(19, 29);
            this.tb_searchId.Name = "tb_searchId";
            this.tb_searchId.Size = new System.Drawing.Size(157, 21);
            this.tb_searchId.TabIndex = 99;
            // 
            // btn_searchId
            // 
            this.btn_searchId.Location = new System.Drawing.Point(196, 29);
            this.btn_searchId.Name = "btn_searchId";
            this.btn_searchId.Size = new System.Drawing.Size(127, 23);
            this.btn_searchId.TabIndex = 100;
            this.btn_searchId.Text = "根据身份证号搜索";
            this.btn_searchId.UseVisualStyleBackColor = true;
            this.btn_searchId.Click += new System.EventHandler(this.btn_searchId_Click);
            // 
            // tb_searchPatienNo
            // 
            this.tb_searchPatienNo.Location = new System.Drawing.Point(19, 68);
            this.tb_searchPatienNo.Name = "tb_searchPatienNo";
            this.tb_searchPatienNo.Size = new System.Drawing.Size(157, 21);
            this.tb_searchPatienNo.TabIndex = 101;
            // 
            // btn_searchPatientNo
            // 
            this.btn_searchPatientNo.Location = new System.Drawing.Point(196, 68);
            this.btn_searchPatientNo.Name = "btn_searchPatientNo";
            this.btn_searchPatientNo.Size = new System.Drawing.Size(127, 23);
            this.btn_searchPatientNo.TabIndex = 102;
            this.btn_searchPatientNo.Text = "根据患者编号搜索";
            this.btn_searchPatientNo.UseVisualStyleBackColor = true;
            this.btn_searchPatientNo.Click += new System.EventHandler(this.btn_searchPatientNo_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(369, 37);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 12);
            this.label25.TabIndex = 104;
            this.label25.Text = "输入姓名自动检索：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_searchName);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.tb_searchId);
            this.groupBox4.Controls.Add(this.btn_searchPatientNo);
            this.groupBox4.Controls.Add(this.btn_searchId);
            this.groupBox4.Controls.Add(this.tb_searchPatienNo);
            this.groupBox4.Location = new System.Drawing.Point(19, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 106);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "搜索已有病人信息";
            // 
            // cmb_searchName
            // 
            this.cmb_searchName.FormattingEnabled = true;
            this.cmb_searchName.Location = new System.Drawing.Point(488, 34);
            this.cmb_searchName.Name = "cmb_searchName";
            this.cmb_searchName.Size = new System.Drawing.Size(177, 20);
            this.cmb_searchName.TabIndex = 105;
            this.cmb_searchName.SelectedIndexChanged += new System.EventHandler(this.cmb_searchName_SelectedIndexChanged);
            // 
            // Frm_patient
            // 
            this.AcceptButton = this.btn_addpatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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


    }
}