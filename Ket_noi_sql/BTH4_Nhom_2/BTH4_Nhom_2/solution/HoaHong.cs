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
namespace BTH4_Nhom_2.solution
{
    public partial class HoaHong : Form
    {
        public HoaHong()
        {
            InitializeComponent();
        }
        void getData()
        {
            List<models.clssHoaHong> lstHoaHong = new List<models.clssHoaHong>();
            string conn_str = "Data source = (local); initial catalog = HoaHong; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = "Select * from BENGOAN, LopHoc WHERE BENGOAN.MALOP = LopHoc.MALOP";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                models.clssHoaHong obj = new models.clssHoaHong();
                obj.MaBeNgoan = (string)dr["MABN"];
                obj.MaLop = (string)dr["MALOP"];
                obj.TenBeNgoan = (string)dr["TENBENGOAN"];
                obj.NgaySinh = (DateTime)dr["NGAYSINH"];
                obj.GioiTinh = (string)dr["GIOITINH"];
                obj.HoTenBo = (string)dr["HOTENBO"];
                obj.HoTenMe = (string)dr["HOTENME"];
                obj.DiaChi = (string)dr["DIACHI"];
                obj.TenLop = (string)dr["TENLOP"];
                lstHoaHong.Add(obj);
            }
            conn.Close();
            conn.Open();
            string Query2 = "select MALOP from LopHoc";
            SqlCommand cmd2 = new SqlCommand(Query2, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            List<string> lstMaLop = new List<string>();
            while (dr2.Read())
            {
                lstMaLop.Add((string)dr2["MALOP"]);
            }
            conn.Close();
            dgvHoaHong.DataSource = lstHoaHong;
            cbMaLop.DataSource = lstMaLop;
        }

        private void HoaHong_Load(object sender, EventArgs e)
        {
            getData();
            getLop();   
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            string _maBeNgoan = txtMaBeNgoan.Text;
            string _maLop = cbMaLop.Text;
            string _namSinh = dtfNgaySinh.Value.ToString("yyyy/MM/dd");
            string _gioiTinh;
            if (rbNam.Checked == true)
                _gioiTinh = "Nam";
            else _gioiTinh = "Nữ";
            string _hoTenBo = txtTenBo.Text;
            string _hoTenMe = txtTenMe.Text;
            string _diaChi = txtDiaChi.Text;
            string _tenBeNgoan = txtTenBeNgoan.Text;
            string conn_str = "Data source = (local); initial catalog = HoaHong; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"insert into BENGOAN(MABN, MALOP, TENBENGOAN, NGAYSINH, GIOITINH, HOTENBO, HOTENME, DIACHI) VALUES('{_maBeNgoan}','{_maLop}',N'{_tenBeNgoan}','{_namSinh}',N'{_gioiTinh}',N'{_hoTenBo}',N'{_hoTenMe}',N'{_diaChi}')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int sl = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if(sl == 1)
            {
                MessageBox.Show("Thêm Thành Công");
                getData();
                Clear();
            }
            else MessageBox.Show("Thêm Thất Bại");
        }
        public void getLop()
        {
            if (cbMaLop.SelectedItem.ToString() == "1")
            {
                txtTenLop.Text = "LOP1";
            }
            else if (cbMaLop.SelectedItem.ToString() == "2")
            {
                txtTenLop.Text = "LOP2";
            }
            else txtTenLop.Text = "LOP3";
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLop();
        }

        private void butXoa_MouseClick(object sender, MouseEventArgs e)
        {
            string conn_str = "data source = (local); initial catalog = HoaHong; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"delete from BENGOAN WHERE MABN = '{txtMaBeNgoan.Text}'";
            SqlCommand cmd = new SqlCommand(Query,conn);
            int sl = cmd.ExecuteNonQuery(); 
            conn.Close();
            if(sl == 1)
            {
                MessageBox.Show("Xóa Thành Công!");
                getData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa Thát Bại!");
            }
           
        }

        private void dgvHoaHong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row >= 0)
            {
                btnThem.Enabled = false;
                txtMaBeNgoan.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaBeNgoan.Text = (string)dgvHoaHong.Rows[row].Cells["MaBeNgoan"].Value;
                cbMaLop.SelectedItem = (string)dgvHoaHong.Rows[row].Cells["Malop"].Value;
                DateTime _ngaySinh = (DateTime)dgvHoaHong.Rows[row].Cells["NgaySinh"].Value;
                dtfNgaySinh.Value = DateTime.Parse(_ngaySinh.ToString("dd / MM / yyyy"));
                if ((string)dgvHoaHong.Rows[row].Cells["GioiTinh"].Value == "nam")
                    rbNam.Checked = true;
                else rbNu.Checked = true;
                txtTenBo.Text = (string)dgvHoaHong.Rows[row].Cells["HoTenBo"].Value;
                txtTenMe.Text = (string)dgvHoaHong.Rows[row].Cells["HoTenMe"].Value;
                txtTenBeNgoan.Text = (string)dgvHoaHong.Rows[row].Cells["TenBeNgoan"].Value;
                txtDiaChi.Text = (string)dgvHoaHong.Rows[row].Cells["DiaChi"].Value;
            }
        }
        public void Clear()
        {
            txtDiaChi.Text = "";
            txtMaBeNgoan.Text = "";
            txtTenMe.Text = "";
            txtTenBo.Text = "";
            txtDiaChi.Text = "";
            rbNam.Checked = rbNu.Checked = false;
            txtTenBeNgoan.Text = "";
            dtfNgaySinh.Value = DateTime.Parse("1/1/2000");
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            string _maLop = cbMaLop.Text;
            string _namSinh = dtfNgaySinh.Value.ToString("yyyy/MM/dd");
            string _gioiTinh;
            if (rbNam.Checked == true)
                _gioiTinh = "Nam";
            else _gioiTinh = "Nữ";
            string _hoTenBo = txtTenBo.Text;
            string _hoTenMe = txtTenMe.Text;
            string _diaChi = txtDiaChi.Text;
            string _tenBeNgoan = txtTenBeNgoan.Text;
            string conn_str = "data source = (local); initial catalog = HoaHong; user id = sa; password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            conn.Open();
            string Query = $"UPDATE BENGOAN SET MALOP = '{_maLop}'" +
                $", NGAYSINH = N'{_namSinh}'" +
                $", GIOITINH = N'{_gioiTinh}'" +
                $", HOTENBO = N'{_hoTenBo}'" +
                $", HOTENME = N'{_hoTenMe}' " +
                $", DIACHI = N'{_diaChi}'" +
                $", TENBENGOAN = N'{_tenBeNgoan}'" +
                $"  WHERE MABN = '{txtMaBeNgoan.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int sl = cmd.ExecuteNonQuery();
            conn.Close();
            if(sl == 1)
            {
                MessageBox.Show("Cập nhật Thành Công!");
                getData();
                Clear();
            }
            else
            {
                MessageBox.Show("Cập Nhật Thát Bại!");
            }
        }

        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            frmTimKiem frm = new frmTimKiem ();
            frm.Show();
        }

        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.Red;
        }
    }
}
