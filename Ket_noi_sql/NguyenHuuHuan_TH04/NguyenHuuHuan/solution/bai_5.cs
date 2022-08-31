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
    public partial class bai_5 : Form
    {
        public bai_5()
        {
            InitializeComponent();
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
                List<models.LopHoc> DATA = new List<models.LopHoc>();
                SqlConnection conn = new SqlConnection(ChuoiKetNoi());
                conn.Open();
                string Query = "SELECT * FROM LOPHOC";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    models.LopHoc obj = new models.LopHoc();
                    obj.MaLop = (string)reader["MALOP"];
                    obj.TenLop = (string)reader["TENLOP"];
                    DATA.Add(obj);
                }
                //b4: Đóng kết nối
                dgvLopHoc.DataSource = DATA;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bai_5_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = $"DELETE FROM LOPHOC WHERE MALOP = '{txtMaLop.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int sl = cmd.ExecuteNonQuery();
            conn.Close();
            if (sl == 1)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else MessageBox.Show("Xóa Không Thành Công");
            getData();
        }
    }
   
}
