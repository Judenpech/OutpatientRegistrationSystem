namespace OutpatientRegistrationSystem
{
    partial class Frm_mediCardRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mediCardRecharge));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_balanceQuery = new System.Windows.Forms.Button();
            this.btn_recharge = new System.Windows.Forms.Button();
            this.nud_money = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_wechat = new System.Windows.Forms.RadioButton();
            this.rdo_alipay = new System.Windows.Forms.RadioButton();
            this.rdo_creditCard = new System.Windows.Forms.RadioButton();
            this.rdo_cash = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_patientno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cardno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo_patientno = new System.Windows.Forms.RadioButton();
            this.rdo_visitno = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_searchvn = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_searchPatienNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_money)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_balanceQuery);
            this.groupBox1.Controls.Add(this.btn_recharge);
            this.groupBox1.Controls.Add(this.nud_money);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdo_wechat);
            this.groupBox1.Controls.Add(this.rdo_alipay);
            this.groupBox1.Controls.Add(this.rdo_creditCard);
            this.groupBox1.Controls.Add(this.rdo_cash);
            this.groupBox1.Location = new System.Drawing.Point(228, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支付方式";
            // 
            // btn_balanceQuery
            // 
            this.btn_balanceQuery.Location = new System.Drawing.Point(213, 105);
            this.btn_balanceQuery.Margin = new System.Windows.Forms.Padding(2);
            this.btn_balanceQuery.Name = "btn_balanceQuery";
            this.btn_balanceQuery.Size = new System.Drawing.Size(75, 23);
            this.btn_balanceQuery.TabIndex = 108;
            this.btn_balanceQuery.Text = "余额查询";
            this.btn_balanceQuery.UseVisualStyleBackColor = true;
            this.btn_balanceQuery.Click += new System.EventHandler(this.btn_balanceQuery_Click);
            // 
            // btn_recharge
            // 
            this.btn_recharge.Location = new System.Drawing.Point(213, 142);
            this.btn_recharge.Margin = new System.Windows.Forms.Padding(2);
            this.btn_recharge.Name = "btn_recharge";
            this.btn_recharge.Size = new System.Drawing.Size(75, 23);
            this.btn_recharge.TabIndex = 107;
            this.btn_recharge.Text = "充值";
            this.btn_recharge.UseVisualStyleBackColor = true;
            this.btn_recharge.Click += new System.EventHandler(this.btn_recharge_Click);
            // 
            // nud_money
            // 
            this.nud_money.Location = new System.Drawing.Point(88, 140);
            this.nud_money.Name = "nud_money";
            this.nud_money.Size = new System.Drawing.Size(77, 21);
            this.nud_money.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "充值金额：";
            // 
            // rdo_wechat
            // 
            this.rdo_wechat.AutoSize = true;
            this.rdo_wechat.Location = new System.Drawing.Point(142, 62);
            this.rdo_wechat.Name = "rdo_wechat";
            this.rdo_wechat.Size = new System.Drawing.Size(71, 16);
            this.rdo_wechat.TabIndex = 3;
            this.rdo_wechat.TabStop = true;
            this.rdo_wechat.Text = "微信支付";
            this.rdo_wechat.UseVisualStyleBackColor = true;
            // 
            // rdo_alipay
            // 
            this.rdo_alipay.AutoSize = true;
            this.rdo_alipay.Location = new System.Drawing.Point(142, 26);
            this.rdo_alipay.Name = "rdo_alipay";
            this.rdo_alipay.Size = new System.Drawing.Size(83, 16);
            this.rdo_alipay.TabIndex = 2;
            this.rdo_alipay.TabStop = true;
            this.rdo_alipay.Text = "支付宝支付";
            this.rdo_alipay.UseVisualStyleBackColor = true;
            // 
            // rdo_creditCard
            // 
            this.rdo_creditCard.AutoSize = true;
            this.rdo_creditCard.Location = new System.Drawing.Point(18, 62);
            this.rdo_creditCard.Name = "rdo_creditCard";
            this.rdo_creditCard.Size = new System.Drawing.Size(83, 16);
            this.rdo_creditCard.TabIndex = 1;
            this.rdo_creditCard.TabStop = true;
            this.rdo_creditCard.Text = "信用卡支付";
            this.rdo_creditCard.UseVisualStyleBackColor = true;
            // 
            // rdo_cash
            // 
            this.rdo_cash.AutoSize = true;
            this.rdo_cash.Location = new System.Drawing.Point(18, 26);
            this.rdo_cash.Name = "rdo_cash";
            this.rdo_cash.Size = new System.Drawing.Size(71, 16);
            this.rdo_cash.TabIndex = 0;
            this.rdo_cash.TabStop = true;
            this.rdo_cash.Text = "现金支付";
            this.rdo_cash.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_patientno);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_balance);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_cardno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "就诊卡信息";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(92, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "患者姓名：";
            // 
            // tb_patientno
            // 
            this.tb_patientno.Location = new System.Drawing.Point(92, 30);
            this.tb_patientno.Name = "tb_patientno";
            this.tb_patientno.Size = new System.Drawing.Size(100, 21);
            this.tb_patientno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "患者编号：";
            // 
            // tb_balance
            // 
            this.tb_balance.Location = new System.Drawing.Point(92, 139);
            this.tb_balance.Name = "tb_balance";
            this.tb_balance.Size = new System.Drawing.Size(100, 21);
            this.tb_balance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "余额：";
            // 
            // tb_cardno
            // 
            this.tb_cardno.Location = new System.Drawing.Point(92, 102);
            this.tb_cardno.Name = "tb_cardno";
            this.tb_cardno.Size = new System.Drawing.Size(100, 21);
            this.tb_cardno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "就诊卡号：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdo_patientno);
            this.groupBox4.Controls.Add(this.rdo_visitno);
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Controls.Add(this.cmb_searchName);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.tb_searchvn);
            this.groupBox4.Controls.Add(this.btn_search);
            this.groupBox4.Controls.Add(this.tb_searchPatienNo);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 149);
            this.groupBox4.TabIndex = 106;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "搜索已有患者就诊卡信息";
            // 
            // rdo_patientno
            // 
            this.rdo_patientno.AutoSize = true;
            this.rdo_patientno.Location = new System.Drawing.Point(22, 75);
            this.rdo_patientno.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_patientno.Name = "rdo_patientno";
            this.rdo_patientno.Size = new System.Drawing.Size(119, 16);
            this.rdo_patientno.TabIndex = 116;
            this.rdo_patientno.TabStop = true;
            this.rdo_patientno.Text = "根据患者编号查询";
            this.rdo_patientno.UseVisualStyleBackColor = true;
            // 
            // rdo_visitno
            // 
            this.rdo_visitno.AutoSize = true;
            this.rdo_visitno.Location = new System.Drawing.Point(22, 34);
            this.rdo_visitno.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_visitno.Name = "rdo_visitno";
            this.rdo_visitno.Size = new System.Drawing.Size(119, 16);
            this.rdo_visitno.TabIndex = 114;
            this.rdo_visitno.TabStop = true;
            this.rdo_visitno.Text = "根据就诊卡号查询";
            this.rdo_visitno.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(320, 114);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 106;
            this.btn_clear.Text = "重置";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmb_searchName
            // 
            this.cmb_searchName.FormattingEnabled = true;
            this.cmb_searchName.Location = new System.Drawing.Point(347, 71);
            this.cmb_searchName.Name = "cmb_searchName";
            this.cmb_searchName.Size = new System.Drawing.Size(157, 20);
            this.cmb_searchName.TabIndex = 105;
            this.cmb_searchName.SelectedIndexChanged += new System.EventHandler(this.cmb_searchName_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(345, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 12);
            this.label25.TabIndex = 104;
            this.label25.Text = "输入姓名自动检索：";
            // 
            // tb_searchvn
            // 
            this.tb_searchvn.Location = new System.Drawing.Point(160, 33);
            this.tb_searchvn.Name = "tb_searchvn";
            this.tb_searchvn.Size = new System.Drawing.Size(138, 21);
            this.tb_searchvn.TabIndex = 99;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(429, 114);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 102;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_searchPatienNo
            // 
            this.tb_searchPatienNo.Location = new System.Drawing.Point(160, 72);
            this.tb_searchPatienNo.Name = "tb_searchPatienNo";
            this.tb_searchPatienNo.Size = new System.Drawing.Size(138, 21);
            this.tb_searchPatienNo.TabIndex = 101;
            // 
            // Frm_mediCardRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 356);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_mediCardRecharge";
            this.Text = "就诊卡充值";
            this.Load += new System.EventHandler(this.Frm_mediCardRecharge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_money)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_creditCard;
        private System.Windows.Forms.RadioButton rdo_cash;
        private System.Windows.Forms.RadioButton rdo_alipay;
        private System.Windows.Forms.RadioButton rdo_wechat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cardno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_patientno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_searchName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_searchvn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_searchPatienNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_recharge;
        private System.Windows.Forms.NumericUpDown nud_money;
        private System.Windows.Forms.RadioButton rdo_patientno;
        private System.Windows.Forms.RadioButton rdo_visitno;
        private System.Windows.Forms.Button btn_balanceQuery;

    }
}