using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_3
{
    public class VeMayBay
    {
        String TenChuyen;
        int NgayBay;
        int GiaVe;
        public void Nhap()
        {
            Console.Write("Nhap ten chuyen: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhap ngay bay: ");
            NgayBay = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ve: ");
            GiaVe = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ten Chuyen: " + TenChuyen);
            Console.WriteLine($"Ngay Bay: {NgayBay}");
            Console.WriteLine("Gia ve: " + GiaVe);
        }
        public int getGiaVe
        {
            get
            {
                return GiaVe;
            }
        }
    }
}
