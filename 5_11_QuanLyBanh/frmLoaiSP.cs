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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }
        int vitri = 0;
        quanlybanBanh q = new quanlybanBanh();
        DataSet ds = new DataSet();
        void danhSach_datagridview(DataGridView d , string sql)
        {
            ds = q.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
       
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        Boolean f = false;
        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhSach_datagridview(dgvDanhSach, "select * from LoaiSP where trangthai = 0");
            hienthiLenTextBox(ds, vitri);
            f = true;
        }

        void xuly_textbox(Boolean t)
        {
            txtMaLoai.ReadOnly = t;
            txtTenLoai.ReadOnly = t;

        }

        int flag = 0;// c
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuly_textbox(false);
            xulycombox(false);
            cboTrangThai.SelectedIndex= 0;
            txtMaLoai.Text = phatsinhMa_2();
            //cboTrangThai.SelectedIndex= 0;
            flag= 1;
        }

        void xulycombox(bool t)
        {
            cboTrangThai.Enabled = !t;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuly_textbox(false);
            xulycombox(true);
            txtMaLoai.Enabled = false;
            cboTrangThai.SelectedIndex= 0;
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuly_textbox(true);
            string sql = " ";
            if (flag == 1)
            {
                sql = "insert into LoaiSP values('" + txtMaLoai.Text + "',N'" + txtTenLoai.Text + "',0)";
            }
            if (flag == 2)
            {
                sql = " update LoaiSP set TenLoai = N'" + txtTenLoai.Text + " ',trangthai =" + cboTrangThai.SelectedIndex + " where MaLoai = '" + txtMaLoai.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update LoaiSP set trangthai=1 where MaLoai='" + txtMaLoai.Text + "'";
            }
            if (q.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                vitri = 0;
                frmLoaiSP_Load(sender, e);
            }
        }

        private void frmLoaiSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc chắn muốn thoát",
               "Cofrm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        void hienthiLenTextBox(DataSet ds , int vt)
        {
            if (ds.Tables[0].Rows.Count > vt && vt >-1)
            {
                txtMaLoai.Text = ds.Tables[0].Rows[vt]["MaLoai"].ToString();
                txtTenLoai.Text = ds.Tables[0].Rows[vt]["TenLoai"].ToString();

                string trangthai = cboTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = " Ngưng hoạt động";
                }

            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienthiLenTextBox(ds, vitri);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 3;

        }
        string phatsinhMa_2()
        {
            string MaLoai = " ";
            DataSet dsLoai = q.layDuLieu("select MaLoai from LoaiSP");
            MaLoai = "ML0" + (ds.Tables[0].Rows.Count+1).ToString();
            return MaLoai;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(f)
                if(e.ColumnIndex >= -1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string maloai = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tenloai= dgvDanhSach.CurrentRow.Cells[1].Value.ToString();

                    string sql = "update LoaiSP set TenLoai=N'" + tenloai + "' where MaLoai='"+maloai+"'";
                    if(q.capNhatDuLieu(sql)>0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        vitri = 0;
                        frmLoaiSP_Load(sender, e);
                    }    
                }    

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmLoaiSP_Load(sender, e);
        }
    }
}
