using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
                                //02_02_HTLongNVDucPDHoang_LTNET
namespace TT_LT.NET__BTL
{
    internal static class Program
    {
        public static string stringconnect = @"Data Source=(local);Initial Catalog=qlthuoc_02_HTLongNVDucPDHoang;Integrated Security=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
