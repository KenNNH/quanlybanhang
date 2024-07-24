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
    public partial class frmThongKeHoaDon : Form
    {
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }

        quanlybanBanh q = new quanlybanBanh();

        DataSet dsHoaDon = new DataSet();
        void danhsach_datagridview2(DataGridView dgv, string sql)
        {
            dsHoaDon = q.layDuLieu(sql);
            dgv.DataSource = dsHoaDon.Tables[0];

        }
        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //if(dateNgayFirst.Value >) { }
            
            string sql = "select * from HoaDonBan where NgayLapHD <= '"+dateNgayFirst.Text+"' and NgayLapHD >= '"+dateNgayLast.Text+"'";

            danhsach_datagridview2(dgvDanhSachThongKe, sql);

        }
    }
}
