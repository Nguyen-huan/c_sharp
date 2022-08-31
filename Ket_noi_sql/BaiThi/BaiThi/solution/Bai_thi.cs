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
    public partial class Bai_thi : Form
    {
        public Bai_thi()
        {
            InitializeComponent();
        }

        private void Bai_thi_Load(object sender, EventArgs e)
        {
            DieuKien();
            getData();
        }
        public void DieuKien()
        {
            txtMamb.Focus();
            txtMaHSX.Focus();
        }
       

        private void txtMamb_TextChanged(object sender, EventArgs e)
        {
            if (txtMamb.Text.Length > 0)
            {
                btnTimKiem.Enabled = true;
            }
            else
            {
                btnTimKiem.Enabled = false;
            }
        }
        private void txtMamb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                MessageBox.Show("Chỉ được nhập số");
                e.Handled = true;
            }
        }

        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            List<NewFolder.mayBay> lstmaybay = new List<NewFolder.mayBay>();
            string conn_str = "Data source = (local); initial catalog = SANBAY; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"Select * from MAYBAY, HANGSANXUAT WHERE HANGSANXUAT.MAHSX = MAYBAY.MAHSX and  MAYBAY.MAMAYBAY = '{txtMamb.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NewFolder.mayBay obj = new NewFolder.mayBay();
                obj.MAHSX = (string)dr["MAHSX"];
                obj.MAMAYBAY = (string)dr["MAMAYBAY"];
                obj.TENHSX = (string)dr["TENHSX"];
                obj.TENMB = (string)dr["TENMB"];
                obj.DIACHI1 = (string)dr["DIACHI"];
                lstmaybay.Add(obj);
            }
            conn.Close();
            if(lstmaybay.Count > 0)
            {
                MessageBox.Show("Tìm Kiếm Thành Công!");
                dgvMayBay.DataSource = lstmaybay;
            }
            else
            {
                MessageBox.Show($"Không Có Mã Máy Bay Nào là {txtMamb.Text}");
            }
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            HANGSX frm = new HANGSX();
            frm.Show();
        }
    }
}
