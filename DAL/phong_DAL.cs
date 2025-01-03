using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    
    public class phong_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public phong_DAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public List<phong> GetListphong()
        {
            List<phong> list = new List<phong>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM phong";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    phong dp = new phong();
                    dp.Maphong = reader["maphong"].ToString();
                    dp.Maloai = reader["maloai"].ToString();
                    dp.Tenphong = reader["tenphong"].ToString();
                    dp.Dientich = (int)reader["dientich"];
                    dp.Gia = (int)reader["gia"];
                    dp.Succhua = (int)reader["succhua"];
                    dp.Trangthai = (int)reader["trangthai"];
                    dp.Dongiathue = (int)reader["dongiathue"];

                    list.Add(dp);
                }

                reader.Close();
                conn.Close();
            }

            return list;
        }
        public bool themphong(phong phg)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO phong (maphong, maloai, tenphong,dientich, gia, succhua, trangthai,dongiathue) VALUES (@Maphong, @Maloai, @Tenphong,@Dientich,@Gia, @Succhua, @Trangthai, @Dongiathue)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maphong", phg.Maphong);
                cmd.Parameters.AddWithValue("@Maloai", phg.Maloai);
                cmd.Parameters.AddWithValue("@Tenphong", phg.Tenphong);
                cmd.Parameters.AddWithValue("@Dientich", phg.Dientich);
                cmd.Parameters.AddWithValue("@Succhua", phg.Succhua);
                cmd.Parameters.AddWithValue("@Trangthai", phg.Trangthai);
                cmd.Parameters.AddWithValue("@Gia", phg.Gia);
                cmd.Parameters.AddWithValue("@Dongiathue", phg.Dongiathue);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool xoaphong(phong phg)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM phong WHERE maphong = @Maphong";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maphong", phg.Maphong);
               
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool capnhatphong(phong phg)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE phong SET maloai = @Maloai, tenphong = @Tenphong,dientich = @Dientich,gia = @Gia, succhua = @Succhua, trangthai = @Trangthai,dongiathue = @Dongiathue WHERE maphong = @Maphong";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maphong", phg.Maphong);
                cmd.Parameters.AddWithValue("@Maloai", phg.Maloai);
                cmd.Parameters.AddWithValue("@Tenphong", phg.Tenphong);
                cmd.Parameters.AddWithValue("@Dientich", phg.Dientich);
                cmd.Parameters.AddWithValue("@Succhua", phg.Succhua);
                cmd.Parameters.AddWithValue("@Trangthai", phg.Trangthai);
                cmd.Parameters.AddWithValue("@Gia", phg.Gia);
                cmd.Parameters.AddWithValue("@Dongiathue", phg.Dongiathue);

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
