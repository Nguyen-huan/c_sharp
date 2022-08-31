using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_4
{
    public class NhoRang
    {
        int dem = 0;
        int soluongNR;
        int TongTien;
        public NhoRang() { }
        public void Nhap()
        {
            Console.Write("Nhap so luong rang nho: ");
            soluongNR = int.Parse(Console.ReadLine());
            TongTien = soluongNR * 150000;
        }
        public void Xuat_TT()
        {
            Console.WriteLine($"So luong rang nho: {soluongNR}");
            Console.WriteLine($"Tong tien rang nho: {TongTien}");
        }
        public int getTienNR
        {
            get { return TongTien; }
        }
    }
}
