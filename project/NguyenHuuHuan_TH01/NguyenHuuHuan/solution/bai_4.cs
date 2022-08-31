using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution
{
    internal class bai_4
    {
        int m, n;
        float[][] a;
        public bai_4() { }
        public void NhapMaTran()
        {            
            Console.Write("Nhap so hang: ");
            m = int.Parse(Console.ReadLine());
            a = new float[m][];
            for (int i = 0; i < m; i++)
            {
                Console.Write("Nhap so cot: ");
                n = int.Parse(Console.ReadLine());
                a[i] = new float[n];
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i][j] = float.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n\n");
        }
        public void XuatMaTran()
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}  ");
                }
                Console.WriteLine();
            }
        }

    }
}
