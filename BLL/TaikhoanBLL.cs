using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaikhoanBLL
    {
        TaikhoanAccess tkAccess = new TaikhoanAccess();
        public string CheckLogin(taikhoan tk)
        {
            if (tk.Tendangnhap == "")
            {
                return "require_taikhoan";
            }

            if (tk.Matkhau == "")
            {
                return "require_password";
            }

            string info = tkAccess.checkTaiKhoan(tk);
            return info;
        }

    }
}
