using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
        public class chitietthuephong
        {
            private string mahopdongtp;
            private string maphong;
            private DateTime ngaylap;
            private string noidung;
            private DateTime ngayvao;
            private DateTime ngayra;
            private int soluong;
            private string makhachhang;

            public chitietthuephong() { }

            public chitietthuephong(string mahopdongtp, string maphong, DateTime ngaylap, string noidung, DateTime ngayvao, DateTime ngayra, int soluong, string makhachhang)
            {
                this.mahopdongtp = mahopdongtp;
                this.ngaylap = ngaylap;
                this.maphong = maphong;
                this.noidung = noidung;
                this.ngayvao = ngayvao;
                this.ngayra = ngayra;
                this.soluong = soluong;
            this.makhachhang = makhachhang;
            }
            public string Mahopdongtp
            {
                get { return mahopdongtp; }
                set { mahopdongtp = value; }
            }
            public DateTime Ngaylap
            {
                get { return ngaylap; }
                set { ngaylap = value; }
            }
        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
        }
            public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
            public string Noidung
            {
                get { return noidung; }
                set { noidung = value; }
            }
            public DateTime Ngayvao
            {
                get { return ngayvao; }
                set { ngayvao = value; }
            }
            public DateTime Ngayra
            {
                get { return ngayra; }
                set { ngayra = value; }
            }
            public int Soluong
            {
                get { return soluong; }
                set { soluong = value; }
            }
        }
    }

