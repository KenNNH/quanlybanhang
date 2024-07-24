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
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }


        quanlybanBanh q = new quanlybanBanh();
        DataSet dsloaiSP = new DataSet();      
        DataSet dsSanPham = new DataSet();
        DataSet dsNhaCC = new DataSet();
        Boolean f = false;

        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

      

        
        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            dsSanPham = q.layDuLieu("select * from SanPham");
            dgvDanhSach.DataSource = dsSanPham.Tables[0];

            cboCacLoaiTimKiem.Visible= false;      

            f = true;
        }

        private void cboTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(f)
                if (cboTimTheo.SelectedIndex == 0)
                {
                    dsSanPham = q.layDuLieu("select * from SanPham");
                    hienThiComboBox(cboCacLoaiTimKiem, dsSanPham, "TenSP", "MaSP");
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    dsloaiSP = q.layDuLieu("select * from LoaiSP");
                    hienThiComboBox(cboCacLoaiTimKiem, dsloaiSP, "TenLoai", "MaLoai");
                }
                if (cboTimTheo.SelectedIndex == 2)
                {
                    dsNhaCC = q.layDuLieu("select * from NhaCungCap");
                    hienThiComboBox(cboCacLoaiTimKiem, dsNhaCC , "TenNCC", "MaNCC");
                }
            cboCacLoaiTimKiem.Visible = true;

        }

        private void cboCacLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maloai = "";
            string sql = "";
            if (f)
            {
                if (cboTimTheo.SelectedIndex == 0)
                {
                    if (cboCacLoaiTimKiem.SelectedIndex != -1)
                    {
                        maloai = cboCacLoaiTimKiem.SelectedValue.ToString();
                        sql = "select * from SanPham where MaSP = '" + maloai + "'";
                        dsSanPham = q.layDuLieu(sql);

                    }
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    if (cboCacLoaiTimKiem.SelectedIndex != -1)
                    {
                        maloai = cboCacLoaiTimKiem.SelectedValue.ToString();
                        sql = "select * from SanPham where MaLoai = '" + maloai + "'";
                        dsSanPham = q.layDuLieu(sql);
                       
                    }
                }
                if (cboTimTheo.SelectedIndex == 2)
                {
                    if (cboCacLoaiTimKiem.SelectedIndex != -1)
                    {
                        maloai = cboCacLoaiTimKiem.SelectedValue.ToString();
                        sql = "select * from SanPham where MaNCC = '" + maloai + "'";
                        dsSanPham = q.layDuLieu(sql);
                       
                    }
                }
                dgvDanhSach.DataSource = dsSanPham.Tables[0];
            }                  
            
        }

       
        
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  vitri = e.RowIndex;
          //  hienthiLenTextBox(dsSanPham, vitri);
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham_Load(sender, e);
            cboTimTheo.SelectedIndex = -1;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (thoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
