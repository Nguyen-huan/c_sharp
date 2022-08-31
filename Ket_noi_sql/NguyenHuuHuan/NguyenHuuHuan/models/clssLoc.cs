using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.models
{
    public class clssLoc
    {
        string maSanPham;
        string tenSanPham;
        DateTime ngaySanXuat;
        DateTime ngayHetHan;
        int soLuonTonKho;
        string nhaCungCap;

        public clssLoc() { }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public int SoLuonTonKho { get => soLuonTonKho; set => soLuonTonKho = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
    }
}
