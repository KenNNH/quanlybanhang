namespace _5_11_QuanLyBanh
{
    partial class frmSanPham
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltenhinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadHinh = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongM = new System.Windows.Forms.TextBox();
            this.txtSoLuongXL = new System.Windows.Forms.TextBox();
            this.txtSoLuongL = new System.Windows.Forms.TextBox();
            this.txtGiaXL = new System.Windows.Forms.TextBox();
            this.txtGiaL = new System.Windows.Forms.TextBox();
            this.txtGiaM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTenML = new System.Windows.Forms.ComboBox();
            this.cboTenNCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(19, 25);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(1353, 246);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picHinhAnh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxtMoTa);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbltenhinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLoadHinh);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtSoLuongM);
            this.groupBox1.Controls.Add(this.txtSoLuongXL);
            this.groupBox1.Controls.Add(this.txtSoLuongL);
            this.groupBox1.Controls.Add(this.txtGiaXL);
            this.groupBox1.Controls.Add(this.txtGiaL);
            this.groupBox1.Controls.Add(this.txtGiaM);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTenML);
            this.groupBox1.Controls.Add(this.cboTenNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1412, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(1088, 87);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(290, 276);
            this.picHinhAnh.TabIndex = 11;
            this.picHinhAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên loại sản phẩm";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(685, 284);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(259, 141);
            this.rtxtMoTa.TabIndex = 6;
            this.rtxtMoTa.Text = "";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(1134, 390);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(213, 35);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Visible = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mô tả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "So luong XL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "So luong L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Giá size XL";
            // 
            // lbltenhinh
            // 
            this.lbltenhinh.AutoSize = true;
            this.lbltenhinh.Location = new System.Drawing.Point(994, 325);
            this.lbltenhinh.Name = "lbltenhinh";
            this.lbltenhinh.Size = new System.Drawing.Size(76, 25);
            this.lbltenhinh.TabIndex = 2;
            this.lbltenhinh.Text = "mahinh";
            this.lbltenhinh.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giá size M";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá size L";
            // 
            // btnLoadHinh
            // 
            this.btnLoadHinh.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoadHinh.Location = new System.Drawing.Point(1088, 26);
            this.btnLoadHinh.Name = "btnLoadHinh";
            this.btnLoadHinh.Size = new System.Drawing.Size(290, 57);
            this.btnLoadHinh.TabIndex = 7;
            this.btnLoadHinh.Text = "Hình đại diện";
            this.btnLoadHinh.UseVisualStyleBackColor = true;
            this.btnLoadHinh.Click += new System.EventHandler(this.btnLoadHinh_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(720, 56);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(225, 30);
            this.txtGiaNhap.TabIndex = 5;
            this.txtGiaNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiaNhap_KeyDown);
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // txtSoLuongM
            // 
            this.txtSoLuongM.Location = new System.Drawing.Point(272, 279);
            this.txtSoLuongM.Name = "txtSoLuongM";
            this.txtSoLuongM.Size = new System.Drawing.Size(225, 30);
            this.txtSoLuongM.TabIndex = 4;
            this.txtSoLuongM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtSoLuongXL
            // 
            this.txtSoLuongXL.Location = new System.Drawing.Point(272, 390);
            this.txtSoLuongXL.Name = "txtSoLuongXL";
            this.txtSoLuongXL.Size = new System.Drawing.Size(225, 30);
            this.txtSoLuongXL.TabIndex = 8;
            // 
            // txtSoLuongL
            // 
            this.txtSoLuongL.Location = new System.Drawing.Point(272, 335);
            this.txtSoLuongL.Name = "txtSoLuongL";
            this.txtSoLuongL.Size = new System.Drawing.Size(225, 30);
            this.txtSoLuongL.TabIndex = 8;
            // 
            // txtGiaXL
            // 
            this.txtGiaXL.Location = new System.Drawing.Point(719, 231);
            this.txtGiaXL.Name = "txtGiaXL";
            this.txtGiaXL.Size = new System.Drawing.Size(225, 30);
            this.txtGiaXL.TabIndex = 8;
            // 
            // txtGiaL
            // 
            this.txtGiaL.Location = new System.Drawing.Point(719, 170);
            this.txtGiaL.Name = "txtGiaL";
            this.txtGiaL.Size = new System.Drawing.Size(225, 30);
            this.txtGiaL.TabIndex = 7;
            // 
            // txtGiaM
            // 
            this.txtGiaM.Location = new System.Drawing.Point(719, 111);
            this.txtGiaM.Name = "txtGiaM";
            this.txtGiaM.Size = new System.Drawing.Size(225, 30);
            this.txtGiaM.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(272, 224);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(225, 30);
            this.txtTenSP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(272, 170);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(225, 30);
            this.txtMaSP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm";
            // 
            // cboTenML
            // 
            this.cboTenML.FormattingEnabled = true;
            this.cboTenML.Location = new System.Drawing.Point(272, 57);
            this.cboTenML.Name = "cboTenML";
            this.cboTenML.Size = new System.Drawing.Size(225, 33);
            this.cboTenML.TabIndex = 0;
            this.cboTenML.SelectedIndexChanged += new System.EventHandler(this.cboTenML_SelectedIndexChanged);
            // 
            // cboTenNCC
            // 
            this.cboTenNCC.FormattingEnabled = true;
            this.cboTenNCC.Location = new System.Drawing.Point(272, 116);
            this.cboTenNCC.Name = "cboTenNCC";
            this.cboTenNCC.Size = new System.Drawing.Size(225, 33);
            this.cboTenNCC.TabIndex = 1;
            this.cboTenNCC.SelectedIndexChanged += new System.EventHandler(this.cboTenNCC_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(39, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1412, 295);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1463, 64);
            this.label10.TabIndex = 7;
            this.label10.Text = "Danh   Sách   Sản   Phẩm";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(64, 862);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(246, 862);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(425, 862);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(599, 862);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 38);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1213, 855);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(204, 45);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(781, 862);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 38);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1038, 855);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 45);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 912);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiaM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaXL;
        private System.Windows.Forms.TextBox txtGiaL;
        private System.Windows.Forms.ComboBox cboTenML;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoLuongM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label lbltenhinh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoLuongXL;
        private System.Windows.Forms.TextBox txtSoLuongL;
    }
}