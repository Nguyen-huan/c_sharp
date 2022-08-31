using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BTH4_Nhom_2.solution
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

      
        public void getData()
        {
            List<models.clssHoaHong> lstHoaHong = new List<models.clssHoaHong>();
            string conn_str = "data source = (local); initial catalog = HoaHong; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"select * from BENGOAN, LopHoc where MABN = '{txtMaBeNgoan.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            models.clssHoaHong bn = new models.clssHoaHong();
            bn.MaLop = (string)rd["MALOP"];
            bn.MaBeNgoan = (string)rd["MABN"];
            bn.HoTenMe = (string)rd["HOTENME"];
            bn.HoTenBo = (string)rd["HOTENBO"];
            bn.DiaChi = (string)rd["DIACHI"];
            bn.GioiTinh = (string)rd["GIOITINH"];
            bn.NgaySinh = (DateTime)rd["NGAYSINH"];
            bn.TenLop = (string)rd["TENLOP"];
            bn.TenBeNgoan = (string)rd["TENBENGOAN"];
            lstHoaHong.Add(bn);
            conn.Close();
            dgvHoaHong.DataSource = lstHoaHong;
        }
        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            getData();
        }
    }
}
