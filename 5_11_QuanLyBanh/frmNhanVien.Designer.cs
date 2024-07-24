namespace _5_11_QuanLyBanh
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDSNV = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNhanVien = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.radTimKiem = new System.Windows.Forms.RadioButton();
            this.cboHienThiTimTheo = new System.Windows.Forms.ComboBox();
            this.cboTimTheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.grpChucNang.SuspendLayout();
            this.grpDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1529, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThoat);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.Location = new System.Drawing.Point(27, 712);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(1144, 117);
            this.grpChucNang.TabIndex = 0;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(961, 42);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 56);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(773, 40);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 58);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(224, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 56);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(590, 40);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(142, 56);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(404, 40);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 56);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(44, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 56);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpDSNV
            // 
            this.grpDSNV.Controls.Add(this.dgvDanhSach);
            this.grpDSNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDSNV.Location = new System.Drawing.Point(27, 393);
            this.grpDSNV.Name = "grpDSNV";
            this.grpDSNV.Size = new System.Drawing.Size(1479, 313);
            this.grpDSNV.TabIndex = 3;
            this.grpDSNV.TabStop = false;
            this.grpDSNV.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.Phone,
            this.TrangThai});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 29);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(1453, 269);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            this.dgvDanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellValueChanged);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Hoten";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "Phai";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện thoại";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "trangthai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.Controls.Add(this.picHinhAnh);
            this.grpNhanVien.Controls.Add(this.dateTimePicker1);
            this.grpNhanVien.Controls.Add(this.cboGioiTinh);
            this.grpNhanVien.Controls.Add(this.cboTrangThai);
            this.grpNhanVien.Controls.Add(this.lblTrangThai);
            this.grpNhanVien.Controls.Add(this.lblDienThoai);
            this.grpNhanVien.Controls.Add(this.lblDiachi);
            this.grpNhanVien.Controls.Add(this.lblNgaySinh);
            this.grpNhanVien.Controls.Add(this.lblGioiTinh);
            this.grpNhanVien.Controls.Add(this.txtTenNV);
            this.grpNhanVien.Controls.Add(this.lblTenNhanVien);
            this.grpNhanVien.Controls.Add(this.txtDiaChi);
            this.grpNhanVien.Controls.Add(this.txtPhone);
            this.grpNhanVien.Controls.Add(this.txtMaNV);
            this.grpNhanVien.Controls.Add(this.lblMaNV);
            this.grpNhanVien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhanVien.Location = new System.Drawing.Point(27, 103);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.Size = new System.Drawing.Size(1086, 269);
            this.grpNhanVien.TabIndex = 1;
            this.grpNhanVien.TabStop = false;
            this.grpNhanVien.Text = "Nhân viên";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(454, 138);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(243, 31);
            this.cboGioiTinh.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Ngưng hoạt động"});
            this.cboTrangThai.Location = new System.Drawing.Point(839, 145);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(230, 31);
            this.cboTrangThai.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Location = new System.Drawing.Point(713, 138);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(111, 37);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Location = new System.Drawing.Point(713, 89);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(118, 37);
            this.lblDienThoai.TabIndex = 0;
            this.lblDienThoai.Text = "Điện thoại";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiachi
            // 
            this.lblDiachi.Location = new System.Drawing.Point(713, 44);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(107, 37);
            this.lblDiachi.TabIndex = 0;
            this.lblDiachi.Text = "Địa chỉ";
            this.lblDiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(313, 191);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(104, 37);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(313, 138);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(103, 37);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(454, 89);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(243, 33);
            this.txtTenNV.TabIndex = 0;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Location = new System.Drawing.Point(307, 89);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(135, 37);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            this.lblTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(839, 44);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(839, 89);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(230, 33);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(454, 44);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(243, 30);
            this.txtMaNV.TabIndex = 0;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(313, 44);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(129, 37);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyTimKiem);
            this.groupBox1.Controls.Add(this.radTimKiem);
            this.groupBox1.Controls.Add(this.cboHienThiTimTheo);
            this.groupBox1.Controls.Add(this.cboTimTheo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1131, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.Location = new System.Drawing.Point(255, 47);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(100, 37);
            this.btnHuyTimKiem.TabIndex = 3;
            this.btnHuyTimKiem.Text = "Hủy";
            this.btnHuyTimKiem.UseVisualStyleBackColor = true;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // radTimKiem
            // 
            this.radTimKiem.AutoSize = true;
            this.radTimKiem.Location = new System.Drawing.Point(29, 53);
            this.radTimKiem.Name = "radTimKiem";
            this.radTimKiem.Size = new System.Drawing.Size(206, 24);
            this.radTimKiem.TabIndex = 2;
            this.radTimKiem.TabStop = true;
            this.radTimKiem.Text = "Nhấn vào để tìm kiếm";
            this.radTimKiem.UseVisualStyleBackColor = true;
            this.radTimKiem.CheckedChanged += new System.EventHandler(this.radTimKiem_CheckedChanged);
            // 
            // cboHienThiTimTheo
            // 
            this.cboHienThiTimTheo.FormattingEnabled = true;
            this.cboHienThiTimTheo.Location = new System.Drawing.Point(176, 185);
            this.cboHienThiTimTheo.Name = "cboHienThiTimTheo";
            this.cboHienThiTimTheo.Size = new System.Drawing.Size(179, 28);
            this.cboHienThiTimTheo.TabIndex = 1;
            this.cboHienThiTimTheo.SelectedIndexChanged += new System.EventHandler(this.cboHienThiTimTheo_SelectedIndexChanged);
            // 
            // cboTimTheo
            // 
            this.cboTimTheo.FormattingEnabled = true;
            this.cboTimTheo.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cboTimTheo.Location = new System.Drawing.Point(176, 129);
            this.cboTimTheo.Name = "cboTimTheo";
            this.cboTimTheo.Size = new System.Drawing.Size(179, 28);
            this.cboTimTheo.TabIndex = 1;
            this.cboTimTheo.SelectedIndexChanged += new System.EventHandler(this.cboTimTheo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.ErrorImage = null;
            this.picHinhAnh.Image = global::_5_11_QuanLyBanh.Properties.Resources.staff;
            this.picHinhAnh.Location = new System.Drawing.Point(44, 42);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(194, 207);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 7;
            this.picHinhAnh.TabStop = false;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 841);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDSNV);
            this.Controls.Add(this.grpNhanVien);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.grpChucNang.ResumeLayout(false);
            this.grpDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpNhanVien.ResumeLayout(false);
            this.grpNhanVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpDSNV;
        private System.Windows.Forms.GroupBox grpNhanVien;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTimTheo;
        private System.Windows.Forms.ComboBox cboHienThiTimTheo;
        private System.Windows.Forms.RadioButton radTimKiem;
        private System.Windows.Forms.Button btnHuyTimKiem;
        private System.Windows.Forms.PictureBox picHinhAnh;
    }
}