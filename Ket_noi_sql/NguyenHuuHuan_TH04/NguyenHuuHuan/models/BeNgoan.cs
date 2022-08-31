using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.models
{
    public class BeNgoan
    {
        string maBeNgoan;
        string maLop;
        string tenBeNgoan;
        DateTime ngaySinh;
        string hoTenBo;
        string hoTenMe;
        string diaChi;
        string gioiTinh;
        public BeNgoan() { }

        public string MaBeNgoan { get => maBeNgoan; set => maBeNgoan = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenBeNgoan { get => tenBeNgoan; set => tenBeNgoan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
