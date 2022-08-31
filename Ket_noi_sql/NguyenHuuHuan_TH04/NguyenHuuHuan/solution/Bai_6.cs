using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuHuan.solution
{
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
        }

        private void Bai_6_Load(object sender, EventArgs e)
        {
            getData();
        }
        public string ChuoiKetNoi()
        {
            string svName = "(local)";
            string dataName = "DienTraDS";
            string userID = "sa";
            string passWord = "123456";
            string conn = $"Data Source = {svName}; Initial Catalog = {dataName}; User ID = {userID}; password = {passWord}";
            return conn;
        }
        public void getData()
        {
            try
            {
                List<models.BeNgoan> DATA = new List<models.BeNgoan>();
                SqlConnection conn = new SqlConnection(ChuoiKetNoi());
                conn.Open();
                string Query = "SELECT * FROM BENGOAN";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    models.BeNgoan obj = new models.BeNgoan();
                    obj.MaLop = (string)reader["MALOP"];
                    obj.MaBeNgoan = (string)reader["MABN"];
                    obj.TenBeNgoan = (string)reader["TENBENGOAN"];
                    obj.HoTenBo = (string)reader["HOTENBO"];
                    obj.HoTenMe = (string)reader["HOTENME"];
                    obj.DiaChi = (string)reader["DIACHI"];
                    obj.NgaySinh = (DateTime)reader["NGAYSINH"];
                    obj.GioiTinh = (string)reader["GIOITINH"];
                    DATA.Add(obj);
                }
                conn.Close();
                dgvBeNgoan.DataSource = DATA;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //INSERT INTO BENGOAN(MABN, MALOP, TENBENGOAN, NGAYSINH, GIOITINH, HOTENBO, HOTENME, DIACHI)
                // VALUES('5', '003', '1', '2002-03-12', 'true', '{HOTENBO}', '{HOTENME}', '{DIACHI}')
                string MABN = txtMaBN.Text;
                string MALOP = txtMaLop.Text;
                string TENBENGOAN = txtTenBN.Text;
                string NGAYSINH = dtpNgaySinh.Value.ToString("yyyy/MM/dd");
                string GIOITINH = "False";
                if (rbNam.Checked == true)
                    GIOITINH = "True";
                string HOTENBO = txtHTBo.Text;
                string HOTENME = txtHTMe.Text;
                string DIACHI = txtDiaChi.Text;

                SqlConnection conn = new SqlConnection(ChuoiKetNoi());
                conn.Open();
                //string Query = "SELECT * FROM BENGOAN";

                string Query = $"INSERT INTO BENGOAN (MABN, MALOP, TENBENGOAN , NGAYSINH, GIOITINH, HOTENBO, HOTENME, DIACHI)VALUES('{MABN}','{MALOP}','{TENBENGOAN}','{NGAYSINH}', '{GIOITINH}', '{HOTENBO}', '{HOTENME}', '{DIACHI}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int sl = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtDiaChi.Text = ex.Message;
            }

        }
    }
}
    
