using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportThuePhong
    {
            public DateTime NgayVao { get; set; }
            public DateTime NgayRa { get; set; }
            public string SoKhach { get; set; }
            public string GiaPhong { get; set; }
            public string MaLoai { get; set; }
            public string MaPhong { get; set; }
            public string TenKhach { get; set; }
            public string DiaChi { get; set; }
            public int SoDem { get; set; }
            public int ThanhTien { get; set; }
    }
}
