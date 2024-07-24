using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _5_11_QuanLyBanh
{
    internal class quanlybanBanh
    {
        SqlConnection con = new SqlConnection();
        void ketnoi()
        {
            con.ConnectionString = @"Data source=MSI;Initial Catalog=quanlybanBanh;integrated Security=True";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                
            }
        }

        void dongketnoi()
        {
            con.Close();
        }

        public quanlybanBanh()
        {
            ketnoi();
        }

        public DataSet layDuLieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            return ds;
        }

        public int capNhatDuLieu(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            return cmd.ExecuteNonQuery();         
        }
    }
}
