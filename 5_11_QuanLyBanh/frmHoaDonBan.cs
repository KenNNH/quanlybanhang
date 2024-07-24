using DevExpress.XtraEditors.Mask.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.CommandChannelHelper;

namespace _5_11_QuanLyBanh
{
    public partial class frmHoaDonBan : Form
    {
            

        public frmHoaDonBan()
        {
            InitializeComponent();
            
        }

        quanlybanBanh q = new quanlybanBanh();
        DataSet dsHoaDon = new DataSet();
        DataSet dsKhachHang = new DataSet();
        DataSet dsNhanVien = new DataSet();
        DataSet dsSanPham = new DataSet();
        DataSet dsChiTietHDB = new DataSet();

        int vitri = 0;

        int vitri2 = 0;
        Boolean f = false;

        int flag = 0;

        void danhsach_datagridview2(DataGridView dgv, string sql)
        {
            dsHoaDon = q.layDuLieu(sql);
            dgv.DataSource = dsHoaDon.Tables[0];

        }
        void xuLyChucNang(bool t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        void xulyTextBox_HD(bool t)
        {
            //txtMaHDBan.ReadOnly = t; luon luon readonly
            dateHD.Enabled= !t;
            txtPhoneKhach.ReadOnly = t;
            txtTenKhach.ReadOnly = t;
            cboTenNV.Enabled = !t;
            cboTrangThai.Enabled = !t;
            //txtTongTien.ReadOnly = t;
           
            radSizeM.Enabled = !t;
            radSizeL.Enabled = !t;
            radSizeXL.Enabled = !t;
        }

        void xulyTextBox_CTHD(bool t)
        {
            txtMaSP.ReadOnly = t;
            txtTenSP.ReadOnly = t;
            txtGiaBan.ReadOnly = t;
           
            txtSoLuong.ReadOnly = t;
            txtKhuyenMai.ReadOnly = t;
           
        }

        void xuly_Them()
        {
            txtMaHDBan.Text = "";
            txtPhoneKhach.Text = "";
            txtTenKhach.Text = "";
            txtTongTien.Text = "";
            dateHD.Value = DateTime.Now;

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtKhuyenMai.Text = "";

            cboTenNV.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            dateHD.Enabled = false;
            btnLuu.Enabled = false;
            //picHinhAnh.Image = Image.FromFile(@"D:\CDTH21A_WEB_C\NAM_3\WINDOWS\DoAn_QuanLyBanh\5_11_QuanLyBanh\5_11_QuanLyBanh\bin\Debug\hinhanh_SanPham\hinhanh_giaodien\hinh_themSP.png");
            //picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage; 
            //hinhanh...

            btnThemCTHD.Visible = true;
        }

        void xuly_button(bool t)
        {
            btnTimKH.Enabled = !t;
            btnThemKH.Enabled = !t;
           

        }

        void xuly_Rad(bool t)
        {
            radSizeL.Checked = t;
            radSizeM.Checked = t;
            radSizeXL.Checked = t;
        }


        void xuly_sua()
        {
            txtSoLuong.ReadOnly = false;
            
        }

        void hienthiLenTextBox(DataSet ds, int vt)
        {     
            if (ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaHDBan.Text = ds.Tables[0].Rows[vt]["MaHDBan"].ToString();

                //manv
                string manv = ds.Tables[0].Rows[vt]["MaNV"].ToString();
                locDuLieuComboBox(dsNhanVien, cboTenNV, "HoTen", "MaNV", manv);

                dateHD.Text = ds.Tables[0].Rows[vt]["NgayLapHD"].ToString();
                //Makh

                txtTongTien.Text = ds.Tables[0].Rows[vt]["Tongtien"].ToString();

                string trangthai = ds.Tables[0].Rows[vt]["trangthai"].ToString();

                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Mới";
                }
                else if (trangthai == "1")
                {
                    cboTrangThai.Text = "Đã giao";
                }
                else if(trangthai == "2")
                {               
                    cboTrangThai.Text = "Đang giao";                  
                }
                else
                {
                    cboTrangThai.Text = "Đã hủy";
                }

                //cthd
                load_cthdtheoma(ds.Tables[0].Rows[vt]["MaHDBan"].ToString()); //....

                vitri2 = 0;
            }
            //hienthiLenTextBox2(ds2, vt2, sp);




        }

        string tensize_click = "";
        void hienthiLenTextBox2(DataSet ds2, int vt, DataSet ds1) 
        {  
            if (ds2.Tables[0].Rows.Count > vt && vt > -1)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    if (ds2.Tables[0].Rows[vt]["MaSP"].ToString() == ds1.Tables[0].Rows[i]["MaSP"].ToString())
                    {
                        txtMaSP.Text = ds1.Tables[0].Rows[i]["MaSP"].ToString();
                        txtTenSP.Text = ds1.Tables[0].Rows[i]["TenSP"].ToString();
                        txtGiaBan.Text = ds2.Tables[0].Rows[vt]["DonGia"].ToString();
                        txtKhuyenMai.Text = ds2.Tables[0].Rows[vt]["ChietKhau"].ToString();
                        txtSoLuong.Text = ds2.Tables[0].Rows[vt]["SoLuong"].ToString();

                        string mahinh = ds1.Tables[0].Rows[i]["MaHinh"].ToString();
                        string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + mahinh;
                        taoAnh_tuFileAnh(picHinhAnh, tenfile);

                       

                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim() == "M")
                        {
                            radSizeM.Checked = true;
                            tensize_click = "M";
                            xulyTextBox_CTHD(true);
                            //MessageBox.Show(tensize_click);
                            if (flag == 2)
                            {
                                txtSoLuong.ReadOnly = false;
                            }
                        }

                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim()=="L")
                        {
                            // radSizeL.Checked = false;
                            radSizeL.Checked = true;

                            tensize_click = "L";
                           xulyTextBox_CTHD(true);
                            // MessageBox.Show(tensize_click);
                            if (flag == 2)
                            {
                                txtSoLuong.ReadOnly = false;
                            }
                        }

                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim() == "XL")
                        {
                            radSizeXL.Checked = true;
                            tensize_click = "XL";
                           xulyTextBox_CTHD(true);
                            // MessageBox.Show(tensize_click);
                            if (flag == 2)
                            {
                                txtSoLuong.ReadOnly = false;
                            }
                        }                      
                    }

                }

            }       
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            
            //   NCC0101.ML01
            xuLyChucNang(true);
            xulyTextBox_HD(true);   
            xulyTextBox_CTHD(true);
            xuly_button(true);
            btnThemCTHD.Visible = false;
            txtSoLuong.ReadOnly = true;
            
            //(ref dsHoaDon,dgvDanhSachHD, "select * from HoaDonBan");
            danhsach_datagridview2(dgvDanhSachHD, "select * from HoaDonBan where trangthai !=  4");
            //danhsach_datagridview2(dgvDanhSachCTHD, "select * from CTHDBan where trangthai =  0");
            //dsChiTietHDB = q.layDuLieu("select * from cthdban");
            dsKhachHang = q.layDuLieu("select * from KhachHang");
            dsNhanVien = q.layDuLieu("select * from NhanVien");
            dsSanPham = q.layDuLieu("select * from SanPham");
            dsChiTietHDB = q.layDuLieu("select * from CTHDBan");

            
            hienThiComboBox(cboTenNV, dsNhanVien, "HoTen", "MaNV");


            vitri = 0;
            vitri2 = 0;         
            hienthiLenTextBox(dsHoaDon, vitri);
            hienthiLenTextBox2(dsChiTietHDB, vitri2, dsSanPham);

            
            // hienthiLenTextBox2(dsChiTietHDB, vitri, dsSanPham);
            f = true;      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten; //lay ten
            cbo.ValueMember = ma; //lay ma
            cbo.SelectedIndex = -1;
        }

        void locDuLieuComboBox(DataSet ds, ComboBox cbo, string ten, string ma, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "='"+ giatrima+"'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }


        string phone_makh = "";
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            dsKhachHang = q.layDuLieu("select * from KhachHang");
            for (int i = 0; i < dsKhachHang.Tables[0].Rows.Count; i++)
            {
                if (txtPhoneKhach.Text == dsKhachHang.Tables[0].Rows[i]["Phone"].ToString())
                {
                    txtTenKhach.Text = dsKhachHang.Tables[0].Rows[i]["TenKH"].ToString();
                    phone_makh = dsKhachHang.Tables[0].Rows[i]["MaKH"].ToString();             
                }
              
            }         
        }


        private void txtPhoneKhach_TextChanged(object sender, EventArgs e)
        {
            
            dsKhachHang = q.layDuLieu("select * from KhachHang");
            for (int i = 0; i < dsKhachHang.Tables[0].Rows.Count; i++)
            {
                if (txtPhoneKhach.Text == dsKhachHang.Tables[0].Rows[i]["Phone"].ToString())
                {
                   //txtTenKhach.Text = dsKhachHang.Tables[0].Rows[i]["TenKH"].ToString();
                    phone_makh = dsKhachHang.Tables[0].Rows[i]["MaKH"].ToString();
                }

            }
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
           
        }

        void taoCotHD()
        {
            dgvDanhSachHD.Columns.Clear();
            dgvDanhSachHD.Columns.Add("MaHDBan", "Mã hóa đơn");
            dgvDanhSachHD.Columns.Add("MaNV", "Mã nhân viên");
            dgvDanhSachHD.Columns.Add("NgayLapHD", "Ngày lập hóa đơn");
            dgvDanhSachHD.Columns.Add("MaKH", "Mã khách hàng");
            dgvDanhSachHD.Columns.Add("Tongtien", "Tổng tiền");
            dgvDanhSachHD.Columns.Add("trangthai", "Trạng thái");
        }

        void taoCotCTHD()
        {
            dgvDanhSachCTHD.Columns.Clear();

            dgvDanhSachCTHD.Columns.Add("MaHD", "Mã hóa đơn");
            dgvDanhSachCTHD.Columns.Add("MaSP", "Mã sản phẩm");
            dgvDanhSachCTHD.Columns.Add("SoLuong", "Số lượng");
            dgvDanhSachCTHD.Columns.Add("DonGia", "Đơn giá");
            dgvDanhSachCTHD.Columns.Add("ChietKhau", "Khuyến mãi");
            dgvDanhSachCTHD.Columns.Add("ThanhTien", "Thành tiền");
            dgvDanhSachCTHD.Columns.Add("size", "size");
            dgvDanhSachCTHD.Columns.Add("trangthai", "Trạng thái");
            
        }

       
        bool xuly_HD(DataGridView dgv)
        {
            for (int j = 0; j < dgv.Rows.Count - 1; j++)
            {
                if (dgv.Rows[j].Cells[0].Value.ToString() == txtMaHDBan.Text)// +"." + phone_makh
                {
                    dgv.Rows[j].Cells[4].Value = txtTongTien.Text;
                    //dgvDanhSachHD.Rows.Add(HD);
                    return true;
                }
               
            }
            return false;
        }

        long tongtien = 0;
        
        bool xuly_CTHD(DataGridView dgv, string tensize, float thanhtien)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                if (dgv.Rows[i].Cells[1].Value.ToString() == txtMaSP.Text && dgv.Rows[i].Cells[6].Value.ToString() == tensize) //dgvDanhSachCTHD.Rows[i].Cells[0].Value.ToString() == txtMaHDBan.Text + "." + txtMaSP.Text + "." + tensize && dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString() == txtMaSP.Text && 
                {
                    //tang so luong

                    int soluong = int.Parse(dgv.Rows[i].Cells[2].Value.ToString());
                    soluong += int.Parse(txtSoLuong.Text);
                    dgv.Rows[i].Cells[2].Value = soluong;


                    float KHUYENMAI = float.Parse(txtKhuyenMai.Text);
                    dgv.Rows[i].Cells[4].Value = KHUYENMAI;

                    //tang thanh tien
                    //thanhtien = (float.Parse(dgvDanhSachCTHD.Rows[i].Cells[5].Value.ToString()) + (int.Parse(txtSoLuong.Text) * float.Parse(txtGiaBan.Text))) - (int.Parse(txtSoLuong.Text) * float.Parse(dgvDanhSachCTHD.Rows[i].Cells[4].Value.ToString()));
                    //thanhtien = (thanhtien + (float.Parse(txtSoLuong.Text) * float.Parse(txtGiaBan.Text))) - KHUYENMAI;

                    thanhtien = (soluong * float.Parse(dgv.Rows[i].Cells[3].Value.ToString())) - (soluong * float.Parse(txtKhuyenMai.Text));

                    dgv.Rows[i].Cells[5].Value = thanhtien;


                    //tang tong tien

                    tongtien += (int.Parse(txtSoLuong.Text) * long.Parse(txtGiaBan.Text)) - (int.Parse(txtSoLuong.Text) * long.Parse(txtKhuyenMai.Text));
                   
                    //if(float.Parse(KHUYENMAI_CHUADOI) == float.Parse(KHUYENMAI.ToString()))
                    //{
                    //    tongtien += (int.Parse(txtSoLuong.Text) * long.Parse(txtGiaBan.Text) - (int.Parse(txtSoLuong.Text) * long.Parse(txtKhuyenMai.Text)));
                    //}
                    //else
                    //{
                    //    tongtien += (int.Parse(txtSoLuong.Text) * long.Parse(txtGiaBan.Text)) - (soluong * long.Parse(txtKhuyenMai.Text) + long.Parse(tien_trukhuyenmai.ToString()));
                    //}

                    txtTongTien.Text = tongtien.ToString();

                    //khuenmai = float.Parse(txtKhuyenMai.Text);                 

                    xuly_HD(dgvDanhSachHD);
                    return true;

                }
         
            }
            return false;
        }



        void taoCTHoaDon(object[] CTHD, string tensize, long thanhtien)
        {
          
            CTHD[0] = txtMaHDBan.Text; // + "." + txtMaSP.Text + "." + tensize;
            CTHD[1] = txtMaSP.Text;
            CTHD[2] = txtSoLuong.Text;
            CTHD[3] = txtGiaBan.Text;
            if (txtKhuyenMai.Text == "")
            {
                txtKhuyenMai.Text = "0";
                CTHD[4] = txtKhuyenMai.Text;
            }
            else
            {
                CTHD[4] = txtKhuyenMai.Text;
            }

            thanhtien = (int.Parse(txtSoLuong.Text) * long.Parse(txtGiaBan.Text)) - (long.Parse(txtKhuyenMai.Text) * int.Parse(txtSoLuong.Text)) ;
            CTHD[5] = /*float.Parse(txtSoLuong.Text) * float.Parse(txtGiaBan.Text); */thanhtien.ToString();
            CTHD[6] = tensize; //radSizeM.Checked ? "M" : radSizeL.Checked ? "L" : radSizeXL.Checked ? "XL" : "";
            CTHD[7] = '0';
            
            tongtien += thanhtien;
            txtTongTien.Text = tongtien.ToString();
            dgvDanhSachCTHD.Rows.Add(CTHD);
        }


        bool xuly_khichuanhapText()
        {
            if (txtPhoneKhach.Text == "" || txtTenKhach.Text == "" || cboTenNV.Text == "" || cboTrangThai.Text == "" || txtSoLuong.Text == "")
            {
                return true;
            }
            return false;
        }

        //dgvDanhSachCTHD.Rows[i].Cells[0].Value.ToString() --> dong thu i cot thu 0
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {      
            if (xuly_khichuanhapText())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }


            for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
            {
                int soluong_banra = int.Parse(txtSoLuong.Text);
                int soluong_hienco = 0;

                if (radSizeM.Checked)
                {
                    soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongM"].ToString());
                }
                if (radSizeL.Checked)
                {
                    soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongL"].ToString());
                }
                if (radSizeXL.Checked)
                {
                    soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongXL"].ToString());
                }

                if (soluong_hienco < soluong_banra)
                {
                    MessageBox.Show("Sản phẩm:  " + dsSanPham.Tables[0].Rows[i]["TenSP"].ToString() + ", không còn đủ số lượng"
                           + System.Environment.NewLine + "Số lượng hiện có: " + soluong_hienco,
                           "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    return;
                }
                // soluong_banra = 0;
                int tinh_SoLuongBan = 0;
                for (int j = 0; j < dgvDanhSachCTHD.Rows.Count - 1; j++)
                {
                    if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == dgvDanhSachCTHD.Rows[j].Cells[1].Value.ToString() && dgvDanhSachCTHD.Rows[j].Cells[6].Value.ToString() == "M" && radSizeM.Checked)
                    {
                        soluong_banra = int.Parse(dgvDanhSachCTHD.Rows[j].Cells[2].Value.ToString());
                        //  kiemtra_dieukien_if = true;

                    }                   
                    if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == dgvDanhSachCTHD.Rows[j].Cells[1].Value.ToString()  && dgvDanhSachCTHD.Rows[j].Cells[6].Value.ToString() == "L" && radSizeL.Checked)
                    {
                        soluong_banra = int.Parse(dgvDanhSachCTHD.Rows[j].Cells[2].Value.ToString());
                        //  kiemtra_dieukien_if = true;
                    }
                    if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == dgvDanhSachCTHD.Rows[j].Cells[1].Value.ToString()  && dgvDanhSachCTHD.Rows[j].Cells[6].Value.ToString() == "XL" && radSizeXL.Checked)
                    {
                        soluong_banra = int.Parse(dgvDanhSachCTHD.Rows[j].Cells[2].Value.ToString());
                        //  kiemtra_dieukien_if = true;
                    }
                  
                    
                }
                tinh_SoLuongBan = soluong_hienco - soluong_banra;
                if (tinh_SoLuongBan <= 0)
                {
                    MessageBox.Show("Sản phẩm:  " + dsSanPham.Tables[0].Rows[i]["TenSP"].ToString() + ", không còn đủ số lượng"
                        + System.Environment.NewLine + "Số lượng hiện có: " + soluong_hienco,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    return;
                }
            }



            btnLuu.Enabled = true;

            object[] CTHD = new object[8];
            object[] HD = new object[6];
            long thanhtien = 0;
            //float khuyenmai = 0;
            string tensize = radSizeM.Checked ? "M" : radSizeL.Checked ? "L" : radSizeXL.Checked ? "XL" : "";

            if (xuly_CTHD(dgvDanhSachCTHD, tensize, thanhtien))
            {
               return;
            }

            taoCTHoaDon(CTHD, tensize, thanhtien);


            HD[0] = txtMaHDBan.Text; //+ "." + phone_makh;
            HD[1] = cboTenNV.SelectedValue.ToString();
            HD[2] = dateHD.Text;
            HD[3] = phone_makh;
            HD[4] = txtTongTien.Text;
            HD[5] = cboTrangThai.SelectedIndex;

            if(xuly_HD(dgvDanhSachHD))
            {
                return;
            }
            else
            {
                dgvDanhSachHD.Rows.Add(HD);
      
            }
        }


        void xuly_tatTextBox(bool t)
        {
            txtMaSP.ReadOnly = t;
            txtSoLuong.ReadOnly = t;
            txtKhuyenMai.ReadOnly = t;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

            xuLyChucNang(false);
            xulyTextBox_HD(false);
            xuly_button(false);
            xuly_Them();
            xuly_Rad(false);
            txtMaHDBan.Text = phatsingMa();
            //dgvDanhSachCTHD.Columns.Clear();
            //dgvDanhSachHD.Columns.Clear();
            
            xuly_tatTextBox(true);

            taoCotHD();
            taoCotCTHD();
            dgvDanhSachHD.DataSource = null;
            dgvDanhSachCTHD.DataSource = null;
           

            tongtien = 0;
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 3;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           

            xuLyChucNang(false);
            //xulyTextBox_HD(false);
            xuly_sua();
            xuly_button(false);
            flag = 2;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuly_Rad(false);
           
            
            dgvDanhSachHD.Columns.Clear();
            dgvDanhSachCTHD.Columns.Clear();
            frmHoaDonBan_Load(sender, e);

            flag = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {       
            string sql = "";
            if (flag == 1)
            {
                int dem_capnhat = 0;
                string MaHD = txtMaHDBan.Text;
                string MaNV = cboTenNV.SelectedValue.ToString();
                string NgayLapHD = dateHD.Text;
                string MaKH = phone_makh;
                string TongTien = txtTongTien.Text;
                string trangthai = cboTrangThai.SelectedIndex.ToString();
                sql = "insert into HoaDonBan values('" + MaHD + "','" + MaNV + "','" + NgayLapHD + "','" + MaKH + "'," + TongTien  +"," + trangthai +")";
         

                if (q.capNhatDuLieu(sql) > 0)
                {
                    for (int i = 0; i < dgvDanhSachCTHD.Rows.Count - 1; i++)
                    {
                        string MaCTHD = dgvDanhSachCTHD.Rows[i].Cells[0].Value.ToString();
                        string MaSP = dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString();
                        string SoLuong = dgvDanhSachCTHD.Rows[i].Cells[2].Value.ToString();
                        string DonGia = dgvDanhSachCTHD.Rows[i].Cells[3].Value.ToString();
                        string ChietKhau = dgvDanhSachCTHD.Rows[i].Cells[4].Value.ToString();
                        string ThanhTien = dgvDanhSachCTHD.Rows[i].Cells[5].Value.ToString();
                        string Size = dgvDanhSachCTHD.Rows[i].Cells[6].Value.ToString();
                        string trangthai1 = "0";
                        sql = "insert into CTHDBan values('" + MaCTHD + "','" + MaSP + "'," + SoLuong + "," + DonGia + "," + ChietKhau + "," + ThanhTien + ",'" + Size + "'," + trangthai1 + ")";

                        if (q.capNhatDuLieu(sql) > 0)
                        {
                            dem_capnhat++;
                        }

                        if (dgvDanhSachCTHD.Rows[i].Cells[6].Value.ToString() == "M")
                        {
                            string sql_SoLuongBan = "update SanPham set SoLuongM = SoLuongM - " + dgvDanhSachCTHD.Rows[i].Cells[2].Value.ToString() + "where MaSP = '" + dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongBan);
                        }
                        if (dgvDanhSachCTHD.Rows[i].Cells[6].Value.ToString() == "L")
                        {
                            string sql_SoLuongBan = "update SanPham set SoLuongL = SoLuongL - " + dgvDanhSachCTHD.Rows[i].Cells[2].Value.ToString() + "where MaSP = '" + dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongBan);
                        }
                        if (dgvDanhSachCTHD.Rows[i].Cells[6].Value.ToString() == "XL")
                        {
                            string sql_SoLuongBan = "update SanPham set SoLuongXL = SoLuongXL - " + dgvDanhSachCTHD.Rows[i].Cells[2].Value.ToString() + "where MaSP = '" + dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongBan);
                        }

                    }

                }
                if (dem_capnhat != 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhSachCTHD.Columns.Clear();
                    dgvDanhSachHD.Columns.Clear();
                    xuly_Them();

                }
                frmHoaDonBan_Load(sender, e);
            }

            if(flag == 2)
            {
                string sql_capnhatSoluong = "";
                int soluong_sua = int.Parse(txtSoLuong.Text);
                string MaHD = txtMaHDBan.Text;
                string MaSP = txtMaSP.Text;

                int soluong_dgcotrong_cthd = 0;
                    

                for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
                {

                    for (int j = 0; j < dgvDanhSachCTHD.Rows.Count - 1; j++)
                    {
                        //MessageBox.Show(dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() + " : "+ MaSP + " : " + dgvDanhSachCTHD.Rows[j].Cells[6].Value.ToString() + " : " + tensize_click);
                        if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == MaSP)
                        {
                            int soluong_hienco = 0;
                            if (tensize_click == "M")
                            {
                                soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongM"].ToString());
                            }
                            if (tensize_click == "L")
                            {
                                soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongL"].ToString());
                            }
                            if (tensize_click == "XL")
                            {
                                soluong_hienco = int.Parse(dsSanPham.Tables[0].Rows[i]["SoLuongXL"].ToString());
                            }

                            if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == MaSP && dgvDanhSachCTHD.Rows[j].Cells[6].Value.ToString().Trim() == tensize_click)
                            {
                                soluong_dgcotrong_cthd = int.Parse(dgvDanhSachCTHD.Rows[j].Cells[2].Value.ToString());
                            }

                            if (soluong_hienco >= soluong_sua)
                            {
                                string sql_soluong_sua = "";
                                sql_soluong_sua = " update CTHDBan set SoLuong = '" + soluong_sua + "' where MaHD = '" + MaHD + "' and MaSP = '" + MaSP + "' and size = '" + tensize_click + "'";
                                q.capNhatDuLieu(sql_soluong_sua);

                                //tongsoluong_moicapnhat += int.Parse(dgvDanhSachCTHD.Rows[j].Cells[2].Value.ToString());

                                if (tensize_click == "M")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongM = SoLuongM + " + soluong_dgcotrong_cthd + " - " + soluong_sua + " where MaSP = '" + MaSP + "'";

                                }
                                if (tensize_click == "L")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongL = SoLuongL + " + soluong_dgcotrong_cthd + " - " + soluong_sua + " where MaSP = '" + MaSP + "'";

                                }
                                if (tensize_click == "XL")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongXL = SoLuongXL + " + soluong_dgcotrong_cthd + " - " + soluong_sua + " where MaSP = '" + MaSP + "'";
                                }

                            }
                            else
                            {
                                MessageBox.Show("Số lượng không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }


                q.capNhatDuLieu(sql_capnhatSoluong);

                string sql_thanhTien = "update CTHDBan set thanhTien = (SoLuong*DonGia)-(SoLuong*ChietKhau)  where MaHD = '" + MaHD + "' and MaSP = '" + MaSP + "' and size = '" + tensize_click + "'";

                q.capNhatDuLieu(sql_thanhTien);

                sql = "update HoaDonBan set Tongtien = (select sum(thanhTien) from CTHDBan where MaHD = '" + MaHD + "' group by MaHD) where MaHDBan = '" + MaHD + "'";


                if (q.capNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            if (flag == 3)
            {
                sql = "update HoaDonBan set trangthai = 4 where MaHDBan ='"+txtMaHDBan.Text+"' update CTHDBan set trangthai = 1 where MaHD ='"+txtMaHDBan.Text+"'";
                string tenChucNang = "xóa";
                DialogResult luu;
                luu = MessageBox.Show("Bạn có muốn " + tenChucNang, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (luu == DialogResult.Yes)
                {
                    if (q.capNhatDuLieu(sql) > 0)
                    {

                        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //vitri = 0;
                        frmHoaDonBan_Load(sender, e);
                        dgvDanhSachHD.Columns.Clear();
                        dgvDanhSachCTHD.Columns.Clear();

                    }
                }
                
            }

            frmHoaDonBan_Load(sender, e);
            xuly_Rad(false);
            flag = 0;
            tongtien = 0;
            
        }


        // tinh khuyen mai


        void taoAnh_tuFileAnh(PictureBox pic, string filename)
        {  
            Bitmap a = new Bitmap(filename);
            pic.Image = a;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        
        }

        private void btnLoadHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("hinhanh_SanPham") + @"\";
            o.ShowDialog();
            string tenfile = o.FileName;          
            taoAnh_tuFileAnh(picHinhAnh, tenfile);
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            //for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
            //{
            //    if (txtMaSP.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString())
            //    {
            //        if (radSizeM.Checked)
            //        {
            //            txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeM"].ToString();
            //        }
            //        if (radSizeL.Checked)
            //        {
            //            txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeL"].ToString();
            //        }
            //        if (radSizeXL.Checked)
            //        {
            //            txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeXL"].ToString();
            //        }
            //        txtTenSP.Text = dsSanPham.Tables[0].Rows[i]["TenSP"].ToString();
            //        string mahinh = dsSanPham.Tables[0].Rows[i]["MaHinh"].ToString();
            //        string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + mahinh;
            //        taoAnh_tuFileAnh(picHinhAnh, tenfile);      
            //    }
            //}
        }



        string phatsingMa()
        {
            string maNV = "";
            DataSet dsma = q.layDuLieu("select * from HoaDonBan");
            if (dsma.Tables[0].Rows.Count < 9)
            {
                maNV = "HDB0" + (dsma.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                maNV = "HDB" + (dsma.Tables[0].Rows.Count + 1).ToString();
            }
           
            return maNV;
            //maNV = "HD0" + (dsma.Tables[0].Rows.Count + 1).ToString();    
        }


        void xuly_KhiNhanRad(bool t)
        {
           txtGiaBan.Enabled= t;
           txtTenSP.Enabled= t;
           
        }

        private void radSizeM_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                xulyTextBox_CTHD(false);
                xuly_KhiNhanRad(false);
                txtMaSP_TextChanged(sender, e);
                txtSoLuong.ReadOnly = false;
            }


        }

        private void radSizeL_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                xulyTextBox_CTHD(false);
                xuly_KhiNhanRad(false);
                txtMaSP_TextChanged(sender, e);
                txtSoLuong.ReadOnly = false;
            }
        }

        private void radSizeXL_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                xulyTextBox_CTHD(false);
                xuly_KhiNhanRad(false);
                txtMaSP_TextChanged(sender, e);
                txtSoLuong.ReadOnly = false;
            }

        }

        void layGiaTri_Tu_KH()
        {
            frmKhachHang KH = new frmKhachHang(this);
            if (KH.ShowDialog() == DialogResult.OK)
            {
                txtPhoneKhach.Text = KH.laygiatri_sdt();
                txtTenKhach.Text =KH.laygiatri_ten();
            }
        }
       
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            layGiaTri_Tu_KH();
        }

       

        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //vitri = e.RowIndex;
            //hienthiLenTextBox(dsHoaDon, vitri);
            if (flag != 1)
            {
                vitri = e.RowIndex;      
                hienthiLenTextBox(dsHoaDon, vitri);
                hienthiLenTextBox2(dsChiTietHDB, vitri2, dsSanPham);

            }

          



            // danhsach_datagridview()
            //vitri = e.RowIndex;
            //if(vitri>=0 && vitri < dgvDanhSachHD.Rows.Count)
            //{
            //    string mahdb = dsHoaDon.Tables[0].Rows[vitri]["MaHDBan"].ToString();
            //    danhsach_datagridview(ref dsChiTietHDB, dgvDanhSachCTHD, $"select * from cthdban where MAHD='{mahdb}'");

            //}
        }

        void load_cthdtheoma(string mahd)
        {
            string sql = "select * from cthdban where MAHD = '" + mahd + "' and trangthai = 0";
            dsChiTietHDB = q.layDuLieu(sql);
            dgvDanhSachCTHD.DataSource = null;
            dgvDanhSachCTHD.Columns.Clear();
            dgvDanhSachCTHD.DataSource = dsChiTietHDB.Tables[0];
        }

        private void dgvDanhSachCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag != 1)
            {
                vitri2 = e.RowIndex;
                //hienthiLenTextBox(dsHoaDon, vitri);
                hienthiLenTextBox2(dsChiTietHDB, vitri2, dsSanPham);
                //hienthiLenTextBox(dsHoaDon, vitri, dsChiTietHDB, vitri2, dsSanPham);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
            {
                if (txtMaSP.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeM.Checked)
                {
                    txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeM"].ToString();

                    txtTenSP.Text = dsSanPham.Tables[0].Rows[i]["TenSP"].ToString();
                    string mahinh = dsSanPham.Tables[0].Rows[i]["MaHinh"].ToString();
                    string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + mahinh;
                    taoAnh_tuFileAnh(picHinhAnh, tenfile);

                }

                if (txtMaSP.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeL.Checked)
                {
                    txtTenSP.Text = dsSanPham.Tables[0].Rows[i]["TenSP"].ToString();

                    txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeL"].ToString();

                    string mahinh = dsSanPham.Tables[0].Rows[i]["MaHinh"].ToString();
                    string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + mahinh;
                    taoAnh_tuFileAnh(picHinhAnh, tenfile);

                }

                if (txtMaSP.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeXL.Checked)
                {

                    txtTenSP.Text = dsSanPham.Tables[0].Rows[i]["TenSP"].ToString();

                    txtGiaBan.Text = dsSanPham.Tables[0].Rows[i]["GiaSizeXL"].ToString();


                    string mahinh = dsSanPham.Tables[0].Rows[i]["MaHinh"].ToString();
                    string tenfile = Path.GetFullPath("hinhanh_SanPham") + @"\" + mahinh;
                    taoAnh_tuFileAnh(picHinhAnh, tenfile);

                }
               
            }
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (thoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvDanhSachCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
