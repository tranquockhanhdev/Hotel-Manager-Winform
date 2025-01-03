using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dichvu
    {
        private string madichvu;
        private string maloaidv;
        private string tendichvu;
        private int giatien;
        private int trangthai;

        public dichvu() { }

        public dichvu(string madichvu,string maloaidv, string tendichvu, int giatien, int trangthai)
        {
            this.madichvu = madichvu;
            this.maloaidv = maloaidv;
            this.tendichvu = tendichvu;
            this.giatien = giatien;
            this.trangthai = trangthai;
        }
        public string Madichvu
        {
            get { return madichvu; }
            set { madichvu = value; }
        }
        public string Maloaidv
        {
            get { return maloaidv; }
            set { maloaidv = value; }
        }
        public string Tendichvu
        {
            get { return tendichvu; }
            set { tendichvu = value; }
        }
        public int Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

    }
}
