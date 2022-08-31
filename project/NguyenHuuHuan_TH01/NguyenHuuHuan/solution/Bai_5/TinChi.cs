using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.Bai_5
{
    public class TinChi : MonHoc
    {
        double diem_tp, diem_thi, diem_tk;
        public TinChi() { }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem thanh phan: ");
            diem_tp = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi: ");
            diem_thi = double.Parse(Console.ReadLine());
            diem_tk = 0.3 * diem_tp + 0.7 * diem_thi;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{diem_tp}\t{diem_thi}\t{diem_tk}");
        }
        public double _DiemTK
        {
            get
            {
                return diem_tk;
            }
        }

    }
}
