using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_3
{
    public class Nguoi
    {
        String Hoten;
        String GioiTinh;
        int Tuoi;
        public Nguoi() { }
        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"{Hoten}    {GioiTinh}     {Tuoi}\n");
        }
        public String getHoten
        {
            get { return Hoten; }
        }
    }
}
