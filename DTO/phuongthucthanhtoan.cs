using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //co khhoa ngoai la mahoadon, ma khachhang
    public class phuongthucthanhtoan
    {
        private string maphuongthuc;
        private string tenphuongthuc;
        private string ghichu;

        public phuongthucthanhtoan() { }

        public phuongthucthanhtoan(string maphuongthuc, string tenphuongthuc, string ghichu)
        {
            this.maphuongthuc = maphuongthuc;
            this.tenphuongthuc = tenphuongthuc;
            this.ghichu = ghichu;
        }

        public string Maphuongthuc
        {
            get { return maphuongthuc; }
            set { maphuongthuc = value; }
        }
        public string Tenphuongthuc
        {
            get { return tenphuongthuc; }
            set { tenphuongthuc = value; }
        }

        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
