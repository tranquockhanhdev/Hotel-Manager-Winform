using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietThuePhong_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public ChiTietThuePhong_DAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public bool themchitietthuephong(chitietthuephong cttp)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO hopdongthuephong(mahopdongtp,maphong, ngaylap, noidung, ngayvao, ngayra, soluong, makhachhang) VALUES(@Mahopdongtp,@Maphong, GETDATE(),@Noidung,@Ngayvao, @Ngayra,@Soluong, @Makhachhang)";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Mahopdongtp", cttp.Mahopdongtp);
                cmd.Parameters.AddWithValue("@Maphong", cttp.Maphong);
                cmd.Parameters.AddWithValue("@Noidung", cttp.Noidung);
                cmd.Parameters.AddWithValue("@Ngayvao", cttp.Ngayvao);
                cmd.Parameters.AddWithValue("@Ngayra", cttp.Ngayra);
                cmd.Parameters.AddWithValue("@Soluong", cttp.Soluong);
                cmd.Parameters.AddWithValue("@Makhachhang", cttp.Makhachhang);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public List<chitietthuephong> getlistthuephong()
        {
            List<chitietthuephong> list = new List<chitietthuephong>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM hopdongthuephong inner join phong on hopdongthuephong.maphong = phong.maphong  where trangthai=1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    chitietthuephong cttp = new chitietthuephong();
                    cttp.Mahopdongtp = reader["mahopdongtp"].ToString();
                    cttp.Maphong = reader["maphong"].ToString();
                    cttp.Makhachhang = reader["makhachhang"].ToString();
                    cttp.Ngaylap = Convert.ToDateTime(reader["ngaylap"]);
                    cttp.Noidung = reader["noidung"].ToString();
                    cttp.Ngayvao = Convert.ToDateTime(reader["ngayvao"]);
                    cttp.Ngayra = Convert.ToDateTime(reader["ngayra"]);
                    cttp.Soluong = (int)reader["soluong"];

                    list.Add(cttp);
                }

                reader.Close();
                conn.Close();
            }

            return list;
        }
        public DataTable laythuephongtheoma(string mahopdongtp)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from khachhang inner join hopdongthuephong on khachhang.makhachhang = hopdongthuephong.makhachhang inner join phong on hopdongthuephong.maphong = phong.maphong where trangthai = 1 and mahopdongtp = N'" + mahopdongtp + "'", conn);
                da.Fill(dt);

            }
            return dt;
        }
    }
}
