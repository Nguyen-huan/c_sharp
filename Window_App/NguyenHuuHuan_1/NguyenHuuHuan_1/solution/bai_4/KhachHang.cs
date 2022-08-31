using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_4
{
    public class KhachHang
    {
        String TenKhachHang;
        int TongTien;
        NhoRang nhoRang;
        TayTrang tayRang;
        TramRang tramRang;
        CaoVoi cVoi;
        public KhachHang() { }
        public void NhapThongTin()
        {
            cVoi = new CaoVoi();
            tayRang = new TayTrang();
            tramRang = new TramRang();
            nhoRang = new NhoRang();
            Console.Write("Ten Khach Hang: ");
            TenKhachHang = Console.ReadLine();
            cVoi.Nhap();
            tayRang.Nhap();
            nhoRang.Nhap();
            tramRang.Nhap();
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Khach Hang: {TenKhachHang}");
            TongTien = cVoi.getTienCV() + tayRang.getTienTayTrang() + nhoRang.getTienNR + tramRang.getTienTT;
            Console.WriteLine($"Tong tien cua khach la: {TongTien}");
        }
    }
}
