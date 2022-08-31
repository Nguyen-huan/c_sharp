using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH4_Nhom_2.models
{
    public class clssHoaHong
    {
        string maBeNgoan;
        string maLop;
        string tenBeNgoan;
        string tenLop;
        string gioiTinh;
        string hoTenBo;
        string hoTenMe;
        string diaChi;
        DateTime ngaySinh;

        public string MaBeNgoan { get => maBeNgoan; set => maBeNgoan = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenBeNgoan { get => tenBeNgoan; set => tenBeNgoan = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
