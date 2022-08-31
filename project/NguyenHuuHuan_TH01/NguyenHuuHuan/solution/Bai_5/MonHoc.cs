using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.Bai_5
{
    public class MonHoc
    {
        int mamh;
        String tenmh;
        int stc;
        public MonHoc() { }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma mon hoc: ");
            mamh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten mon hoc: ");
            tenmh = Console.ReadLine();
            Console.Write("Nhap so tin chi: ");
            stc = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"{mamh}\t{tenmh}\t{stc}");
        }
        public int _stc
        {
            get
            {
                return stc;
            }
        }
    }
}
