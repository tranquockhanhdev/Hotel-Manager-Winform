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
    public class loaidichvuDAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public loaidichvuDAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public List<loaidichhvu> getlistloaidichvu()
        {
            List<loaidichhvu> list = new List<loaidichhvu>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM loaidichvu";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    loaidichhvu ldv = new loaidichhvu();
                    ldv.Maloaidv = reader["maloaidv"].ToString();
                    ldv.TenloaiDV = reader["tenloaidv"].ToString();
                    ldv.Ghichu = reader["ghichu"].ToString();

                    list.Add(ldv);
                }

                reader.Close();
                conn.Close();
            }

            return list;
        }
        public bool Themloaidichvu(loaidichhvu ldv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO loaidichvu (maloaidv, tenloaidv, ghichu) VALUES (@maloai, @tenloai, @ghichu)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maloai", ldv.Maloaidv);
                cmd.Parameters.AddWithValue("@tenloai", ldv.TenloaiDV);
                cmd.Parameters.AddWithValue("@ghichu", ldv.Ghichu);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool Xoaloaidichvu(loaidichhvu ldv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM loaidichvu WHERE maloaidv = @Maloai";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maloai", ldv.Maloaidv);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public bool Capnhatdichvu(loaidichhvu ldv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE loaidichvu SET tenloaidv = @Tenloai, ghichu = @Ghichu WHERE maloaidv = @Maloai";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Maloai", ldv.Maloaidv);
                cmd.Parameters.AddWithValue("@Tenloai", ldv.TenloaiDV);
                cmd.Parameters.AddWithValue("@Ghichu", ldv.Ghichu);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
            return ketQua;
        }
        public DataTable layloaiDichVuTheoMa(string maloai)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from loaidichvu where maloaidv = N'" + maloai + "'", conn);
                da.Fill(dt);

            }
            return dt;
        }
    }
}
