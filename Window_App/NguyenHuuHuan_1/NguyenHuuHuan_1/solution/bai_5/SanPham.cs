using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_5
{
    public class SanPham
    {
        int ma;
        float giaNhap, giaBan;
        int soluong;
        string hangSX;
        public SanPham() { }
        public void Nhap()
        {
            Console.Write("Nhap ma SP: ");
            ma = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia nhap: ");
            giaNhap = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            giaBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            soluong = int.Parse(Console.ReadLine());
            Console.Write("Nhap hang SX: ");
            hangSX = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"{ma}\t{giaNhap}\t{giaBan}\t{soluong}\t{hangSX}");
        }
    }
}
