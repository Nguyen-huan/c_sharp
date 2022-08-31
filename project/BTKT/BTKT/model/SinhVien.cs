using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT.model
{
    class SinhVien : ConNguoi
    {
        String _MaSV;
        String _MaLop;
        float _DTB;

        public SinhVien() { }
        public SinhVien(String MaSV, String MaLop, float DTB, String CMND, String Ten, int NamSinh, String GioiTinh)
            : base(CMND, Ten, NamSinh, GioiTinh)
        {
            this._MaSV = MaSV;
            this._MaLop = MaLop;
            this._DTB = DTB;
        }
        public String MaSV
        {
            get 
            { 
                return _MaSV; 
            }
        }
        public String MaLop
        {
            get
            {
                return _MaLop;
            }
        }
        public float DTB
        {
            get
            {
                return _DTB;
            }
            set
            {
                _DTB = value;
            }
        }
        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Ma SV: ");
            _MaSV = Console.ReadLine();

            Console.Write("Ma Lop: ");
            _MaLop = Console.ReadLine();

            Console.Write("DTB: ");
            DTB = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine($"{MaSV}\t{MaLop}\t{DTB}");
        }

        public override String getMa()
        {
            return _MaSV;
        }
    }
}
