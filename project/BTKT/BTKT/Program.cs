using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //model.ConNguoi ng = new model.ConNguoi();
            //ng.Nhap();
            //ng.Xuat();
            //Console.ReadLine();

            //model.SinhVien sv = new model.SinhVien("001","D15CNPM3",9.00f,"90213412","Nguyen Huu Huan",2002,"Nam");
            //sv.Xuat();


            //model.ConNguoi a = new model.GiangVien();
            //a.Nhap();
            //a.Xuat();

            //model.shape.iShape a = new model.shape.Circle(3);
            //Console.WriteLine($"Area Circle: {a.Area()}");

            //model.shape.iShape b = new model.shape.Square(3);
            //Console.WriteLine($"Area Square: {b.Area()}");

            // abstract
            //model.ConNguoi sv1 = new model.SinhVien();
            //sv1.Nhap();
            //Console.WriteLine($"Ma Sinh Vien: {sv1.getMa()}");


            // Properties
            //model.SinhVien sv = new model.SinhVien();
            //sv.Nhap();
            //Console.WriteLine($"Ma Sinh Vien: {sv.MaSV}");

            // Exception handing
            
            try
            {
                //model.SinhVien sv2 = new model.SinhVien();
                //sv2.Nhap();
                //float A = 1f / sv2.DTB;         

                //Sử dụng 1 Collection để quản lý một danh sách sinh viên
                int n;
                
                

            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine("error: " + ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("error: " + ex2.Message);
            }

            Console.ReadLine();
        }
    }
}
