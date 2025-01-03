using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class report_DAL
    {
        private SqlConnection conn;
        private string connectionString = "Data Source=DESKTOP-H2FCUH0\\PC;Initial Catalog=QLKhachSan;Integrated Security=True";
        public report_DAL()
        {
            conn = new SqlConnection(connectionString);
        }
        public List<ReportThuePhong> getlistreport()
        {
            List<ReportThuePhong> list = new List<ReportThuePhong>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "select * from khachhang inner join hopdongthuephong on khachhang.makhachhang = hopdongthuephong.makhachhang inner join phong on hopdongthuephong.maphong = phong.maphong where trangthai = 1\r\n";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ReportThuePhong rptp = new ReportThuePhong();
                    rptp.NgayVao = Convert.ToDateTime(reader["ngayvao"]);
                    rptp.NgayRa = Convert.ToDateTime(reader["ngayra"]);
                    rptp.SoKhach = reader["soluong"].ToString();
                    rptp.GiaPhong = reader["gia"].ToString();
                    rptp.MaLoai = reader["maloai"].ToString();
                    rptp.MaPhong = reader["maphong"].ToString();
                    rptp.TenKhach = reader["hoten"].ToString();
                    rptp.TenKhach = reader["diachi"].ToString();
                    TimeSpan timeSpan = rptp.NgayRa.Subtract(rptp.NgayVao);
                    int soDem = (int)timeSpan.TotalDays;
                    rptp.SoDem = soDem;
                    int thanhtien = soDem * (int)reader["gia"];
                    rptp.ThanhTien = thanhtien;
                    list.Add(rptp);
                }

                reader.Close();
                conn.Close();
            }

            return list;
        }
    }
}