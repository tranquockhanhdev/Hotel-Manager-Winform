using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaiphong
    {
        private string maloai;
        private string tenloai;
        private string ghichu;

        public loaiphong() { }

        public loaiphong(string maloai, string tenloai, string ghichu)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
            this.ghichu = ghichu;
        }
        public string Maloai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        public string Tenloai
        {
            get { return tenloai; }
            set { tenloai = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
