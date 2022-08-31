using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL3
{
    internal class Program
    {
        static void Cau_1()
        {
            double a, b, c;
            Console.Write("Nhap a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c = "); ;
            c = Convert.ToDouble(Console.ReadLine());
            // Trường hợp 1
            if(a == 0 && b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else 
                {
                    Console.WriteLine($"Ta co phuong trinh {c} = 0");
                    Console.WriteLine("Phuong trinh ==> Vo Ly!");
                }
            }
            // Trường hợp 2
            else if (a == 0 && b!= 0)
            {
                Console.WriteLine($"Ta co phuong trinh {b}x + {c} = 0");
                Console.WriteLine("Phuong trinh co mot nghiem: " + (-c / b));
            }
            // Trường hợp 3
            else
            {
                Console.WriteLine($"Ta co phuong trinh {a}x^2 + {b}x + {c} = 0");
                double  x1, x2;
                double delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co mot nghiem duy nhat la: " + x1);
                }
                else if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Phuong trinh co 2 nghiem la {x1} và {x2}");
                }
            }
        }
        static void Cau_2()
        {
            int dem = 0;
            Console.Write("Nhap so nguyen duong n = ");
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.Write("Dieu kien n > 0: ");
            } while (n <= 0);

            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} khong phai so nguyen to");                    
                    dem++;
                }
            }
            if (dem == 0) Console.WriteLine($"{n} la so nguyen to");
        }

        static void Cau_3()
        {
            int cot, hang;
            Console.Write("Nhap hang: ");
            do
            {
                hang = Convert.ToInt32(Console.ReadLine());
                if (hang <= 0)
                    Console.Write("Dieu kien hang > 0: ");
            } while (hang <= 0);

            Console.Write("Nhap cot: ");
            do
            {
                cot = Convert.ToInt32(Console.ReadLine());
                if (cot <= 0)
                    Console.Write("Dieu kien cot > 0: ");
            } while (cot <= 0);

            int[,] a = new int[hang, cot];
            Console.WriteLine("\n\n\tNhap cac phan tu cua mang: ");
            for (int i = 0; i < hang ; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\n\tHien thi mang vua nhap: ");
            for (int i = 0; i < hang ; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(a[i, j] + "   ");
                }
                Console.WriteLine();
            }

            if (hang == cot)
            {
                Console.WriteLine("Ma Tran vua nhap la ma tran vuong");
                Console.WriteLine("Cac phan tu thuoc duong cheo chinh cua ma tran tren la: ");
                for (int i = 0; i < hang; i++)
                    for (int j = 0; j < cot; j++)
                    {
                        if (i == j)
                            Console.Write(a[i, j] + "   ");
                    }
                Console.WriteLine("\nCac phan tu thuoc duong cheo phu cua ma tran tren la: ");
                for (int i = 0; i < hang; i++)
                    for (int j = 0; j < cot; j++)
                    {
                        if (i == j)
                            Console.Write(a[i, cot - 1 - i] + "   ");
                    }
            }
            else
                Console.WriteLine("Ma Tran vua nhap khong phai ma tran vuong");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("CAU 1");
            Cau_1();
            Console.WriteLine("\n\n\nCAU 2");
            Cau_2();
            Console.WriteLine("\n\n\nCAU 3");
            Cau_3();
            Console.ReadKey();
        }
    }
}
