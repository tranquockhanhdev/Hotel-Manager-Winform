using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachhang:taikhoan
    {
        private string makhachhang;
        private string hoten;
        private DateTime ngaysinh;
        private string sodienthoai;
        private string diachi;
        private string cmnd;

        public khachhang() { }
        public khachhang(string makhachhang, string hoten, DateTime ngaysinh, string sodienthoai, string diachi, string cmnd,
            string mataikhoan, string tendangnhap, string matkhau, string loaitaikhoan, int trangthai)
            : base(mataikhoan, tendangnhap, matkhau, loaitaikhoan, trangthai)
        {
            this.makhachhang = makhachhang;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
            this.cmnd = cmnd;
        }
        public string Makhachhang
        {
            get { return makhachhang; }
            set { makhachhang = value; }
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
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
    }
}
