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
namespace TestKetNoi.solution
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        //private void txtTaikhoan_Leave(object sender, EventArgs e)
        //{
        //    if(txtTaikhoan.Text.Length <= 5)
        //    {
        //        MessageBox.Show("Phải nhập ít nhát 5 ký tự");
        //        txtTaikhoan.Focus();
        //    }
        //}

        private void bai1_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Focus();
            txtMatKhau.Enabled = false;
            btnDangNhap.Enabled = false;
            checkAdmin.Enabled = false;
        }

        private void txtTaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8)))
            //{
            //    MessageBox.Show("Nhap lai");
            //}
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Tài khoản không được chứa ký tự đặc biệt hoặc dấu cách!");
                e.Handled = true;
            }
            //if (e.KeyChar >= 'a' && e.KeyChar <= 'z') e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {
            if(txtTaikhoan.Text.Length >= 6)
                txtMatKhau.Enabled = true;
            else txtMatKhau.Enabled=false;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length >= 6)
            {
                btnDangNhap.Enabled = true;
                checkAdmin.Enabled = true;
            }
            else
            {
                btnDangNhap.Enabled = false;
                checkAdmin.Enabled = false;
            }
        }
        private void getData()
        {
            List<models.nguoiDung> lstUser = new List<models.nguoiDung>();
            string conn_str = "Data Source = (local); Initial Catalog = QLND_111; User id = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = "Select * from NGUOIDUNG";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                models.nguoiDung user = new models.nguoiDung();
                user.TaiKhoan = (string)rd["TAIKHOAN"];
                user.MatKhau = (string)rd["MATKHAU"];
                user.QuyenAdmin = (string)rd["QUYEN_ADMIN"];
                lstUser.Add(user);
            }
            conn.Close();
            dtgNguoiDung.DataSource = lstUser;  

        }
        private void btnDangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            string quyen_admin = "";
            if(checkAdmin.Checked == true)
            {
                quyen_admin = "X";
            }
            string conn_str = "Data Source = (LOCAL); Initial Catalog = QLND_111; User id = sa; Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"Select COUNT(*) from NGUOIDUNG where TAIKHOAN = '{txtTaikhoan.Text}' AND MATKHAU = '{txtMatKhau.Text}' AND QUYEN_ADMIN LIKE '%{quyen_admin}%'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            if (kq == 1 && checkAdmin.Checked == true)
            {
                MessageBox.Show("Đăng Nhập Với Quyền Amin Thành Công");
                getData();
            }
            else if(kq == 1 &&  checkAdmin.Checked == false)
            {
                MessageBox.Show("Đăng Nhập Thành Công"); this.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại"); 
            }
        }
    }
}
