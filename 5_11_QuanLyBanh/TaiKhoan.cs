using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_QuanLyBanh
{
    public  class TaiKhoan
    {
        private string tentaikhoan;

        public string Tentaikhoan { 
            get => tentaikhoan; 
            set => tentaikhoan = value; 
        }
        

        private string matkhau;

        public string Matkhau { 
            get => matkhau; 
            set => matkhau = value; 
        }
        public TaiKhoan(string tentaikhoan , string matkhau)
        {
            this.Tentaikhoan= tentaikhoan;
            this.Matkhau= matkhau;
        }

    }
}
