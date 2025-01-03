using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        Khachhang_DAL khdal = new Khachhang_DAL();
        public bool Themkhachhang(khachhang kh)
        {
            khdal.themkhachhang(kh);
            return true;
        }
    }
}
