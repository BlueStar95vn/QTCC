using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            lblCanhBao.Text = "";
        
        }

        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
         if((txtTenDangNhap.Text == "Admin"||txtTenDangNhap.Text=="admin") && txtMatKhau.Text=="123456")
            {
                this.Hide();
                QuanLy quanLy = new QuanLy();
                quanLy.ShowDialog();               
                this.Close();
            }
            else if ((txtTenDangNhap.Text == "nhanvien"||txtTenDangNhap.Text=="NhanVien") && txtMatKhau.Text == "123456")
            {
                this.Hide();
                BanHang banHang = new BanHang();
                banHang.ShowDialog();
                this.Close();
            }
            else
            {
                txtMatKhau.Text = "";
                txtTenDangNhap.Text = "";
                lblCanhBao.Text = "Tên đăng nhập hoặc mật khẩu sai";
            }

        }

      

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

