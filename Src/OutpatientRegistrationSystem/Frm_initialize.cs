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
    public partial class Frm_initialize : Form
    {
        public Frm_initialize()
        {
            InitializeComponent();
        }

        private void Frm_initialize_Load(object sender, EventArgs e)
        {
            //初始化
            ckb_closeconfirm.Select();
            label2.Text = "本功能将会清空医院所有业务数据，并且在清空的同时";
            label10.Text = "，可以将基础资料也清空，请谨慎使用此功能！";
            label3.Text = "此功能一般用于清空演示数据！";
            label11.Text = "警告：以下操作非请勿用，否则造成损失，后果自负！！！";
            label14.Text = "为提高系统运行速度，可将旧数据进行备份（以后可以查询），然后\n"
                +"进行数据清理，清理前必须对原数据进行备份，切记！清理前应通知\n"
                +"所有客户端退出软件，等清理完毕再运行系统！";
            label15.Text = "第二步：选择清理此日期之前的所有数据";
        }

        private void btn_rebuild_Click(object sender, EventArgs e)
        {

        }
    }
}
