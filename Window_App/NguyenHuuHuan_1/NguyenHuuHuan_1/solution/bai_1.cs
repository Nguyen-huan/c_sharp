using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution
{
    public class bai_1
    {
        int n;
        public bai_1() { }
        public void Nhap()
        {
            Console.Write("Nhap so nguyen n: ");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 9)
                    Console.Write("Nhap so nguyen n tu 0 den 9: ");
            } while (n < 0 || n > 9);
        }
        public void BangChu()
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
            }
        }
    }
}
