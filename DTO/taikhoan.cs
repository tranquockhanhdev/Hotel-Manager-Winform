using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class taikhoan
    {
        private string mataikhoan;
        private string tendangnhap;
        private string matkhau;
        private string loaitaikhoan;
        private int trangthai;

        public taikhoan() { }

        public taikhoan(string mataikhoan, string tendangnhap, string matkhau, string loaitaikhoan, int trangthai)
        {
            this.mataikhoan = mataikhoan;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.loaitaikhoan = loaitaikhoan;
            this.trangthai = trangthai;
        }
        public string Mataikhoan
        {
            get { return mataikhoan; }
            set { mataikhoan = value; }
        }
        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Loaitaikhoan
        {
            get { return loaitaikhoan; }
            set { mataikhoan = value; }
        }
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
