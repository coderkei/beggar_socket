using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChisFlashBurner
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("zh-Hans");
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentUICulture;
            Application.Run(new Form1());
        }
    }
}
