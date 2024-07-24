using DevExpress.Data.Filtering.Helpers;
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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }


        quanlybanBanh q = new quanlybanBanh();
        DataSet dsNhanVien = new DataSet();
       
        Boolean f = false;

        void danhsach_datagridview(DataGridView d, string sql)
        {
            dsNhanVien = q.layDuLieu(sql);
            d.DataSource = dsNhanVien.Tables[0];
        }

      
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai=0");
           
            cboHienThiTimTheo.Enabled= false;
           
            f = true;
        }

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
                if(cboTimTheo.SelectedIndex == 0) 
                {
                    dsNhanVien = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, dsNhanVien, "MaNV", "MaNV");
                }
                if(cboTimTheo.SelectedIndex == 1)
                {
                    dsNhanVien = q.layDuLieu("select * from NhanVien ");
                    hienThiComboBox(cboHienThiTimTheo, dsNhanVien, "HoTen", "MaNV");
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
                if(cboTimTheo.SelectedIndex == 0)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        dsNhanVien = q.layDuLieu(sql);
                        
                    }
                }
                if (cboTimTheo.SelectedIndex == 1)
                {
                    if (cboHienThiTimTheo.SelectedIndex != -1)
                    {
                        ma = cboHienThiTimTheo.SelectedValue.ToString();
                        sql = "select * from NhanVien where MaNV = '" + ma + "'";
                        dsNhanVien = q.layDuLieu(sql);
                        
                    }
                }

            }
            dgvDanhSach.DataSource = dsNhanVien.Tables[0];
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien_Load(sender, e);
            cboHienThiTimTheo.Text = "";
            cboTimTheo.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }









        //private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string ma = "";
        //    string sql = "";
        //    if (f)
        //    {            
        //          if (cboTimTheo.SelectedIndex != -1)
        //          {
        //              ma = cboTimTheo.SelectedValue.ToString();
        //              sql = "select * from NhanVien where MaNV = '" + ma + "'";
        //              dsNhanVien = q.layDuLieu(sql);
        //              dgvDanhSach.DataSource = dsNhanVien.Tables[0];
        //          }

        //    }

        //}



        //private void cboTenNV_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string ma = "";
        //    string sql = "";
        //    if (f)
        //    {             
        //          if (cboHienThiTimTheo.SelectedIndex != -1)
        //          {
        //              ma = cboHienThiTimTheo.SelectedValue.ToString();
        //              sql = "select * from NhanVien where MaNV = '" + ma + "'";
        //              dsNhanVien = q.layDuLieu(sql);
        //              dgvDanhSach.DataSource = dsNhanVien.Tables[0];
        //          }


        //    }

        //}

        //void timKiem_MaNV(RadioButton rad, DataGridView dgv, TextBox txt)
        //{
        //    if(rad.Checked)
        //    {

        //        ds.Tables[0].DefaultView.RowFilter = "MaNV='" + txt.Text+"'";
        //        //hoặc
        //       //ds.Tables[0].DefaultView.RowFilter = string.Format("[MaNV] LIKE '{0}'", txt.Text);    
        //    }
        //}

        //void timKiem_TenNV(RadioButton rad, DataGridView dgv, TextBox txt)
        //{
        //    if (rad.Checked)
        //    {

        //       ds.Tables[0].DefaultView.RowFilter = "Hoten LIKE '%"  +txt.Text+  "%'";
        //        //hoặc
        //        // ds.Tables[0].DefaultView.RowFilter = string.Format("[Hoten] LIKE '%{0}%'", txt.Text);    
        //    }
        //}


    }
}
