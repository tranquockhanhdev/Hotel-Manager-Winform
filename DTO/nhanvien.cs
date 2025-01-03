using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanvien:taikhoan
    {
        private string manhanvien;
        private string hoten;
        private DateTime ngaysinh;
        private string sodienthoai;

        public nhanvien() { }
        public nhanvien(string manhanvien, string hoten, DateTime ngaysinh, string sodienthoai,
            string mataikhoan, string tendangnhap, string matkhau, string loaitaikhoan, int trangthai)
            : base(mataikhoan, tendangnhap, matkhau, loaitaikhoan, trangthai)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
        }
        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
    }
}
