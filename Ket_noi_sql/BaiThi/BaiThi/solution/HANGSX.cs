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
namespace BaiThi.solution
{
    public partial class HANGSX : Form
    {
        public HANGSX()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string _maHSX = txtHSX.Text;
            string _tenHSX = txtTenHSX.Text;
            string _diaChi = txtDiaChi.Text;
            string conn_str = "data source = (local); initial catalog = SANBAY; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"UPDATE HANGSANXUAT SET " +
                $" TENHSX = N'{_tenHSX}'" +
                $", DIACHI = N'{_diaChi}'" +
                $"  WHERE MAHSX = '{_maHSX}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int sl = cmd.ExecuteNonQuery();
            conn.Close();
            if (sl == 1)
            {
                MessageBox.Show("Cập nhật Thành Công!");
                getData();
            }
            else
            {
                MessageBox.Show("Cập Nhật Thát Bại!");
            }
        }
        public void getData()
        {
            List<NewFolder.HangSX> lstHSX = new List<NewFolder.HangSX>();
            string conn_str = "Data source = (local); initial catalog = SANBAY; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = "Select * from  HANGSANXUAT";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NewFolder.HangSX obj = new NewFolder.HangSX();
                obj.MAHSX = (string)dr["MAHSX"];
                obj.TENHSX = (string)dr["TENHSX"];
                obj.DIACHI1 = (string)dr["DIACHI"];
                lstHSX.Add(obj);
            }
            conn.Close();
            dgvHSX.DataSource = lstHSX;
        }

        private void HANGSX_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgvHSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtHSX.Text = (string)dgvHSX.Rows[row].Cells["MAHSX"].Value;
                txtTenHSX.Text = (string)dgvHSX.Rows[row].Cells["TENHSX"].Value;
                txtDiaChi.Text = (string)dgvHSX.Rows[row].Cells["DIACHI1"].Value;
            }
        }
    }
}
