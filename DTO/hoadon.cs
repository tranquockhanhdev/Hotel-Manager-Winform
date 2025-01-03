using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //khoa ngoai la makhachhang manhanvien mahopdongtp mahopdongdv
    public class hoadon
    {
        private string mahoadon;
        private DateTime ngaylap;
        private int tongtien;
        private string noidung;
        private int trangthai;

        public hoadon() { }

        public hoadon(string mahoadon,DateTime ngaylap, int tongtien, string noidung,
                      int trangthai)
        {
            this.mahoadon = mahoadon;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.noidung = noidung;
            this.trangthai = trangthai;
        }
        public string Mahoadon
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public string Noidung
        {
            get { return noidung; }
            set { noidung = value; }
        }
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
