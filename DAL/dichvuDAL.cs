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
    public class dichvuDAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public dichvuDAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public List<dichvu> GetListdichvu()
        {
            List<dichvu> dichvus = new List<dichvu>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dichvu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dichvu dv = new dichvu(
                        reader["madichvu"].ToString(),
                        reader["maloaidv"].ToString(),
                        reader["tendichvu"].ToString(),
                        Convert.ToInt32(reader["giatien"]),
                        Convert.ToInt32(reader["trangthai"])
                    );
                    dichvus.Add(dv);
                }
                reader.Close();
            }
            return dichvus;
        }

        public void Themdichvu(dichvu dv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dichvu (madichvu, maloaidv, tendichvu, giatien, trangthai) VALUES (@madichvu, @maloaidv, @tendichvu, @giatien, @trangthai)", conn);
                cmd.Parameters.AddWithValue("@madichvu", dv.Madichvu);
                cmd.Parameters.AddWithValue("@maloaidv", dv.Maloaidv);
                cmd.Parameters.AddWithValue("@tendichvu", dv.Tendichvu);
                cmd.Parameters.AddWithValue("@giatien", dv.Giatien);
                cmd.Parameters.AddWithValue("@trangthai", dv.Trangthai);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();
            }
        }

        public void Xoadichvu(dichvu dv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dichvu WHERE madichvu = @madichvu", conn);
                cmd.Parameters.AddWithValue("@madichvu", dv.Madichvu);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();

            }
        }

        public void Capnhatdichvu(dichvu dv)
        {
            bool ketQua = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE dichvu SET maloaidv = @maloaidv, tendichvu = @tendichvu, giatien = @giatien, trangthai = @trangthai WHERE madichvu = @madichvu", conn);
                cmd.Parameters.AddWithValue("@madichvu", dv.Madichvu);
                cmd.Parameters.AddWithValue("@maloaidv", dv.Maloaidv);
                cmd.Parameters.AddWithValue("@tendichvu", dv.Tendichvu);
                cmd.Parameters.AddWithValue("@giatien", dv.Giatien);
                cmd.Parameters.AddWithValue("@trangthai", dv.Trangthai);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    ketQua = true;
                }
                conn.Close();
            }

        }

        public DataTable layDichVuTheoMa(string madichvu)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dichvu WHERE madichvu = @madichvu", conn);
                da.SelectCommand.Parameters.AddWithValue("@madichvu", madichvu);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
