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
    public partial class CongDan : Form
    {
        public CongDan()
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
        public void getData()
        {
            List<models.clssCongDan> data = new List<models.clssCongDan>();

            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = "select * from CongDan";
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
            dgvCongDan.DataSource = data;
        }

        private void CongDan_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSapXep_MouseClick(object sender, MouseEventArgs e)
        {
            List<models.clssCongDan> data = new List<models.clssCongDan>();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi());
            conn.Open();
            string Query = "select * from CongDan";
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
            //b4: Đóng kết nối
            conn.Close();
            for (int i = 0; i < data.Count; i++)
            {
                for(int j = i+1; j < data.Count; j++)
                if (data[i].TenCD.CompareTo(data[j].TenCD) > 0)
                {
                    models.clssCongDan temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
            dgvCongDan.DataSource = data;
        }
    }
}
