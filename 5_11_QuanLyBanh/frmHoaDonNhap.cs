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
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        quanlybanBanh q = new quanlybanBanh();
        DataSet dsHoanDonNhap = new DataSet();
        DataSet dsNhaCC = new DataSet();
        DataSet dsNhanVien = new DataSet();
        DataSet dsChiTietHoaDonN = new DataSet();
        DataSet dsSanPham = new DataSet();

        int vitri = 0;
        Boolean f = false;
        int flag = 0;
        int vitri2 = 0;

        void danhsach_datagriview(DataGridView dgv , string sql)
        {
            dsHoanDonNhap = q.layDuLieu(sql);
            dgv.DataSource = dsHoanDonNhap.Tables[0];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            //xuly_textbox(false);
            xuLyTextBox_HD(false);
            xulyenabled(false);
            btnLuu.Enabled = false;
            btnThem_CTHDN.Visible= true;
            txtMaSP_CTHD.Text = "";
            txtMaHDNhap.Text = phatsinhMa_2();
            
            taoCotHDNhap();
            taoCotCTHD();
            dgvDanhSachHDNhap.DataSource = null;
            dgvDanhSach_CTHDNhap.DataSource = null;

            xoadulieuHD();
            xoadulieuCTHD();
            
            flag = 1;
        }

        private void dgvDanhSachHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(flag!=1)
           {
                vitri = e.RowIndex;
                hienthiLenTextBox(dsHoanDonNhap, vitri);// dgvhoadonnhap
                hienthiLenTextBox2(dsChiTietHoaDonN, vitri2, dsSanPham);// dgvcthdnhap
           }    
                
        }
        void load_cthdntheoma(string mahdn)
        {
            string sql = "select * from CTHDNhap where MaHDNhap = '" + mahdn + "' and trangthai=0 ";
            dsChiTietHoaDonN = q.layDuLieu(sql);
            dgvDanhSach_CTHDNhap.DataSource = null;
            dgvDanhSach_CTHDNhap.Columns.Clear();
            dgvDanhSach_CTHDNhap.DataSource = dsChiTietHoaDonN.Tables[0];
        }
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        void xulyenabled(Boolean t)
        {
            txtMaHDNhap.Enabled = !t;
            cboMaNCC.Enabled = !t;
            cboMaNV.Enabled= !t;
            cboTrangThai.Enabled = !t;
            dateHDNhap.Enabled = !t;
            lblTongTien.Enabled = !t;
            cboTrangThai.Enabled= !t;
            txtMaSP_CTHD.Enabled= !t;
            txtSoLuong_CTHDN.Enabled= !t;
            lblDonGia_CTHDN.Enabled= !t;
            lblThanhTien_CTHDN.Enabled= !t;
        }
        void xoadulieuHD()
        {
            //txtMaHDNhap.Clear();
            cboMaNCC.SelectedIndex= -1;
            cboMaNV.SelectedIndex= -1;
            lblTongTien.Text="";    
            cboTrangThai.SelectedIndex= -1;
        }
        void xoadulieuCTHD()
        {
            //cboMaSP_CTHDN.SelectedIndex = -1;
            lblDonGia_CTHDN.Text = " ";
            txtSoLuong_CTHDN.Clear();
            lblThanhTien_CTHDN.Text ="";
        }

        void xuly_them()
        {
            txtMaHDNhap.Text = "";
            cboMaNCC.SelectedIndex = -1;
            cboMaNV.SelectedIndex = -1;
            dateHDNhap.Value = DateTime.Now;
            lblTongTien.Text = "";
            cboTrangThai.SelectedIndex= -1;

            txtMaSP_CTHD.Text = "";
            txtSoLuong_CTHDN.Text = "";
            lblDonGia_CTHDN.Text= "";
            lblThanhTien_CTHDN.Text = "";

        }
        void hienthiLenTextBox(DataSet ds, int vt)
        {
            if (ds.Tables[0].Rows.Count > vt && vt > -1)
            {
                txtMaHDNhap.Text = ds.Tables[0].Rows[vt]["MaHDNhap"].ToString();
                cboMaNCC.SelectedValue = ds.Tables[0].Rows[vt]["MaNCC"].ToString();
                cboMaNV.SelectedValue = ds.Tables[0].Rows[vt]["MaNV"].ToString();
                dateHDNhap.Text = ds.Tables[0].Rows[vt]["NgayNhap"].ToString();
                lblTongTien.Text = ds.Tables[0].Rows[vt]["TongTien"].ToString();// tổng tiền

                string trangthai = ds.Tables[0].Rows[vt]["TrangThai"].ToString();
                if (trangthai == "0")
                {
                    cboTrangThai.Text = "Hoạt động";
                }
                else
                {
                    cboTrangThai.Text = " Ngưng hoạt động";
                }
                load_cthdntheoma(ds.Tables[0].Rows[vt]["MaHDNhap"].ToString());

            }
        }

        string tensize_click = "";
        void hienthiLenTextBox2(DataSet ds2, int vt, DataSet ds1)
        {
            if (ds2.Tables[0].Rows.Count > vt && vt > -1)
            {
                for(int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    if (ds2.Tables[0].Rows[vt]["MaSP"].ToString() == ds1.Tables[0].Rows[i]["MaSP"].ToString())
                    {
                        txtMaSP_CTHD.Text = ds2.Tables[0].Rows[vt]["MaSP"].ToString();
                        txtSoLuong_CTHDN.Text = ds2.Tables[0].Rows[vt]["SoLuong"].ToString();
                        lblDonGia_CTHDN.Text = ds2.Tables[0].Rows[vt]["DonGia"].ToString();
                        lblThanhTien_CTHDN.Text = ds2.Tables[0].Rows[vt]["thanhTien"].ToString();

                        // ktr size
                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim() == "M")
                        {
                            radSizeM.Checked = true;
                            tensize_click = "M";
                            xulyTextBox_CTHD(false);
                            if(flag == 2)
                            {
                                txtSoLuong_CTHDN.ReadOnly = false;
                            }    
                        }

                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim() == "L")
                        {
                            radSizeL.Checked = true;
                            tensize_click = "L";
                            xulyTextBox_CTHD(false);
                            if (flag == 2)
                            {
                                txtSoLuong_CTHDN.ReadOnly = false;
                            }
                        }

                        if (ds2.Tables[0].Rows[vt]["size"].ToString().Trim() == "XL")
                        {
                            radSizeXL.Checked = true;
                            tensize_click = "XL";
                            xulyTextBox_CTHD(false);
                            if (flag == 2)
                            {
                                txtSoLuong_CTHDN.ReadOnly = false;
                            }
                        }
                    }    
                }    
                
            }
        }
        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
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
        string phatsinhMa_2()
        {
            string MaHDNhap = "";
            DataSet dsmau = q.layDuLieu("select MaHDNhap from HoaDonNhap");
            MaHDNhap = "HDN0" + (dsmau.Tables[0].Rows.Count + 1).ToString();
            return MaHDNhap;
        }

        void xuly_textbox(Boolean t)
        {
            txtMaHDNhap.ReadOnly = t;
            //txtMaNV.ReadOnly = t;
            //dateHDNhap.ReadOnly = t;
            //lblTongTien.ReadOnly = t;
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            btnThem_CTHDN.Visible = false;
            xuLyChucNang(true);
            xuLyTextBox_HD(true);
            xuLyTextBox_HD(true);
            xulyenabled(true);

            danhsach_datagriview(dgvDanhSachHDNhap, "select * from HoaDonNhap where trangthai=0");
            dsNhaCC = q.layDuLieu("select * from NhaCungCap");
            hienThiComboBox(cboMaNCC, dsNhaCC, "TenNCC", "MaNCC");
            dsNhanVien = q.layDuLieu("select * from NhanVien");
            hienThiComboBox(cboMaNV, dsNhanVien, "TenNV", "MaNV");

            dsSanPham = q.layDuLieu("select * from SanPham");
            //hienThiComboBox(//cboMaSP_CTHDN, dsSanPham, "TenSP", "MaSP");

            hienthiLenTextBox(dsHoanDonNhap, vitri);
            hienthiLenTextBox2(dsChiTietHoaDonN, vitri2, dsSanPham);
            
            f = true;
        }

        void taoCotCTHD()
        {
            dgvDanhSach_CTHDNhap.Columns.Clear();
            dgvDanhSach_CTHDNhap.Columns.Add("MaHDNhap", "Mã Hóa Đơn Nhập");
            dgvDanhSach_CTHDNhap.Columns.Add("MaSP", "Mã Sản Phẩm");
            dgvDanhSach_CTHDNhap.Columns.Add("SoLuong", "Số Lượng");
            dgvDanhSach_CTHDNhap.Columns.Add("ĐonGia", "Đơn Giá");
            dgvDanhSach_CTHDNhap.Columns.Add("thanhTien", "Thành Tiền");
            dgvDanhSach_CTHDNhap.Columns.Add("size", "Size");
            dgvDanhSach_CTHDNhap.Columns.Add("trangthai", "Trạng thái");

        }

        void taoCotHDNhap()
        {
            dgvDanhSachHDNhap.Columns.Clear();
            dgvDanhSachHDNhap.Columns.Add("MaHDNhap", "Mã Hóa Đơn Nhập");
            dgvDanhSachHDNhap.Columns.Add("MaNCC", "Mã Nhà Cung Cấp");
            dgvDanhSachHDNhap.Columns.Add("MaNV", "Mã Nhân Viên");
            dgvDanhSachHDNhap.Columns.Add("NgayNhap", "Ngày Nhập");
            dgvDanhSachHDNhap.Columns.Add("TongTien", "Tổng Tiền");
            dgvDanhSachHDNhap.Columns.Add("trangthai", "Trạng thái");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuly_textbox(false);
            txtSoLuong_CTHDN.Enabled= true;
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            flag = 3;
        }

        private void txtSoLuong_CTHDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float ketqua = 0;
                    int soluong = int.Parse(txtSoLuong_CTHDN.Text);
                    float dongia = float.Parse(lblDonGia_CTHDN.Text);
                    ketqua = soluong * dongia;
                    lblThanhTien_CTHDN.Text = ketqua.ToString();
                }
                catch { 
                    MessageBox.Show("vui lòng nhập số lượng",
                        "Cofrm",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }
        }
        bool xuly_chucnangnhapText()
        {
            if(txtMaHDNhap.Text==""|| cboMaNCC.Text==" "|| cboMaNV.Text==""|| cboTrangThai.Text=="")
            {
                return true;
            }    
            return false;
        }
        private void btnThem_CTHDN_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            if(xuly_chucnangnhapText())
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
                return;
            }  
            
            
            object[] CTHD = new object[7];
            object[] HD = new object[6];
            long thanhtien = 0;
            string tensize = radSizeM.Checked ? "M" : radSizeL.Checked ? "L" : radSizeXL.Checked ? "XL" : "";
            if (xuly_CTHD(dgvDanhSach_CTHDNhap, tensize, thanhtien))
            {
                return;
            }

            CTHD[0] = txtMaHDNhap.Text;
            CTHD[1] = txtMaSP_CTHD.Text;
            CTHD[2] = txtSoLuong_CTHDN.Text;
            CTHD[3] = lblDonGia_CTHDN.Text;
            CTHD[4] = lblThanhTien_CTHDN.Text;
            CTHD[5] = tensize;
            CTHD[6] = '0';
            dgvDanhSach_CTHDNhap.Rows.Add(CTHD);

            HD[0] = txtMaHDNhap.Text;
            HD[1] = cboMaNCC.SelectedValue.ToString();
            HD[2] = cboMaNV.SelectedValue.ToString();
            HD[3] = dateHDNhap.Text;
            //HD[4] = txtTongTien.Text;
            //HD[4] = lblThanhTien_CTHDN.Text;
            thanhtien = int.Parse(txtSoLuong_CTHDN.Text) * long.Parse(lblDonGia_CTHDN.Text);
            HD[4] = thanhtien;
            tongtien += thanhtien;
            lblTongTien.Text = tongtien.ToString();
            HD[5] = '0';
            //dgvDanhSachHDNhap.Rows.Add(HD);

            if(xuly_HD(dgvDanhSachHDNhap))
            {
                return;
            }
            else
            {
                dgvDanhSachHDNhap.Rows.Add(HD);
            }
        }

        void xuly_rad(bool t)
        {
            radSizeM.Checked = t;
            radSizeL.Checked = t;
            radSizeXL.Checked = t;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuly_textbox(true);
            string sql = " ";
           
            if (flag == 1)
            {
                int dem_capnhat = 0;
                string mahdnhap = txtMaHDNhap.Text;
                string mancc = cboMaNCC.SelectedValue.ToString();
                string manv = cboMaNV.SelectedValue.ToString();
                string ngaynhap = dateHDNhap.Text;
                string tongtien = lblTongTien.Text;
                string trangthai = cboTrangThai.SelectedIndex.ToString();
                sql = "insert into HoaDonNhap values('" + mahdnhap + "','" + mancc + "','" + manv + "'," + ngaynhap + "," + tongtien + "," + trangthai + ")";
                if (q.capNhatDuLieu(sql)>0)
                {
                    for(int i =0 ; i < dgvDanhSach_CTHDNhap.Rows.Count-1;i++)
                    {
                        string MaHDNhap = dgvDanhSach_CTHDNhap.Rows[i].Cells[0].Value.ToString(); 
                        string MaSP = dgvDanhSach_CTHDNhap.Rows[i].Cells[1].Value.ToString();
                        string SoLuong = dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString();
                        string DonGia = dgvDanhSach_CTHDNhap.Rows[i].Cells[3].Value.ToString();
                        string thanhTien = dgvDanhSach_CTHDNhap.Rows[i].Cells[4].Value.ToString();
                        string Size = dgvDanhSach_CTHDNhap.Rows[i].Cells[5].Value.ToString();
                        string trangthai1 = "0";
                        sql = "insert into CTHDNhap values('"+MaHDNhap+"','"+MaSP+"',"+SoLuong+","+DonGia+","+thanhTien+",'"+Size+"',"+trangthai1+")";
                        if(q.capNhatDuLieu(sql)>0)
                        {
                            dem_capnhat++;
                        }
                        if (dgvDanhSach_CTHDNhap.Rows[i].Cells[5].Value.ToString()=="M")
                        {
                            string sql_SoLuongNhap = "update SanPham set SoLuongM = SoLuongM + " + dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString() + " where MaSP ='" + dgvDanhSach_CTHDNhap.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongNhap);
                        }

                        if (dgvDanhSach_CTHDNhap.Rows[i].Cells[5].Value.ToString() == "L")
                        {
                            string sql_SoLuongNhap = "update SanPham set SoLuongL = SoLuongL + " + dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString() + " where MaSP ='" + dgvDanhSach_CTHDNhap.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongNhap);
                        }

                        if (dgvDanhSach_CTHDNhap.Rows[i].Cells[5].Value.ToString() == "XL")
                        {
                            string sql_SoLuongNhap = "update SanPham set SoLuongXL = SoLuongXL + " + dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString() + " where MaSP ='" + dgvDanhSach_CTHDNhap.Rows[i].Cells[1].Value.ToString() + "'";
                            q.capNhatDuLieu(sql_SoLuongNhap);// tăng
                        }
                    }    
                }   
                if(dem_capnhat !=0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhSach_CTHDNhap.Columns.Clear();
                    dgvDanhSachHDNhap.Columns.Clear();
                    xuly_them();
                } 
                frmHoaDonNhap_Load(sender, e);
            }

            if (flag == 2)
            {
                string sql_capnhatSoluong = "";
                int soluongnhap_sua = int.Parse(txtSoLuong_CTHDN.Text);
                string MaHDNhap = txtMaHDNhap.Text;
                string MaSP = txtMaSP_CTHD.Text;

                int soluong_dangtrongcot_cthdnhap = 0;

                for(int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
                {
                    for(int j = 0; j < dgvDanhSach_CTHDNhap.Rows.Count-1;j++)
                    {
                        if (dsSanPham.Tables[0].Rows[i]["MaSP"].ToString()== MaSP)
                        {
                            int soluong_hienco = 0;
                            if(tensize_click == "M")
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
                            if(dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() == MaSP && dgvDanhSach_CTHDNhap.Rows[j].Cells[5].Value.ToString().Trim() == tensize_click)
                            {
                                soluong_dangtrongcot_cthdnhap = int.Parse(dgvDanhSach_CTHDNhap.Rows[j].Cells[2].Value.ToString());
                            }    
                           

                            //if(soluong_hienco >= soluongnhap_sua)
                            //{
                                string sql_soluongnhap_sua = "";
                                sql_soluongnhap_sua = "update CTHDNhap set SoLuong = '" + soluongnhap_sua + "' where MaHDNhap = '"+MaHDNhap+"'and MaSP = '"+MaSP+"' and size = '"+tensize_click+ "'";
                                q.capNhatDuLieu(sql_soluongnhap_sua);

                                if(tensize_click == "M")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongM = SoLuongM - " + soluong_dangtrongcot_cthdnhap + "+" + soluongnhap_sua + " where MaSP = '" + MaSP + "'";
                                }

                                if (tensize_click == "L")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongL = SoLuongL - " + soluong_dangtrongcot_cthdnhap + "+" + soluongnhap_sua + " where MaSP = '" + MaSP + "'";
                                }

                                if (tensize_click == "XL")
                                {
                                    sql_capnhatSoluong = "update SanPham set SoLuongXL = SoLuongXL - " + soluong_dangtrongcot_cthdnhap + "+" + soluongnhap_sua + " where MaSP = '" + MaSP + "'";
                                }
                                
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Số lượng không đủ","Cofrm",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //    return;
                            //}
                        }    
                    }    
                }
                q.capNhatDuLieu(sql_capnhatSoluong);
                string sql_thanhTien = "update CTHDNhap set thanhTien = (SoLuong * DonGia) where MaHDNhap = '" + MaHDNhap + "' and MaSP='" + MaSP + "' and size = '" + tensize_click + "'";
                q.capNhatDuLieu(sql_thanhTien);

                sql = "update HoaDonNhap set Tongtien = (select sum (thanhTien) from CTHDNhap where MaHDNhap = '" + MaHDNhap + "' group by MaHDNhap) where MaHDNhap = '" + MaHDNhap + "'";

                if(q.capNhatDuLieu(sql)>0)
                {
                    MessageBox.Show("Cập nhật thành công", "Cofrm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
           

            if(flag == 3)
            {
                sql = "update HoaDonNhap set trangthai = 1 where MaHDNhap='" + txtMaHDNhap.Text+"' update CTHDNhap set trangthai = 1 where MaHDNhap='"+txtMaHDNhap.Text+"'";
                string tenChucNang = " xóa";
                DialogResult luu;
                luu = MessageBox.Show("Bạn có muốn"+tenChucNang,"Cofrm",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if(luu == DialogResult.Yes)
                {
                    if(q.capNhatDuLieu(sql)>0)
                    {
                        MessageBox.Show("Cập nhật thành công","Cofrm",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmHoaDonNhap_Load(sender , e);
                        dgvDanhSachHDNhap.Columns.Clear();
                        dgvDanhSach_CTHDNhap.Columns.Clear();
                    }
                }    
            }
            xuly_rad(false);
            frmHoaDonNhap_Load(sender, e);

            flag = 0;
        }
        bool xuly_HD(DataGridView dgv)
        {
            for (int j = 0; j < dgv.Rows.Count - 1; j++)
            {
                if (dgv.Rows[j].Cells[0].Value.ToString() == txtMaHDNhap.Text)// +"." + phone_makh
                {
                    dgv.Rows[j].Cells[4].Value = lblTongTien.Text;
                    //dgvDanhSachHD.Rows.Add(HD);
                    return true;
                }

            }
            return false;
        }
        long tongtien=0;
        bool xuly_CTHD(DataGridView dgv, string tensize, float thanhtien)
        {
            for (int i = 0; i < dgvDanhSach_CTHDNhap.Rows.Count - 1; i++)
            {

                if (dgvDanhSach_CTHDNhap.Rows[i].Cells[1].Value.ToString() == txtMaSP_CTHD.Text && dgvDanhSach_CTHDNhap.Rows[i].Cells[5].Value.ToString() == tensize) //dgvDanhSachCTHD.Rows[i].Cells[0].Value.ToString() == txtMaHDBan.Text + "." + txtMaSP.Text + "." + tensize && dgvDanhSachCTHD.Rows[i].Cells[1].Value.ToString() == txtMaSP.Text && 
                {
                    //tang so luong

                    int soluong = int.Parse(dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString());
                    soluong += int.Parse(txtSoLuong_CTHDN.Text);
                    dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value = soluong;


                    

                    thanhtien = (soluong * float.Parse(dgvDanhSach_CTHDNhap.Rows[i].Cells[3].Value.ToString()));

                    dgvDanhSach_CTHDNhap.Rows[i].Cells[4].Value = thanhtien;


                    //tang tong tien

                    tongtien += (int.Parse(txtSoLuong_CTHDN.Text) * long.Parse(lblDonGia_CTHDN.Text));

                   

                   lblTongTien.Text = tongtien.ToString();            

                    xuly_HD(dgvDanhSachHDNhap);
                    return true;

                }

            }
            return false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvDanhSachHDNhap.Columns.Clear();
            dgvDanhSach_CTHDNhap.Columns.Clear();
            radSizeM.Checked= false;
            radSizeL.Checked = false;
            radSizeXL.Checked = false;
            frmHoaDonNhap_Load(sender , e);
        }

        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát chương trình", "Cofrm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvDanhSach_CTHDNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(f)
            {
                if(flag==2)
                {
                    if(e.ColumnIndex== 2)
                    {
                        int tongsL = 0;
                        for(int i = 0; i< dgvDanhSach_CTHDNhap.Rows.Count-1; i++)
                        {
                            tongsL += int.Parse(dgvDanhSach_CTHDNhap.Rows[i].Cells[2].Value.ToString());
                        }
                        txtSoLuong_CTHDN.Text = tongsL.ToString();
                    }
                }    
            }    
        }

        private void txtSoLuong_CTHDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CTHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(flag != 1)
            {
                vitri2 = e.RowIndex;
                hienthiLenTextBox2(dsChiTietHoaDonN, vitri2, dsSanPham);
            }    
        }

        private void txtMaSP_CTHD_KeyDown(object sender, KeyEventArgs e)
        {
            //for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
            //{
            //    if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeM.Checked)
            //    {
            //        txtDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["DonGia"].ToString();

            //    }

            //    if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeL.Checked)
            //    {
            //        txtDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["DonGia"].ToString();
            //    }

            //    if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeXL.Checked)
            //    {
            //        txtDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["DonGia"].ToString();
            //    }
            //}
        }

        
        void xulyTextBox_CTHD(bool t)
        {
            txtMaSP_CTHD.ReadOnly= t;
            txtSoLuong_CTHDN.ReadOnly= t;
            //txtDonGia_CTHDN.ReadOnly= t;
            //lblThanhTien_CTHDN.ReadOnly = t;
            
        }
        void xuLyTextBox_HD(bool t)
        {
            txtMaHDNhap.ReadOnly= t;
            //cboMaNCC.Enabled= t;
            //cboMaNV.Enabled= t;
            dateHDNhap.Enabled = !t;
            //txtTongTien.ReadOnly= t;

            radSizeM.Enabled = !t;
            radSizeL.Enabled = !t;
            radSizeXL.Enabled = !t;


        }


        private void radSizeM_CheckedChanged_1(object sender, EventArgs e)
        {
           if(flag ==1)
           {
                xulyTextBox_CTHD(false);
                txtMaSP_CTHD_TextChanged(sender, e);
                txtSoLuong_CTHDN.ReadOnly = false;
           }    
                
           

        }

        private void radSizeL_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                xulyTextBox_CTHD(false);
                txtMaSP_CTHD_TextChanged(sender, e);
                txtSoLuong_CTHDN.ReadOnly = false;
            }
        }

        private void radSizeXL_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                xulyTextBox_CTHD(false);
                txtMaSP_CTHD_TextChanged(sender, e);
                txtSoLuong_CTHDN.ReadOnly = false;
            }
        }

        private void txtMaSP_CTHD_TextChanged(object sender, EventArgs e)
        {
            // don gia theo giá bán của sản phẩm

            for (int i = 0; i < dsSanPham.Tables[0].Rows.Count; i++)
            {
                if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeM.Checked)
                {
                    lblDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["GiaNhap"].ToString();

                }

                if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeL.Checked)
                {
                    lblDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["GiaNhap"].ToString();
                }

                if (txtMaSP_CTHD.Text == dsSanPham.Tables[0].Rows[i]["MaSP"].ToString() && radSizeXL.Checked)
                {
                    lblDonGia_CTHDN.Text = dsSanPham.Tables[0].Rows[i]["GiaNhap"].ToString();
                }
            }
        }

        
        private void txtSoLuong_CTHDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("không được nhập kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
        
    }

