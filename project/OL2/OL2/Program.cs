using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL2
{
    internal class Program
    {
        static void Mang_Hai_Chieu(int[,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\n\nXUAT MANG HAI CHIEU");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        static void Mang_Jaggle(int[][] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap so cot: ");
                int m = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[m];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\n\n\nXUAT MANG NHIEU CHIEU");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]}  ");
                }
                Console.WriteLine();
            }
        }
        static int TinhTong(int[][] arr, int n)
        {   
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    tong += arr[i][j];
                }
                Console.WriteLine();
            }
            return tong;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so hang n = ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n];
            Console.WriteLine("Nhap Mang Hai Chieu: ");
            Mang_Hai_Chieu(arr, n);

            Console.WriteLine("\n\n");

            int[][] arr_Jaggle = new int[n][];
            Console.WriteLine("Nhap Mang Jaggle: ");
            Mang_Jaggle(arr_Jaggle, n);

            Console.WriteLine("Tong Mang Jaggle la:  " + TinhTong(arr_Jaggle, n));
            Console.ReadKey();
        }
    }
}
