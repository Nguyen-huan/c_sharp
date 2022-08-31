using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_4
{
    public class TayTrang
    {
        String selection;
        int ChiPhi = 0;
        public TayTrang() { }
        public void Nhap()
        {
            Console.Write("Ban co chon tay trang: ");
            do
            {
                selection = Console.ReadLine();
                if (selection != "yes" && selection != "no")
                    Console.Write("Ban phai chon yes/no: ");
            } while (selection != "no" && selection != "yes");
        }
        public int getTienTayTrang()
        {
            if (selection == "yes")
            {
                ChiPhi = 1500000;
            }
            return ChiPhi;
        }
    }
}

