using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class Khachhang_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public Khachhang_DAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public bool themkhachhang(khachhang kh)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO khachhang (makhachhang, hoten, ngaysinh, sodienthoai, diachi, cmnd) VALUES (@Makhachhang, @Hoten, @Ngaysinh, @Sodienthoai, @Diachi, @Cmnd)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Makhachhang",kh.Makhachhang );
                cmd.Parameters.AddWithValue("@Hoten", kh.Hoten);
                cmd.Parameters.AddWithValue("@Ngaysinh", kh.Ngaysinh);
                cmd.Parameters.AddWithValue("@Sodienthoai", kh.Sodienthoai);
                cmd.Parameters.AddWithValue("@Diachi", kh.Diachi);
                cmd.Parameters.AddWithValue("@Cmnd", kh.Cmnd);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
    }
}
