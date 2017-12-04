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
    public partial class Frm_systemRebuild : Form
    {
        public Frm_systemRebuild()
        {
            InitializeComponent();
        }

        private void Frm_systemRebuild_Load(object sender, EventArgs e)
        {
            label2.Text = "本功能将会清空医院所有业务数据，并且在清空的同时\n，可以将基础资料也清空，请谨慎使用此功能！";
            label3.Text = "此功能一般用于清空演示数据。";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rebuild_Click(object sender, EventArgs e)
        {

        }
    }
}
