using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.solution.bai_4
{
    public class CaoVoi
    {
        String selection;
        int ChiPhi = 0;
        public CaoVoi() { }
        public void Nhap()
        {
            Console.Write("Ban co chon cao voi: ");
            do
            {
                selection = Console.ReadLine();
                if (selection != "yes" && selection != "no")
                    Console.Write("Ban phai chon yes/no: ");
            }while (selection != "no" && selection != "yes");
        }
        public int getTienCV()
        { 
            if(selection == "yes")
            {
                ChiPhi = 100000;
            }
            return ChiPhi;
        }
    }
}
