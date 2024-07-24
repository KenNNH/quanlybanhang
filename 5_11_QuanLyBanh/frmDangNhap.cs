using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_11_QuanLyBanh
{
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Intance.ListTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KiemtraDangNhap(txtTaiKhoan.Text , txtMatKhau.Text))
            {
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                frmTrangChu f = new frmTrangChu();
                f.Show();
                this.Hide();// ẩn
                f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu","Cofrm", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            
        }

        bool KiemtraDangNhap(string tentaikhoan, string matkhau)
        {
            for(int i = 0; i < listTaiKhoan.Count;i++)
            {
                if(tentaikhoan == listTaiKhoan[i].Tentaikhoan && matkhau == listTaiKhoan[i].Matkhau)
                    return true;
            }    
            return false;
        }
        private void F_DangXuat(object sender, EventArgs e)
        {
           (sender as frmTrangChu).isThoat= false;
           (sender as frmTrangChu).Close();
            this.Show();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtMatKhau.PasswordChar=(char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn  có muốn thoát chương trình"
                    , "Cofrm"
                    , MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
           
           
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
