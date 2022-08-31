using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                if (txtDangNhap.Text == "huan")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", "ERROR",
                                    MessageBoxButtons.OKCancel);
                }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát?",
                            "Exit", 
                            MessageBoxButtons.OKCancel);
        }

        private void btnDangNhap_MouseHover(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.LightBlue;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.White;
        }
        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.LightBlue;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.White;
        }
    }
}
