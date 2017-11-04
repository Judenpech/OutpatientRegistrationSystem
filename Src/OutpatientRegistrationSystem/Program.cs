using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OutpatientRegistrationSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_login login = new Frm_login();
            if ( login.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Frm_Main());
            }
        }
    }
}
