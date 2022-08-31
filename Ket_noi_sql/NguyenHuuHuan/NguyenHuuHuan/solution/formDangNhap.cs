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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
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

        private void btnDangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text; // Mã hóa mật khẩu với các hệ thống an toàn
            string Query = $"select count(*) from NguoiDung where TaiKhoan = '{TaiKhoan}' and MatKhau = '{MatKhau}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int SoLuong = (int)cmd.ExecuteScalar();
            conn.Close();
            if (SoLuong == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

    }
}
