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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        public string ChuoiKetNoi()
        {
            string svName = "(local)";
            string dataName = "DieuTraDS";
            string userID = "sa";
            string passWord = "123456";
            string conn = $"Data Source = {svName}; Initial Catalog = {dataName}; User ID = {userID}; password = {passWord}";
            return conn;
        }
        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Nhập CMND để tìm kiếm");
            }
            List<models.clssCongDan> data = new List<models.clssCongDan>();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"select * from CongDan where CMND = '{txtNhap.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.clssCongDan obj = new models.clssCongDan();
                obj.MaCD = (string)reader["MACD"];
                obj.TenCD = (string)reader["TENCD"];
                obj.Cmnd = (int)reader["CMND"];
                obj.GioiTinh = (string)reader["GIOITINH"];
                obj.NamSinh = (DateTime)reader["NAMSINH"];
                obj.SoDienThoai = (string)reader["SODIENTHOAI"];
                data.Add(obj);
            }
            conn.Close();
            if(data.Count > 0)
            {
                MessageBox.Show("Tìm Kiếm Thành Công");
                dgvCongDan.DataSource = data;
                txtNhap.Text = "";
            }
            else
            {
                MessageBox.Show($"Không Có Công Dân Nào Có CMND là {txtNhap.Text}");
                txtNhap.Text = "";
            }

        }
    }
}
