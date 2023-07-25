using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramPr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStartInstagram());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmProfile(15,9,"امیر", "رضایی"));
            //Application.Run(new FrmSendPost(9));
            //Application.Run(new FrmMyPosts(9,"مریم","پوربهمن"));
        }
    }
}
