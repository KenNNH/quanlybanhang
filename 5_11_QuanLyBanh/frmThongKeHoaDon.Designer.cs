namespace _5_11_QuanLyBanh
{
    partial class frmThongKeHoaDon
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
            this.dgvDanhSachThongKe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNgayLast = new System.Windows.Forms.DateTimePicker();
            this.dateNgayFirst = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThongKe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachThongKe
            // 
            this.dgvDanhSachThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThongKe.Location = new System.Drawing.Point(19, 36);
            this.dgvDanhSachThongKe.Name = "dgvDanhSachThongKe";
            this.dgvDanhSachThongKe.RowHeadersWidth = 62;
            this.dgvDanhSachThongKe.RowTemplate.Height = 28;
            this.dgvDanhSachThongKe.Size = new System.Drawing.Size(1232, 339);
            this.dgvDanhSachThongKe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachThongKe);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(445, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 49);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(937, 711);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1296, 105);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thống Kê Hóa Đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNgayLast
            // 
            this.dateNgayLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLast.Location = new System.Drawing.Point(305, 223);
            this.dateNgayLast.Name = "dateNgayLast";
            this.dateNgayLast.Size = new System.Drawing.Size(248, 26);
            this.dateNgayLast.TabIndex = 4;
            // 
            // dateNgayFirst
            // 
            this.dateNgayFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayFirst.Location = new System.Drawing.Point(305, 144);
            this.dateNgayFirst.Name = "dateNgayFirst";
            this.dateNgayFirst.Size = new System.Drawing.Size(248, 26);
            this.dateNgayFirst.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đến ngày";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(1009, 212);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(130, 42);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 786);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateNgayFirst);
            this.Controls.Add(this.dateNgayLast);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeHoaDon";
            this.Text = "frmThongKeHoaDon";
            this.Load += new System.EventHandler(this.frmThongKeHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThongKe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNgayLast;
        private System.Windows.Forms.DateTimePicker dateNgayFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTim;
    }
}