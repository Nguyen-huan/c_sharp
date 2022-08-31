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
    public partial class MayBay : Form
    {
        public MayBay()
        {
            InitializeComponent();
        }

        private void mAYbAY_Load(object sender, EventArgs e)
        {
            txtMaMayBay.Focus();
            txtMaHSX.Focus();
            getData();
        }
        void getData()
        {
            List<clssMayBay> lstMayBay = new List<clssMayBay>();
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = "Select * from MAYBAY where MAHANGSX_FK = '01'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clssMayBay maybay = new clssMayBay();
                maybay.MAMAYBAY = (string)reader["MAMAYBAY"];
                maybay.MAHANGSX = (string)reader["MAHANGSX_FK"];
                maybay.TENMAYBAY = (string)reader["TENMAYBAY"];
                lstMayBay.Add(maybay);
            }
            conn.Close();
            dgvMayBay.DataSource = lstMayBay;  
        }

        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            List<clssMayBay> lstMayBay = new List<clssMayBay>();
            string conn_str = "data source = (local); initial catalog = sanbay_1; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            String Query = $"Select * from MAYBAY where MAMAYBAY = '{txtMaMayBay.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            clssMayBay maybay = new clssMayBay();
            maybay.MAMAYBAY = (string)reader["MAMAYBAY"];
            maybay.MAHANGSX = (string)reader["MAHANGSX_FK"];
            maybay.TENMAYBAY = (string)reader["TENMAYBAY"];
            lstMayBay.Add(maybay);
            conn.Close();
            dgvMayBay.DataSource = lstMayBay;
        }
    }
}
