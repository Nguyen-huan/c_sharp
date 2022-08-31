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
namespace DaoVanQuang
{
    public partial class BaiThi : Form
    {
        public BaiThi()
        {
            InitializeComponent();
            txtGiaBan.Focus();
        }
        public void getData()
        {
            List<clssOto> lstmOto = new List<clssOto>();
            string conn_str = "Data source = (local); initial catalog = carshowroom; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = "Select * from MAYBAY, HANGSANXUAT WHERE HANGSANXUAT.MAHSX = MAYBAY.MAHSX and  MAYBAY.MAHSX = '01'";
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
            dgvMayBay.DataSource = lstmaybay;
        }
    }
}
