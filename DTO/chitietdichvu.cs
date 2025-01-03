using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //khoa ngoai la ma dichvu
    public class chitietdichvu
    {
        private string mahopdongdv;
        private DateTime ngaylap;
        private string noidung;
        private int tongtien;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;
        private int soluong;

        public chitietdichvu() { }

        public chitietdichvu(string mahopdongdv, DateTime ngaylap, string noidung, int tongtien,
                             DateTime ngaybatdau, DateTime ngayketthuc, int soluong)
        {
            this.mahopdongdv = mahopdongdv;
            this.ngaylap = ngaylap;
            this.noidung = noidung;
            this.tongtien = tongtien;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.soluong = soluong;
        }

        public string Mahopdongdv
        {
            get { return mahopdongdv; }
            set { mahopdongdv = value; }
        }

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        public string Noidung
        {
            get { return noidung; }
            set { noidung = value; }
        }

        public int Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        public DateTime Ngaybatdau
        {
            get { return ngaybatdau; }
            set { ngaybatdau = value; }
        }

        public DateTime Ngayketthuc
        {
            get { return ngayketthuc; }
            set { ngayketthuc = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}
