using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKT.model
{
    abstract class ConNguoi
    {
        String CMND;
        String Ten;
        int NamSinh;
        String GioiTinh;
        public ConNguoi() { }
        public ConNguoi(String CMND, String Ten, int NamSinh, String GioiTinh)
        {
            this.CMND = CMND;
            this.Ten = Ten;
            this.NamSinh = NamSinh;
            this.GioiTinh = GioiTinh;
        }
        public virtual void Nhap()
        {
            Console.Write("CMND: ");
            CMND = Console.ReadLine();

            Console.Write("Ten: ");
            Ten = Console.ReadLine();

            Console.Write("NamSinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Gioi Tinh: ");
            GioiTinh = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"{CMND}\t{Ten}\t{NamSinh}\t{GioiTinh}");
        }
        public abstract String getMa();
    }
}
