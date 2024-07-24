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
    public partial class frmTrangChu : Form
    {
        //private int childFormNumber ;

        public frmTrangChu()
        {
            InitializeComponent();
        }

        public bool isThoat = true;
        public frmTrangChu(int childFormNumber)
        {
            //this.childformnumber = childformnumber;
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
           
        }

     

      

        public event EventHandler DangXuat;// ủy thác
        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isThoat)
            //{
            //    if (MessageBox.Show("Bạn muốn thoát chương trình", "Cofrm", MessageBoxButtons.YesNo) != DialogResult.Yes)
            //        e.Cancel = true;
            //}    

                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }
       

      
            //frmNhaCungCap s = new frmNhaCungCap();
            //s.MdiParent = this;
            //s.Show();
         
        

        
            //frmHoaDonNhap s = new frmHoaDonNhap();
            //s.MdiParent = this;
            //s.Show();
        

     

        private void mnuHoaDonNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap frm = new frmHoaDonNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmLoaiSP frm = new frmLoaiSP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void mnuTimKiemSP_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham frm = new frmTimKiemSanPham();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
