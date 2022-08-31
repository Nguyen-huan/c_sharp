using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_3
{
    public class HanhKhach : Nguoi
    {
        VeMayBay[] ve;
        int SoLuong;
        public HanhKhach() { }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine();
            Console.Write("Nhap so luong ve: ");
            SoLuong = int.Parse(Console.ReadLine());    
            Console.Write("\n");
            ve = new VeMayBay[SoLuong];
            for(int i = 0; i < ve.Length; i++)
            {
                ve[i] = new VeMayBay();
                ve[i].Nhap();
                Console.Write("\n");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            for(int i = 0; i < ve.Length; i++)
            {
                ve[i].Xuat();
                Console.Write("\n");
            }
        }
        public int TongTien()
        {
            int tong = 0;
            for(int i = 0; i< ve.Length; i++)
            {
                tong += ve[i].getGiaVe;
            }
            return tong;
        }
    }
}
