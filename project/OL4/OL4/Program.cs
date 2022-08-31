using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL4
{
    class SinhVien
    {
        public SinhVien()
        {

        }
        ~SinhVien()
        {

        }
        private int MaSV;
        private String HoTen;
        private String Lop;
        private float DTB;

        public void Nhap()
        {
            Console.Write("Ma SV: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Ho Ten SV: ");
            HoTen = Console.ReadLine();
            Console.Write("Lop: ");
            Lop = Console.ReadLine();
            Console.Write("Ma SV: ");
            DTB = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{MaSV}\t{HoTen}\t{Lop}\t{DTB}");
        }
        public float getDTB()
        {
            return DTB;
        }
    }
    class DanhSach
    {
        private SinhVien[] sv;
        private int SoLuong;
        ~DanhSach()
        {

        }
        public void Nhap()
        {
            Console.Write("Nhap So Sinh Vien: ");
            SoLuong = int.Parse(Console.ReadLine());
            sv = new SinhVien[SoLuong];
            for(int i = 0; i < sv.Length; i++)
            {
                sv[i] = new SinhVien(); 
                Console.WriteLine($"Nhap TT SV thu {i + 1}");
                sv[i].Nhap();
            }
        }
        public void Xuat()
        {
            for(int i = 0; i< sv.Length; i++)
            {
                sv[i].Xuat();
            }
        }
        public void SapXep()
        {
            for(int i = 0; i<= sv.Length; i++)
            {
                for(int j = sv.Length - 1; j > i; j--)
                {
                    if(sv[j].getDTB() > sv[j - 1].getDTB())
                    {
                        SinhVien tg = sv[j];
                        sv[j] = sv[j - 1];
                        sv[j - 1] = tg;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach LIST = new DanhSach();
            LIST.Nhap();
            LIST.Xuat();
            //SinhVien sv = new SinhVien();
            //sv.Nhap();
            //sv.Xuat();
            LIST.SapXep();
            Console.WriteLine("Sau Khi Sap Xep: ");
            LIST.Xuat();
            Console.ReadLine();
        }
    }
}
