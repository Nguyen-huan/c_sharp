using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //Application.Run(new solution.formDangNhap());
            //Application.Run(new solution.CongDan());
            //Application.Run(new solution.TimKiem());
            //Application.Run(new solution.BeNgoan());
            //Application.Run(new solution.Loc());
            //Application.Run(new solution.XoaSanPham_bai_7());
            //Application.Run(new solution.SimThe());
            Application.Run(new solution.SanPham());



        }
    }
}
