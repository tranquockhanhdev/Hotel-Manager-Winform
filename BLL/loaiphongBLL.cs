using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class loaiphongBLL
    {
        loaiphong_DAL lpdal = new loaiphong_DAL();
        public List<loaiphong> GetLisloaiPhong()
        {
            return lpdal.getlistloaiphong();
        }
        public bool Themloaiphong(loaiphong lp)
        {
            lpdal.themloaiphong(lp);
            return true;
        }
        public bool Xoaloaiphong(loaiphong lp)
        {
            lpdal.xoaloaiphong(lp);
            return true;
        }
        public bool Capnhatloaiphong(loaiphong lp)
        {
            lpdal.capnhatloaiphong(lp);
            return true;
        }
        public DataTable layloaiphongtheoma(string maloai)
        {
            return lpdal.LayPhongTheoMa(maloai);
        }
    }
}
