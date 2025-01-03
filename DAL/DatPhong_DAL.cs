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
    public class Datphong_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public Datphong_DAL()
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
                    dp.Gia   = (int)reader["gia"];
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

        public bool capnhattrangthai(phong dp)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE phong SET trangthai = @TrangThai WHERE maphong = @Maphong";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maphong", dp.Maphong);
                cmd.Parameters.AddWithValue("@TrangThai",1);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public DataTable layPhongTheoMa(string maphong)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from phong inner join loaiphong on phong.maloai = loaiphong.maloai where maphong = N'" + maphong + "'", conn);
                da.Fill(dt);

            }
            return dt;
        }
    }
}