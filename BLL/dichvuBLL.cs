using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class dichvuBLL
    {
        dichvuDAL daldv = new dichvuDAL();
        public DataTable LayDichVuTheoMa(string madichvu)
        {
            return daldv.layDichVuTheoMa(madichvu);
        }

        public List<dichvu> GetListdichvu()
        {
            return daldv.GetListdichvu();
        }

        public bool Themdichvu(dichvu dv)
        {
            daldv.Themdichvu(dv);
            return true;
        }

        public bool Xoadichvu(dichvu dv)
        {
            daldv.Xoadichvu(dv);
            return true;
        }

        public bool Capnhatdichvu(dichvu dv)
        {
            daldv.Capnhatdichvu(dv);
            return true;
        }
    }
}
