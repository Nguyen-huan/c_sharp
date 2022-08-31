using System;
using System.Windows.Forms;

namespace NguyenHuuHuan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new bai_1());
            //Application.Run(new solution.bai_2());
            //Application.Run(new solution.bai_3());
            //Application.Run(new solution.bai_4());
            //Application.Run(new solution.bai_5());
            Application.Run(new solution.Bai_6());


        }
    }
}
