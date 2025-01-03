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
    public class ChitietthuephongBLL
    {
        ChiTietThuePhong_DAL cttpdal = new ChiTietThuePhong_DAL();
        public bool Themchitietthuephong(chitietthuephong cttp)
        {
            cttpdal.themchitietthuephong(cttp);
            return true;
        }
        public List<chitietthuephong> GetListThuePhong()
        {
            return cttpdal.getlistthuephong();
        }
        public DataTable Laythuephongtheoma(string maphong)
        {
            return cttpdal.laythuephongtheoma(maphong);
        }
    }
}
