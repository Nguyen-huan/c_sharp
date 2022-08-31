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
    public partial class Loc : Form
    {
        public Loc()
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
            string dayNow = DateTime.Now.ToString("yyyy/MM/dd");
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"select * from SANPHAM WHERE SOLUONGTON = 0 OR NGAYHETHAN < '{dayNow}'";
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
            dgvLoc.DataSource = data;
        }

        private void Loc_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
