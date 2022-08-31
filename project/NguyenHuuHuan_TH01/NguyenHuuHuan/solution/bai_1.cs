using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution
{
    internal class bai_1
    {
        char[,] a;
        int h;
        public bai_1() { }
        public void NhapChieuCao()
        {
            Console.Write("Nhap chieu cao h = ");
            h = int.Parse(Console.ReadLine());
        }
        public void VeTamGiac()
        {
            a = new char[h,h];
            for(int j = h - 1; j >= 0 ; j--)
            {
                for(int i = 0; i <= j; i++)
                { 
                    a[i, j] = '*';
                }
            }
        }
        public void HienThiTamGiac()
        {   
            for (int i = h - 1; i >= 0; i--)
            {
                for (int j = h - 1; j >= 0; j--)
                {
                    Console.Write($"{a[i,j]}   ");
                }
                Console.WriteLine();
            }
        }

    }
}
