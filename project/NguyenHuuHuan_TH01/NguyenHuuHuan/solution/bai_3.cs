using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution
{
    internal class bai_3
    {
        int m, n;
        float[,] a;
        public bai_3() { }
        public void NhapMaTran()
        {
            Console.Write("Nhap hang: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Nhap cot: ");
            n = int.Parse(Console.ReadLine());
            a = new float[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i, j] = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\n\n");
        }
        public void XuatMaTran()
        {
            Console.WriteLine("Ma tran vua nhap la: ");            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\t{a[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
        }
        public void KiemTra()
        {
            if (m == n)
            {
                Console.WriteLine("Ma tran vua nhap la ma tran vuong!\n\n");
                Console.WriteLine("Duong cheo chinh cua ma tran la: ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                            Console.Write($"\t{a[i, j]}  ");
                    }
                }
                Console.WriteLine("\n\nDuong cheo phu cua ma tran la: ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i + j == m - 1)
                            Console.Write($"\t{a[i, j]}  ");
                    }
                }
            }
            else 
                Console.WriteLine("Ma tran vua nhap la khong ma tran vuong!");
        }
    }
}
