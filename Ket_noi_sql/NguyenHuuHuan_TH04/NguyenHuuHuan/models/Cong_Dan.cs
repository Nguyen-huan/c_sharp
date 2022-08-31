using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.models
{
    public class Cong_Dan
    {
		string maCD;
		string maPhuong; 
		string tenCD;
		int cmnd;
		string gioiTinh;
		DateTime namSinh;
		int soDienThoai;
		public Cong_Dan() { }

        public string MaCD { get => maCD; set => maCD = value; }
        public string MaPhuong { get => maPhuong; set => maPhuong = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
        public int Cmnd { get => cmnd; set => cmnd = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public int SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }

}
