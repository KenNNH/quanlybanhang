using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_QuanLyBanh
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan intance;
        public static DanhSachTaiKhoan Intance 
        {
            get
            {
                if (intance == null)
                    intance = new DanhSachTaiKhoan();
                return intance;
            }

            set => intance = value; 
        }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value;
        }
        

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("nhathuy", "123456")); 
            listTaiKhoan.Add(new TaiKhoan("vihao", "789"));
            listTaiKhoan.Add(new TaiKhoan("huy123", "0312"));

        }
    }
}
