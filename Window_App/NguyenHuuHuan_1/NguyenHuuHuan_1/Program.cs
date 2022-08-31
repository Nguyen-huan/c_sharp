
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenHuuHuan.solution.bai_3;
namespace NguyenHuuHuan_1

{
    internal class Program
    {
        void Bai_3()
        {

        }
        static void Main(string[] args)
        {
            BAI 1
            solution.bai_1 b1 = new solution.bai_1();
            b1.Nhap();
            b1.BangChu();


            BAI 3
            int soKhach;
            Console.Write("Nhap So luong hanh khach: ");
            soKhach = int.Parse(Console.ReadLine());
            solution.bai_3.HanhKhach[] b3 = new solution.bai_3.HanhKhach[soKhach];
            Console.WriteLine("\tNhap thong tin Hanh Khach");

            for (int i = 0; i < b3.Length; i++)
            {
                b3[i] = new solution.bai_3.HanhKhach();
                Console.WriteLine($"   Hanh Khach thu {i + 1}");
                b3[i].Nhap();
                Console.WriteLine();
            }

            Console.WriteLine("\tHien thi thong tin Hanh Khach");
            for (int i = 0; i < b3.Length; i++)
            {
                Console.WriteLine($"   Thong tin Hanh Khach thu {i + 1}");
                b3[i].Xuat();
                Console.WriteLine($"Tong tien cua hanh khach co ma {b3[i].getHoten} la: {b3[i].TongTien()}");
                Console.WriteLine();
            }

            for (int i = 0; i < b3.Length; i++)
            {
                for (int j = 0; j < b3.Length; j++)
                {
                    if (b3[i].TongTien() > b3[j].TongTien())
                    {
                        solution.bai_3.HanhKhach temp = b3[i];
                        b3[i] = b3[j];
                        b3[j] = temp;
                    }
                }
            }
            Console.WriteLine("\tHien thi thong tin Hanh Khach sau khi sap xep");
            for (int i = 0; i < b3.Length; i++)
            {
                b3[i].Xuat();
                Console.WriteLine($"Tong tien cua hanh khach co ma {b3[i].getHoten} la: {b3[i].TongTien()}");
                Console.WriteLine();
            }


            Console.Write("Nhap so khach hang:  ");
            int soLuongKhachHang = int.Parse(Console.ReadLine());
            solution.bai_4.KhachHang[] b4 = new solution.bai_4.KhachHang[soLuongKhachHang];
            for (int i = 0; i < b4.Length; i++)
            {
                b4[i] = new solution.bai_4.KhachHang();
                b4[i].NhapThongTin();
            }
            for (int i = 0; i < b4.Length; i++)
            {
                b4[i].XuatThongTin();
            }














            Console.ReadLine();
        }
    }
}
