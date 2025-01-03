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
    public class DatPhongBLL
    {
            private Datphong_DAL dpdal;
            public DatPhongBLL()
            {
                dpdal = new Datphong_DAL();
            }
            public List<phong> GetListDatPhong()
            {
                return dpdal.GetListphong();
            }
            public bool CapNhatTrangThai(phong dp)
            {
                dpdal.capnhattrangthai(dp);
                return true;
            }
            public DataTable LayPhongTheoMa(string maphong)
            {
                return dpdal.layPhongTheoMa(maphong);
            }
            

    }
}
