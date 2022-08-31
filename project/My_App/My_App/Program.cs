using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_App
{
    internal class Program
    {
        static double GPT(double a, double b)
        {
            if (a == 0)
                return 0;
            else return -b / a;
        }
        static int GT(int n)
        {
            if (n == 1)
                return 1;
            return n * GT(n - 1);
        }
        static void Mang_Mot_Chieu(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            arr = arr.OrderBy(x => x).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }

        static void Mang_Hai_Chieu(int[,] arr, int n, int m)
        {
            for(int i = 0; i< n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i,j]}  ");
                }
                Console.WriteLine();
            }
        }

        static void Mang_Bat_Ky(int[][] arr, int n)
        {
            for(int i = 0; i< n; i++)
            {
                Console.Write("Nhap so cot: ");
                int cot = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[cot];
                for(int j = 0; j< arr[i].Length; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int i = 0; i< n; i++)
            {
                for(int j = 0; j< arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]}  ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            /*
            double a, b;
            Console.Write("Nhap a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Nghiem cua phuong trinh {a}x + {b} = 0 la: " + GPT(a, b));
            */

            int n;
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{n}! = " + GT(n));

            //int m;
            //Console.Write("Nhap m = ");
            //m = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];
            //Mang_Mot_Chieu(arr, n);
            //Console.WriteLine();

            //int[,] arr_1 = new int[n, m];
            //mang_hai_chieu(arr_1, n, m);

            int[][] arr_2 = new int[n][];
            Mang_Bat_Ky(arr_2, n);
            Console.ReadKey();
        }
    }
}
