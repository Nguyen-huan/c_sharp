using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution
{
    internal class bai_2
    {
        double a, b, c;
        public bai_2() { }
        public void NhapBaSo()
        {
            Console.Write("Nhap a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c = ");
            c = double.Parse(Console.ReadLine());
        }
        public void GiaiPhuongTrinh()
        {
            if(a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine($"Xet phuong trinh {c} = 0");
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem!");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else 
                {
                    Console.WriteLine($"Xet phuong trinh {b}x + {c} = 0");
                    Console.WriteLine($"Phuong trinh co nghiem duy nhat la: x = {b / c}");
                } 
            }
            else
            {
                Console.WriteLine($"Xet phuong trinh {a}x^2 + {b}x + {c} = 0");
                double delta = b * b - 4 * a * c;
                if(delta == 0)
                {
                    double x = - b / (2*a);
                    Console.WriteLine($"Phuong trinh co nghiem kep: {x}");
                }
                else if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else
                {
                    double x1 = (Math.Sqrt(delta) - b) / (2 * a);
                    double x2 = (-Math.Sqrt(delta) - b) / (2 * a);
                    Console.WriteLine($"Phuong trinh co hai nghiem: x1 = {x1} , x2 = {x2}");
                }
            }
        }
    }
}
