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
    public class loaiphong_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public loaiphong_DAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public List<loaiphong> getlistloaiphong()
        {
            List<loaiphong> list = new List<loaiphong>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM loaiphong";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    loaiphong dp = new loaiphong();
                    dp.Maloai = reader["maloai"].ToString();
                    dp.Tenloai = reader["tenloai"].ToString();
                    dp.Ghichu = reader["ghichu"].ToString();

                    list.Add(dp);
                }

                reader.Close();
                conn.Close();
            }

            return list;
        }
        public bool themloaiphong(loaiphong lp)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO loaiphong (maloai, tenloai, ghichu) VALUES (@maloai, @tenloai, @ghichu)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maloai", lp.Maloai);
                cmd.Parameters.AddWithValue("@tenloai", lp.Tenloai);
                cmd.Parameters.AddWithValue("@ghichu", lp.Ghichu);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool xoaloaiphong(loaiphong lp)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM loaiphong WHERE maloai = @Maloai";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maloai", lp.Maloai);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool capnhatloaiphong(loaiphong lp)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE loaiphong SET tenloai = @Tenloai, ghichu = @Ghichu WHERE maloai = @Maloai";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maloai", lp.Maloai);
                cmd.Parameters.AddWithValue("@Tenloai", lp.Tenloai);
                cmd.Parameters.AddWithValue("@Ghichu", lp.Ghichu);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public DataTable LayPhongTheoMa(string maloai)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from loaiphong where maloai = N'" + maloai + "'", conn);
                da.Fill(dt);

            }
            return dt;
        }
    }
}
