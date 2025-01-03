using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phong
    {
        private string maphong;
        private string maloai;
        private string tenphong;
        private int dientich;
        private int gia;
        private int succhua;
        private int trangthai;
        private int dongiathue;

        public phong() { }

        public phong(string maphong, string maloai, string tenphong, int dientich, int gia, int succhua, int trangthai, int dongiathue)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
            this.dientich = dientich;
            this.gia = gia;
            this.succhua = succhua;
            this.trangthai = trangthai;
            this.dongiathue = dongiathue;
            this.maloai = maloai;
        }
        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        public string Tenphong
        {
            get { return tenphong; }
            set { tenphong = value; }
        }
        public int Dientich
        {
            get { return dientich; }
            set { dientich = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        public int Succhua
        {
            get { return succhua; }
            set { succhua = value; }
        }

        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public int Dongiathue
        {
            get { return dongiathue; }
            set { dongiathue = value; }
        }
        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        } 
    }
}