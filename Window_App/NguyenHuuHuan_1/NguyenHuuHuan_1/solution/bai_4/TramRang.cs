using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_4
{
    public class TramRang
    {
        int soluongTR;
        int TongTien;
        public TramRang() { }
        public void Nhap()
        {
            Console.Write("Nhap so luong tram rang: ");
            soluongTR = int.Parse(Console.ReadLine());
            TongTien = soluongTR * 150000;
        }
        public void Xuat_TT()
        {
            Console.WriteLine($"So luong tram rang: {soluongTR}");
            Console.WriteLine($"Tong tien tram rang: {TongTien}");
        }
        public int getTienTT
        {
            get { return TongTien; }
        }
    }
}
