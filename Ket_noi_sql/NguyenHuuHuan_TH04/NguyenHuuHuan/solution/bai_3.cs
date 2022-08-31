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
    public partial class bai_3 : Form
    {
        public bai_3()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            btnSua.Enabled = true;
            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            txtMacd.Text = "";
            txtCMND.Text = "";
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
            conn.Close();
            dgvCongDan.DataSource = data;
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ket_Noi());
            conn.Open();
            int CMND = int.Parse(txtCMND.Text);
            string maCD = txtMacd.Text;
            string Query1 = $"UPDATE CongDan SET CMND = {CMND} WHERE MACD = '{maCD}'";
            SqlCommand cmd2 = new SqlCommand(Query1, conn);
            SqlDataReader reader = cmd2.ExecuteReader();
            conn.Close();
            getData();
            ClearText();
        }

        private void bai_3_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
