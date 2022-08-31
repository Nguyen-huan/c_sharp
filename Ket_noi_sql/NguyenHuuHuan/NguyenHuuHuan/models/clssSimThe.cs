using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHuan.models
{
    public class clssSimThe
    {
        int iD;
        int mangID;
        DateTime ngayKihHoat;
        DateTime ngayHetHan;
        public clssSimThe() { }

        public int ID { get => iD; set => iD = value; }
        public int MangID { get => mangID; set => mangID = value; }
        public DateTime NgayKihHoat { get => ngayKihHoat; set => ngayKihHoat = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
    }
}
