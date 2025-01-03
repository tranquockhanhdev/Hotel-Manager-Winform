using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class loaidichvuBLL
    {
        loaidichvuDAL daldv = new loaidichvuDAL();
        public DataTable LayloaiDichVuTheoMa(string maloaidichvu)
        {
            return daldv.layloaiDichVuTheoMa(maloaidichvu);
        }

        public List<loaidichhvu> GetListLoaidichvu()
        {
            return daldv.getlistloaidichvu();
        }

        public bool themloaidichvu(loaidichhvu ldv)
        {
            daldv.Themloaidichvu(ldv);
            return true;
        }

        public bool xoaloaidichvu(loaidichhvu ldv)
        {
            daldv.Xoaloaidichvu(ldv);
            return true;
        }

        public bool Capnhatdichvu(loaidichhvu ldv)
        {
            daldv.Capnhatdichvu(ldv);
            return true;
        }
    }
}
