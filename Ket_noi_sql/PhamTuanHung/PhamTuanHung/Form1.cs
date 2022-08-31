using System.Data.SqlClient;
namespace PhamTuanHung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void getData()
        {
            List<clssSimThe> lstHSX = new List<clssSimThe>();
            string conn_str = "Data source = (local); initial catalog = SIMTHE_; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = "Select * from  SIM";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clssSimThe obj = new clssSimThe();
                obj.ID1 = (string)dr["ID"];
                obj.SoSim1 = (string)dr["SoSim"]
                obj.MangID1 = (string)dr["MangID"];
                obj.NgayKichHoat1 = (string)dr["NgayKichHoat"];
                obj.NgayHetHan1 = (string)dr["NgayHetHan"];
                lstHSX.Add(obj);
            }
            conn.Close();
            dgvSim.DataSource = lstHSX;
        }
    }
}