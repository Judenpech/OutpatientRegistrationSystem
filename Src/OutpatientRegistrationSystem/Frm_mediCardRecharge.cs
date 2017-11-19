using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    public partial class Frm_mediCardRecharge : Form
    {
        public Frm_mediCardRecharge()
        {
            InitializeComponent();
        }

        private void Frm_mediCardRecharge_Load(object sender, EventArgs e)
        {
            cmb_paytype.Items.Add("现金支付");
            cmb_paytype.Items.Add("银行卡支付");
            cmb_paytype.Items.Add("支付宝支付");
            cmb_paytype.Items.Add("微信支付");
            cmb_paytype.SelectedIndex = 0;
        }
    }
}
