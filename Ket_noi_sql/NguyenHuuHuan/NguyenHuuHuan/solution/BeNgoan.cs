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
    public partial class BeNgoan : Form
    {
        public BeNgoan()
        {
            InitializeComponent();
        }
        public string ChuoiKetNoi()
        {
            string svName = "(local)";
            string dataName = "HoaHong";
            string userID = "sa";
            string passWord = "123456";
            string conn = $"Data Source = {svName}; Initial Catalog = {dataName}; User ID = {userID}; password = {passWord}";
            return conn;
        }

        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtNhap.Text == "")
            {
                MessageBox.Show("Nhập Mã lớp để tìm kiếm");
            }
            List<models.clssBeNgoan> data = new List<models.clssBeNgoan>();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"select * from BENGOAN where MALOP = '{txtNhap.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.clssBeNgoan obj = new models.clssBeNgoan();
                obj.MaBeNgoan = (string)reader["MABN"];
                obj.MaLop = (string)reader["MALOP"];
                obj.TenBeNgoan = (string)reader["TENBENGOAN"];
                obj.GioiTinh = (string)reader["GIOITINH"];
                obj.NgaySinh = (DateTime)reader["NGAYSINH"];
                obj.HoTenBo = (string)reader["HOTENBO"];
                obj.HoTenMe = (string)reader["HOTENME"];
                obj.DiaChi = (string)reader["DIACHI"];

                data.Add(obj);
            }
            conn.Close();
            if (data.Count > 0)
            {
                MessageBox.Show("Tìm Kiếm Thành Công");
                dgvBeNgoan.DataSource = data;
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
