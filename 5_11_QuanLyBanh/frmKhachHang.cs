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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static DevExpress.XtraEditors.RoundedSkinPanel;
using System.Security.Cryptography;

namespace _5_11_QuanLyBanh
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang(frmHoaDonBan frm)
        {
            InitializeComponent();
        }
        
        quanlybanBanh q = new quanlybanBanh();
        DataSet ds = new DataSet();

        int vitri = 0;
        void danhsach_datagridview(DataGridView d , string sql)
        {
            ds = q.layDuLieu(sql);
            d.DataSource= ds.Tables[0];
        }

        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        Boolean f = false;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            
            xuLyChucNang(true);
            xulycombox(false);

            //...
            danhsach_datagridview(dgvDanhSach, "select * from KhachHang where trangthai = 0");        
            vitri = ds.Tables[0].Rows.Count-1;
            hienthiLenTextBox(ds, vitri);
            //...
           
            
            f =true;
        }

      

        int flag = 0;// cờ
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuly_textbox(false);
            xulycombox(true);
            deleteThem();
            cboTrangThai.SelectedIndex = 0;
            txtMaKH.Text = phatsinhMa_2();
            cboTrangThai.SelectedIndex = 0;
            flag = 1;// bật cờ
        }


        void xulycombox(bool t)
        {
            cboPhai.Enabled = t;
            cboTrangThai.Enabled = t;
        }

        void xuly_textbox(Boolean t)
        {
            txtMaKH.ReadOnly = t;
            txtTenKH.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            txtPhone.ReadOnly = t;
            txtEmail.ReadOnly = t;
          
        }

        public string laygiatri_sdt()
        {
            return txtPhone.Text;
        }
        public string laygiatri_ten()
        {
            return txtTenKH.Text;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuly_textbox(true);
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into KhachHang values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "', 0,N'" + txtDiaChi.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "', 0)";
            }
            if (flag == 2)
            {
                sql = "update KhachHang set TenKh = N'" + txtTenKH.Text + "', Phai =" + cboPhai.SelectedIndex + ",DiaChi = N'" + txtDiaChi.Text + "',Email = '" + txtEmail.Text + "', Phone ='" + txtPhone.Text + "',trangthai = " + cboTrangThai.SelectedIndex + " where MaKh = '" + txtMaKH.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update KhachHang set trangthai=1 where MaKH='" + txtMaKH.Text + "'";
            }
            if (q.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                vitri = 0;
                frmKhachHang_Load(sender, e);
            }    
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false) ;
            xuly_textbox(false);
            xulycombox(true);
            flag = 2;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc chắn muốn thoát",
                "Cofrm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        void hienthiLenTextBox(DataSet ds , int vt)
        {

            if (ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaKH.Text = ds.Tables[0].Rows[vt]["MaKh"].ToString();
                txtTenKH.Text = ds.Tables[0].Rows[vt]["TenKH"].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[vt]["DiaChi"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[vt]["Phone"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[vt]["Email"].ToString();

                string trangthai = cboTrangThai.Text = ds.Tables[0].Rows[vt]["TrangThai"].ToString();
                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = " Ngưng hoạt động";
                }

                string phai = cboPhai.Text = ds.Tables[0].Rows[vt]["Phai"].ToString();
                if (phai == "0")
                {
                    cboPhai.Text = "Nam";
                }
                else
                {
                    cboPhai.Text = " Nữ";
                }
            }
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            hienthiLenTextBox(ds, vitri);
        }

        void deleteThem()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            //xuly_textbox(true);
            flag = 3;
            
            
        }

        //phat sinh ma
        //string phatsinh()
        //{
        //    string makh = "";
        //    makh ="MKH"+ (ds.Tables[0].Rows.Count+1).ToString();
        //    return makh;
        //}

        string phatsinhMa_2()
        {
            string KH = "";
            DataSet dsmau = q.layDuLieu("select * from KhachHang");
            KH = "KH0" + (dsmau.Tables[0].Rows.Count + 1).ToString();
            return KH;


        }

        private void cboPhai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if(f)
            if(e.ColumnIndex >=1)
            {
                int vt = dgvDanhSach.CurrentRow.Index;
                string makh = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();//cell  lấy cột số mấy
                string tenkh = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                //string ngaysinh = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                string diachi = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                string phone = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                string email = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
     
                string sql= "update KhachHang set TenKh =N'"+ tenkh +"',DiaChi = N'" + diachi + "',Email = '" + email + "' , Phone ='" + phone + "' where MaKh = '" + makh + "'";
                if (q.capNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    vitri = 0;
                    frmKhachHang_Load(sender, e);
                }
            }    
        }

        private void grpDSKH_Enter(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int lenght_max = 10;
            if(char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar)== false && e.KeyChar!=8)
            {
                e.Handled= true;
                MessageBox.Show("Bạn nhập dữ liệu sai");
            }    
            if(txtPhone.Text.Length >= lenght_max && char.IsControl(e.KeyChar)== false)
            {
                e.Handled = true;

            }    
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
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
    }
}
