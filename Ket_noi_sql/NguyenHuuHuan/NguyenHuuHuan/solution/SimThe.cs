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
    public partial class SimThe : Form
    {
        public SimThe()
        {
            InitializeComponent();
        }
        public string ChuoiKetNoi()
        {
            string svName = "(local)";
            string dataName = "SimThe";
            string userID = "sa";
            string passWord = "123456";
            string conn = $"Data Source = {svName}; Initial Catalog = {dataName}; User ID = {userID}; password = {passWord}";
            return conn;
        }
        string ngayHetHan;
        int soSim;
        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Nhập ID muốn tìm kiếm");
            }
            List<models.clssSimThe> data = new List<models.clssSimThe>();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"select * from Sim where ID = '{txtNhap.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.clssSimThe obj = new models.clssSimThe();
                obj.ID = (int)reader["ID"];
                obj.MangID = (int)reader["MANGID"];
                obj.NgayKihHoat = (DateTime)reader["NGAYKICHHOAT"];
                obj.NgayHetHan = (DateTime)reader["NGAYHETHAN"];
                ngayHetHan = obj.NgayHetHan.ToString("yyyy/MM/dd");
                soSim = obj.ID;
                data.Add(obj);
            }
            conn.Close();
            if (data.Count > 0)
            {
                MessageBox.Show($"Số sim cần tìm có mã là: {soSim} ngày hết hạn là: {ngayHetHan}");
                dgvSimThe.DataSource = data;
                txtNhap.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả");
                txtNhap.Text = "";
            }
        }
    }
}
