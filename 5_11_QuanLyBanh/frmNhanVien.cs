using DevExpress.Drawing.Internal.Fonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_11_QuanLyBanh
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int vitri = 0;
        quanlybanBanh q = new quanlybanBanh();
        DataSet ds = new DataSet();

        int flag = 0; // co hieu
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = q.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void xuLyChucNang(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
            btnHuy.Enabled = !t;
        }

        void xuly_textBox(bool t)
        {
            

            txtTenNV.ReadOnly= t;
           // txtNgaySinh.ReadOnly= t
            txtMaNV.ReadOnly= t;
            txtDiaChi.ReadOnly= t;
            txtPhone.ReadOnly= t;
            cboGioiTinh.Enabled= !t;
            dateTimePicker1.Enabled= !t;
            cboTrangThai.Enabled = !t;

        }

        void xulyThem()
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.Clear();
            txtPhone.Clear();
            txtDiaChi.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cboGioiTinh.Text = "";
            cboTrangThai.Enabled = false;
        }


       

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            vitri = 0;
            xuLyChucNang(true);
            xuly_textBox(true);
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai = 0");// where trangthai = 0
            

            radTimKiem.Checked = false;
            xuLyComboBox_timKiem(false);
            xulyTimKiem();

            hienthiLenTextBox(ds, vitri);
            f = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            xuLyChucNang(false);


            xuly_textBox(false);
            xulyThem();

            

            txtMaNV.Text = phatsingMa_2();

            btnHuy.Focus();
            flag = 1; //bat co
            //cboTrangThai.SelectedIndex= 0;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            string sql = "";
            string tenChucNang = "";
           // string sql2 = "";
            if(flag == 1)
            {
                if(txtTenNV.Text =="" || cboGioiTinh.Text =="" || dateTimePicker1.Text =="" || txtDiaChi.Text =="" || txtPhone.Text == "")
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                   
                    return;
                }

                sql = "insert into NhanVien values('" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', '" + cboGioiTinh.SelectedIndex + "', '" + dateTimePicker1.Text + "', N'" + txtDiaChi.Text + "', '" + txtPhone.Text + "', 0)";
                tenChucNang = "thêm";
               //sql2 = string.Format(@"insert into NhanVien values({0},{1},{2},{3},{4},{5},0)",txtMaNV.Text, txtTenNV.Text, cboGioiTinh.SelectedIndex, dateTimePicker1.Text, txtDiaChi.Text, txtPhone.Text);
            }
            if (flag == 2)
            {
               sql = "update NhanVien set  Hoten= N'"+txtTenNV.Text+"', Phai="+cboGioiTinh.SelectedIndex+", NgaySinh='"+dateTimePicker1.Text+"', DiaChi=N'"+txtDiaChi.Text+"', Phone='"+txtPhone.Text+"', trangthai="+cboTrangThai.SelectedIndex+" where MaNV = '"+txtMaNV.Text+"'";
                tenChucNang = "sửa";
            }
            if(flag == 3)
            {
                sql = "update NhanVien set trangthai= 1 where MaNV='"+txtMaNV.Text+"'";
                tenChucNang = "xóa";
               
            }

            DialogResult luu;
            luu = MessageBox.Show("Bạn có muốn "+ tenChucNang, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (luu == DialogResult.Yes)
            {   
                if (q.capNhatDuLieu(sql) > 0)
                {

                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //vitri = 0;

                    frmNhanVien_Load(sender, e);
                }
            }
            frmNhanVien_Load(sender, e);
           
        }

        //  xu li messagebox --> ban co muon luu

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            
            xuly_textBox(false);

            btnHuy.Focus();
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);

            btnHuy.Focus();

            flag = 3;
           
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        void hienthiLenTextBox(DataSet ds, int vt)
        {
           if( ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaNV.Text = ds.Tables[0].Rows[vt]["MaNV"].ToString();
                txtTenNV.Text = ds.Tables[0].Rows[vt]["Hoten"].ToString();
                //txtNgaySinh.Text = ds.Tables[0].Rows[vt]["NgaySinh"].ToString();
                dateTimePicker1.Text = ds.Tables[0].Rows[vt]["NgaySinh"].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[vt]["DiaChi"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[vt]["Phone"].ToString();
                string trangthai = ds.Tables[0].Rows[vt]["trangthai"].ToString();
                string Phai = ds.Tables[0].Rows[vt]["Phai"].ToString();

                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = "Ngưng hoạt động";
                }

                if (Phai == "0")
                {
                    cboGioiTinh.Text = "Nam";
                }
                else
                {
                    cboGioiTinh.Text = "Nữ";
                }
            }
            


        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienthiLenTextBox(ds, vitri);
        }

        //phat sinh ma

        string phatsinhMa_1()
        {
            string maNV = "";
            maNV = "MaNV" + (ds.Tables[0].Rows.Count+1).ToString();
            return maNV;
        }

        string phatsingMa_2()
        {
            string maNV = "";
            DataSet dsma = q.layDuLieu("select * from NhanVien");

            if (dsma.Tables[0].Rows.Count < 9)
            {
                maNV = "NV0" + (dsma.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                maNV = "NV" + (dsma.Tables[0].Rows.Count + 1).ToString();
            }
            return maNV;
            //maNV = "NV0" + (dsma.Tables[0].Rows.Count + 1).ToString();
            //return maNV;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(thoat==  DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int length_max = 10;
            if(char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar) == false && e.KeyChar!=8 )
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (txtPhone.Text.Length >= length_max && char.IsControl(e.KeyChar) == false )
            {               
                e.Handled = true;           
            }
          
        }


        Boolean f = false;
        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(f)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string manv = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tennv = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    //string phai = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string ngaysinh = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                    string diachi = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                    string phone = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
                    //string trangthai = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
                    string sql = "update NhanVien set  Hoten= N'" + tennv + "', NgaySinh='" + ngaysinh + "', DiaChi=N'" + diachi + "', Phone='" + phone + "' where MaNV = '" + manv + "'";
                    if (q.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        //vitri = 0;
                        frmNhanVien_Load(sender, e);
                    }
                }
            }             
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            hienthiLenTextBox(ds, vitri);
            xuly_textBox(true);


            btnThoat.Focus();
            frmNhanVien_Load(sender, e);
        }

        // anh luu trong thu muc bin--> debug


        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        private void cboTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f)
            {
                if (cboTimTheo.SelectedIndex == 0)
                {
                    ds = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, ds, "MaNV", "MaNV");
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    ds = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, ds, "HoTen", "MaNV");
                }
            }
            cboHienThiTimTheo.Enabled = true;
        }

        private void cboHienThiTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = "";
            string sql = "";
            if (f)
            {
                if (cboTimTheo.SelectedIndex == 0)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        ds = q.layDuLieu(sql);

                    }
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        ds = q.layDuLieu(sql);

                    }
                }

            }
            dgvDanhSach.DataSource = ds.Tables[0];
            hienthiLenTextBox(ds, vitri);
        }


        void xulyTimKiem()
        {
            btnHuyTimKiem.Enabled = false;
            cboHienThiTimTheo.Text = "";
            cboTimTheo.Text = "";
        }

        void xuLyComboBox_timKiem(bool t)
        {
            cboTimTheo.Enabled = t;
            cboHienThiTimTheo.Enabled = t;
        }
        private void radTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            btnHuyTimKiem.Enabled = true;
            xuLyComboBox_timKiem(true);
           
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {

            xulyTimKiem();

            
            frmNhanVien_Load(sender, e);
        }
    }
}
