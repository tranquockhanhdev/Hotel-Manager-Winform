using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaikhoanAccess:databaseAccess
    {
        public string checkTaiKhoan(taikhoan tk)
        {
            string info = checkTaiKhoanDTO(tk);
            return info;
        }
    }
}
