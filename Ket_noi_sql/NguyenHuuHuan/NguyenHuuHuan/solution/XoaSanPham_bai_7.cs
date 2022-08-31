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
    public partial class XoaSanPham_bai_7 : Form
    {
        public XoaSanPham_bai_7()
        {
            InitializeComponent();
        }
        public string ChuoiKetNoi()
        {
            string svName = "(local)";
            string dataName = "PMStore";
            string userID = "sa";
            string passWord = "123456";
            string conn = $"Data Source = {svName}; Initial Catalog = {dataName}; User ID = {userID}; password = {passWord}";
            return conn;
        }
        public void getData()
        {
            List<models.clssLoc> data = new List<models.clssLoc>();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"select * from SANPHAM ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.clssLoc obj = new models.clssLoc();
                obj.MaSanPham = (string)reader["MASANPHAM"];
                obj.TenSanPham = (string)reader["TENSANPHAM"];
                obj.SoLuonTonKho = (int)reader["SOLUONGTON"];
                obj.NgaySanXuat = (DateTime)reader["NGAYSANXUAT"];
                obj.NgayHetHan = (DateTime)reader["NGAYHETHAN"];
                obj.NhaCungCap = (string)reader["NHACUNGCAP"];
                data.Add(obj);
            }
            //b4: Đóng kết nối
            conn.Close();
            dgvSanPham.DataSource = data;
        }
        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            List<models.clssLoc> data = new List<models.clssLoc>();
            string dayNow = DateTime.Now.ToString("yyyy/MM/dd");
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"delete from SANPHAM WHERE SOLUONGTON = 0 OR NGAYHETHAN < '{dayNow}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            getData();
        }

        private void XoaSanPham_bai_7_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
