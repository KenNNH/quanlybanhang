using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_11_QuanLyBanh
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        int vitri = 0;
        quanlybanBanh q = new quanlybanBanh();
        DataSet ds = new DataSet();
        DataSet dsLoaiSP = new DataSet();

        void danhsach_datagridview(DataGridView d, string sql)
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
        void xuly_textbox(Boolean t)
        {
            txtMaNcc.ReadOnly = t;
            txtTenNcc.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            txtPhone.ReadOnly = t;
            txtEmail.ReadOnly = t;
        }

        int flag = 0;
        void xoa_them(Boolean t)
        {
            txtMaNcc.Text = "";
            txtTenNcc.Text = "";
            txtDiaChi.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cboMaLoai.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
                xuLyChucNang(false);
                xuLycombox(true);
                xuly_textbox(false);
                xoa_them(false);
                cboTrangThai.Enabled = false;

                dsLoaiSP = q.layDuLieu("select * from LoaiSP");
                hienthiComboBox(cboMaLoai, dsLoaiSP, "TenLoai", "MaLoai");
                cboTrangThai.SelectedIndex = 0;
                txtMaNcc.Text = phatsinhMa_2();
                cboTrangThai.SelectedIndex = 0;
                flag = 1;

        }

        void xuLycombox(bool t)
        {
            cboTrangThai.Enabled = t;
            cboMaLoai.Enabled = t;  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLycombox(false);
            xuly_textbox(true);
            xoa_them(true);
            
            danhsach_datagridview(dgvDanhSach, "select * from NhaCungCap  where trangthai = 0");
            dsLoaiSP = q.layDuLieu("select * from LoaiSP");
            hienthiComboBox(cboMaLoai, dsLoaiSP, "TenLoai", "MaLoai");
            hienthiLenTextBox(ds, vitri);
            f = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuly_textbox(true);
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into NhaCungCap values('" + txtMaNcc.Text + "',N'" + txtTenNcc.Text + "', N'" + txtDiaChi.Text + "','" + txtPhone.Text + "' ,'" + txtEmail.Text + "','" + cboMaLoai.SelectedValue.ToString() + "',0 )";
            }
            if (flag == 2)
            {
                sql = "update NhaCungCap set TenNCC = N'" + txtTenNcc.Text + "',DiaChi = '" + txtDiaChi.Text + "',Phone = '" + txtPhone.Text + "', Email ='" + txtEmail.Text + "',MaLoai = '" + cboMaLoai.SelectedValue.ToString() + "',trangthai = " + cboTrangThai.SelectedIndex + " where MaNCC = '" + txtMaNcc.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update NhaCungCap set trangthai=1 where MaNCC='" + txtMaNcc.Text + "'";
            }
            if (q.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                vitri = 0;

            }

            frmNhaCungCap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
           
            xuly_textbox(false);
            xuLycombox(true);
            cboMaLoai.Enabled = false;
            txtMaNcc.Enabled = false;
            cboTrangThai.Enabled= false;
            flag = 2;
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc chắn muốn thoát",
               "Cofrm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        void hienthiLenTextBox(DataSet ds, int vt)
        {
            if (ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaNcc.Text = ds.Tables[0].Rows[vt]["MaNCC"].ToString();
                txtTenNcc.Text = ds.Tables[0].Rows[vt]["TenNCC"].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[vt]["DiaChi"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[vt]["Phone"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[vt]["Email"].ToString();

                string trangthai = ds.Tables[0].Rows[vt]["TrangThai"].ToString();
                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = " Ngưng hoạt động";
                }

                string maloai = ds.Tables[0].Rows[vt]["MaLoai"].ToString();
                locDuLieuComboBox(dsLoaiSP, cboMaLoai, "TenLoai", "MaLoai", maloai);
            }
        }
        void locDuLieuComboBox(DataSet ds, ComboBox cbo, string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "='" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        void hienthiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        string phatsinhMa_2()
        {
            string MaNCC = "";
            DataSet dsmau = q.layDuLieu("select MaNCC from NhaCungCap");
            MaNCC = "NCC0" + (dsmau.Tables[0].Rows.Count + 1).ToString();
            return MaNCC;
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienthiLenTextBox(ds, vitri);
        }

        void deleteThem()
        {
            txtMaNcc.Clear();
            txtTenNcc.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 3;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string mancc = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tenncc = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string diachi = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string phone = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                    string email = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();

                    string sql = "update NhaCungCap set TenNCC =N'" + tenncc + "',DiaChi = N'" + diachi + "',Email = '" + email + "' , Phone ='" + phone + "' where MaNCC = '" + mancc + "'";
                    if (q.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        vitri = 0;
                        frmNhaCungCap_Load(sender, e);
                    }
                }
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNcc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int lenght_max = 10;
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Bạn nhập dữ liệu sai");
            }
            if (txtPhone.Text.Length >= lenght_max && char.IsControl(e.KeyChar) == false  )
            {
                e.Handled = true;

            }
        }

        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra tính hợp lệ của email
            string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            string email = txtEmail.Text;

            // Kiểm tra lỗi khi người dùng nhấn Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (IsValidEmail(email))
                {
                    // Email hợp lệ, thực hiện xử lý tiếp theo
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ!");
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
