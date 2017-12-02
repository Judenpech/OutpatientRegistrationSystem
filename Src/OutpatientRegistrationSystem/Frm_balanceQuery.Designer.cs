namespace OutpatientRegistrationSystem
{
    partial class Frm_balanceQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_balanceQuery));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo_patientno = new System.Windows.Forms.RadioButton();
            this.rdo_visitno = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_searchName = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_searchvn = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_searchPatienNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_patientno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cardno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox4.Location = new System.Drawing.Point(3, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 149);
            this.groupBox4.TabIndex = 107;
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
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 182);
            this.groupBox2.TabIndex = 108;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(310, 176);
            this.dataGridView1.TabIndex = 109;
            // 
            // Frm_balanceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_balanceQuery";
            this.Text = "余额查询";
            this.Load += new System.EventHandler(this.Frm_balanceQuery_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdo_patientno;
        private System.Windows.Forms.RadioButton rdo_visitno;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_searchName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_searchvn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_searchPatienNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_patientno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cardno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}