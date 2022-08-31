using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT.model
{
    class GiangVien : ConNguoi
    {
        String MaGV;
        int SoBaiBao;
        public GiangVien() { }
        public GiangVien(String MaGV, int SoBaiBao, String CMND, String Ten, int NamSinh, String GioiTinh)
            : base(CMND, Ten, NamSinh, GioiTinh)
        {
            this.MaGV = MaGV;
            this.SoBaiBao = SoBaiBao;
        }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Ma GV: ");
            MaGV = Console.ReadLine();

            Console.Write("So Bai Bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{MaGV}\t{SoBaiBao}");
        }

        public override String getMa()
        {
            return MaGV;
        }
    }
}
