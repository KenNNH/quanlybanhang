namespace _5_11_QuanLyBanh
{
    partial class frmTimKiemSanPham
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.cboCacLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.cboTimTheo = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(18, 25);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(1099, 302);
            this.dgvDanhSach.TabIndex = 2;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // cboCacLoaiTimKiem
            // 
            this.cboCacLoaiTimKiem.FormattingEnabled = true;
            this.cboCacLoaiTimKiem.Location = new System.Drawing.Point(159, 110);
            this.cboCacLoaiTimKiem.Name = "cboCacLoaiTimKiem";
            this.cboCacLoaiTimKiem.Size = new System.Drawing.Size(247, 28);
            this.cboCacLoaiTimKiem.TabIndex = 1;
            this.cboCacLoaiTimKiem.Visible = false;
            this.cboCacLoaiTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboCacLoaiTimKiem_SelectedIndexChanged);
            // 
            // cboTimTheo
            // 
            this.cboTimTheo.FormattingEnabled = true;
            this.cboTimTheo.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Loại sản phẩm",
            "Nhà cung cấp"});
            this.cboTimTheo.Location = new System.Drawing.Point(159, 43);
            this.cboTimTheo.Name = "cboTimTheo";
            this.cboTimTheo.Size = new System.Drawing.Size(247, 28);
            this.cboTimTheo.TabIndex = 1;
            this.cboTimTheo.SelectedIndexChanged += new System.EventHandler(this.cboTimTheo_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1198, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tìm Kiếm Theo Sản Phẩm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(966, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 48);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 349);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTimTheo);
            this.groupBox1.Controls.Add(this.cboCacLoaiTimKiem);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Location = new System.Drawing.Point(294, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(473, 110);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 39);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Image = global::_5_11_QuanLyBanh.Properties.Resources.seo;
            this.picHinhAnh.Location = new System.Drawing.Point(30, 122);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(210, 222);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 2;
            this.picHinhAnh.TabStop = false;
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1198, 745);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTimKiemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTimKiemSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.ComboBox cboCacLoaiTimKiem;
        private System.Windows.Forms.ComboBox cboTimTheo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnHuy;
    }
}