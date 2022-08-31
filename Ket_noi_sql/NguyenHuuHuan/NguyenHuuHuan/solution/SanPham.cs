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
namespace NguyenHuuHuan.solution
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        public void getData()
        {
            List<models.clssLoc> lstSanPham = new List<models.clssLoc>();
            string conn_sr = "data source = (local); initial catalog = PMStore; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_sr);
            conn.Open();
            string Query = $"select * from SANPHAM where NHACUNGCAP = '{txtNhaCungCap.Text}'";
            SqlCommand cmd =new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.clssLoc sp = new models.clssLoc();
                sp.MaSanPham = (string)reader["MASANPHAM"];
                sp.TenSanPham = (string)reader["TENSANPHAM"];
                sp.SoLuonTonKho = (int)reader["SOLUONGTON"];
                sp.NgaySanXuat = (DateTime)reader["NGAYSANXUAT"];
                sp.NgayHetHan = (DateTime)reader["NGAYHETHAN"];
                sp.NhaCungCap = (string)reader["NHACUNGCAP"];
                lstSanPham.Add(sp);
            }
            conn.Close();
            dtgSanPham.DataSource = lstSanPham;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            getData();
        }
    }
}
