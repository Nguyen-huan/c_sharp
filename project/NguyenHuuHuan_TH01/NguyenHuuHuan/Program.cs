using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solution.bai_1 b1 = new solution.bai_1();
            //b1.NhapChieuCao();
            //b1.VeTamGiac();
            //b1.HienThiTamGiac();

            //solution.bai_2 b2 = new solution.bai_2();
            //b2.NhapBaSo();
            //b2.GiaiPhuongTrinh();

            //solution.bai_3 b3 = new solution.bai_3();
            //b3.NhapMaTran();
            //b3.XuatMaTran();
            //b3.KiemTra();

            //solution.bai_4 b4 = new solution.bai_4();
            //b4.NhapMaTran();
            //b4.XuatMaTran();

            int n;
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            solution.Bai_5.SinhVien[] b5 = new solution.Bai_5.SinhVien[n];
            for(int i = 0; i < n; i++)
            {
                b5[i] = new solution.Bai_5.SinhVien();
                Console.WriteLine($"\n\tNhap cho sinh vien thu {i + 1}");
                b5[i].Nhap();
                Console.WriteLine();
            }
            Console.WriteLine("\nHien Thi thong tin SINH VIEN");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n\tThong tin sinh vien thu {i+1}");
                b5[i].Xuat();
                Console.WriteLine();
                Console.WriteLine($"\nDiem Tong Ket Toan Khoa la: " + b5[i].DiemTK_TK());
                if (b5[i].DiemTK_TK() < 6)
                    Console.WriteLine("\nXep Loai TB");
                else if (b5[i].DiemTK_TK() >= 6 && b5[i].DiemTK_TK() < 8)
                    Console.WriteLine("\nXep Loau Kha");
                else
                    Console.WriteLine("Xep loai Gioi");
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if(b5[i].DiemTK_TK() < b5[j].DiemTK_TK())
                    {
                        solution.Bai_5.SinhVien temp = b5[i];
                        b5[i] = b5[j];
                        b5[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nHien Thi thong tin SINH VIEN sau khi SAP XEP");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n\tThong tin sinh vien thu {i + 1}");
                b5[i].Xuat();
                Console.WriteLine();
                Console.WriteLine($"\nDiem Tong Ket Toan Khoa la: " + b5[i].DiemTK_TK());
            } 
            Console.ReadLine();
        }
    }
}
