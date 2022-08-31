using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.Bai_5
{
    public class SinhVien
    {
        int masv;
        String hoten;
        int sltc;
        TinChi[] a;
        public SinhVien() { }
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            masv = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap so luong mon hoc da dang ki: ");
            sltc = int.Parse(Console.ReadLine());
            Console.WriteLine();
            a = new TinChi[sltc];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = new TinChi();
                Console.WriteLine($"  Nhap thong tin mon {i+1}");
                a[i].Nhap();
                Console.WriteLine();
            }
        }
        public void Xuat()
        {
            Console.WriteLine($"{masv}\t{hoten}\t{sltc}");
            for(int i = 0; i< a.Length; i++)
            {
                a[i].Xuat();
            }
        }
        public double DiemTK_TK()
        {
            int tongtc = 0;
            double tongCacMon = 0;
            for(int i = 0; i< a.Length; i++)
            {
                tongCacMon += a[i]._DiemTK*a[i]._stc;
            }
            for (int i = 0; i < a.Length; i++)
            {
                tongtc += a[i]._stc;
            }
            double DTK_TK = tongCacMon / tongtc;
            return DTK_TK;
        }
    }
}
