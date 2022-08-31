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
namespace QUANGHUNG
{
    public partial class HangSX : Form
    {
        public HangSX()
        {
            InitializeComponent();
        }
        void getData()
        {
            List<clssHangSX> lstHangSX = new List<clssHangSX>();
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = "Select * from HANGSANXUAT";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clssHangSX hsx = new clssHangSX();
                hsx.MAHANGSX = (string)reader["MAHANGSX"];
                hsx.TENHANGSX = (string)reader["TENHANGSX"];
                hsx.DIACHI = (string)reader["DIACHI"];
                lstHangSX.Add(hsx);
            }
            conn.Close();
            dgvHangSX.DataSource = lstHangSX;
        }

        private void HangSX_Load(object sender, EventArgs e)
        {
            getData();
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("hong dc bo trong!");
            }
        }

        private void dgvHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaHang.Text = (string)dgvHangSX.Rows[row].Cells["MAHANGSX"].Value;
                txtTenHang.Text = (string)dgvHangSX.Rows[row].Cells["TENHANGSX"].Value;
                txtDiaChi.Text = (string)dgvHangSX.Rows[row].Cells["DIACHI"].Value;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = $"update  HANGSANXUAT set  TENHANGSX = '{txtTenHang.Text}', DIACHI = '{txtDiaChi.Text}' WHERE MAHANGSX = '{txtMaHang.Text}'";

            SqlCommand cmd = new SqlCommand(Query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a == 1)
            {
                MessageBox.Show("thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("loi");
            }
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = $"INSERT INTO HANGSANXUAT(MAHANGSX,TENHANGSX,DIACHI) VALUES('{txtMaHang.Text}','{txtTenHang.Text}',N'{txtDiaChi.Text}') ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("them thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("them that bai");
            }

            conn.Close();
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = $"delete from HANGSANXUAT where MAHANGSX = '{txtMaHang.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                MessageBox.Show("XOA thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("XOA that bai");
            }
            conn.Close();
        }

       

        private void txtMaHang_MouseLeave(object sender, EventArgs e)
        {
            if(txtMaHang.Text == "")
            {
                MessageBox.Show("hong dc bo trong!");
            }
        }

        
    }
}
