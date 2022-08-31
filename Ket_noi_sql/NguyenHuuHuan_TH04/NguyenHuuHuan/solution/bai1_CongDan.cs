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
namespace NguyenHuuHuan
{
    public partial class bai_1 : Form
    {
        public bai_1()
        {
            InitializeComponent();
        }

        public void getData()
        {
            List<models.Cong_Dan> data = new List<models.Cong_Dan>();
            
            SqlConnection conn = new SqlConnection(Ket_Noi());
            conn.Open();
            string Query = "select * from CongDan";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                models.Cong_Dan obj = new models.Cong_Dan();
                obj.MaCD = (string)reader["MACD"];
                obj.MaPhuong = (string)reader["MAPHUONG"];
                obj.TenCD = (string)reader["TENCD"];
                obj.Cmnd = (int)reader["CMND"];
                obj.GioiTinh = (string)reader["GIOITINH"];
                obj.NamSinh = (DateTime)reader["NAMSINH"];
                obj.SoDienThoai = (int)reader["SODIENTHOAI"];
                data.Add(obj);
            }
            //b4: Đóng kết nối
            conn.Close();
            dgvCongNhan.DataSource = data;
        }

        private void bai_1_Load(object sender, EventArgs e)
        {
            getData();
        }

        public string Ket_Noi()
        {
            string svName = "(local)";
            string dbName = "DienTraDS";
            string userID = "sa";
            string passWord = "123456";
            string con_str = $"Data Source={svName}; Initial Catalog={dbName}; User ID={userID}; Password={passWord}";
            return con_str;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Ket_Noi());
                conn.Open();
                string maCD = txtMacd.Text;
                string maPhuong = txtMaPhuong.Text;
                string tenCD = txtTenCD.Text;
                int cmnd = int.Parse(txtCMND.Text);
                string gioiTinh = txtMaPhuong.Text;
                string namSinh = txtNamSinh.Value.ToString("yyyy/MM/dd");
                int soDienThoai = int.Parse(txtSodt.Text);
                string Query = $"Insert into CongDan (MACD, MAPHUONG, TENCD, CMND, GIOITINH, NAMSINH, SODIENTHOAI)VALUES('{maCD}', '{maPhuong}', N'{tenCD}',{cmnd},N'{gioiTinh}','{namSinh}',{soDienThoai})";
                // Bước ?.2: Tạo đối tượng thực thi truy vấn
                SqlCommand cmd = new SqlCommand(Query, conn);
                // Bước ?.3: Thực thi truy vấn => Truy vấn thực thi là Insert => chọn phương thức thực thi ExecuteNonQuery()
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    //getData();
                    getData();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }
        public void ClearText()
        {
            btnThem.Enabled = true;
            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            txtMacd.Text = "";
            txtMaPhuong.Text = "";
            txtTenCD.Text = "";
            txtCMND.Text = "";
            txtMaPhuong.Text = "";
            txtMaPhuong.Text = "";
            txtSodt.Text = "";

        }
    }
}
