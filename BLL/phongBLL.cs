using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class phongBLL
    {
       phong_DAL phgdal = new phong_DAL();
        public List<phong> GetLisPhong()
        {
            return phgdal.GetListphong();
        }
        public bool Themphong(phong phg)
        {
            phgdal.themphong(phg);
            return true;
        }
        public bool Xoaphong(phong phg)
        {
            phgdal.xoaphong(phg);
            return true;
        }
        public bool Capnhatphong(phong phg)
        {
            phgdal.capnhatphong(phg);
            return true;
        }
    }
}
