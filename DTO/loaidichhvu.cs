using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class loaidichhvu
    {
            private string maloaidv;
            private string tenloaidv;
            private string ghichu;

            public loaidichhvu() { }

            public loaidichhvu(string maloaidv, string tenloaidv, string ghichu)
            {
                this.maloaidv = maloaidv;
                this.tenloaidv = tenloaidv;
                this.ghichu = ghichu;
            }
            public string Maloaidv
            {
                get { return maloaidv; }
                set { maloaidv = value; }
            }
            public string TenloaiDV
            {
                get { return tenloaidv; }
                set { tenloaidv = value; }
            }
            public string Ghichu
            {
                get { return ghichu; }
                set { ghichu = value; }
            }
        }
    }
