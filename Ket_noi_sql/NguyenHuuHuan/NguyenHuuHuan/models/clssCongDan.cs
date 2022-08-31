using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.models
{
    public class clssCongDan
    {
        string maCD;
        string tenCD;
        int cmnd;
        string gioiTinh;
        DateTime namSinh;
        string soDienThoai;
        public clssCongDan() { }

        public string MaCD { get => maCD; set => maCD = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
