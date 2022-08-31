using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKetNoi.models
{
    public class nguoiDung
    {
        string taiKhoan, matKhau, quyenAdmin;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string QuyenAdmin { get => quyenAdmin; set => quyenAdmin = value; }
    }
}
