using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H2FCUH0\PC;Initial Catalog=QLKhachSan;Integrated Security=True"); 
            // khởi tạo connect
            return conn;
        }
    }
    public class databaseAccess
    {
        public static string checkTaiKhoanDTO(taikhoan tk)
        {
            string user = null;
            SqlConnection con = SqlConnectionData.Connect();
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string query = "SELECT * FROM taikhoan WHERE tendangnhap=@Username AND matkhau=@Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", tk.Tendangnhap);
                cmd.Parameters.AddWithValue("@Password", tk.Matkhau);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = reader.GetString(0);
                    }
                    reader.Close();
                    con.Close();
                }
                else
                {
                    return "Tài khoản hoặc mật khẩu không chính xác!";
                }

            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }
            return user;
        }
    }
}
