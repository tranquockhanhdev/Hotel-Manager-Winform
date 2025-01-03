using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class dangnhap : Form
    {
        taikhoan tk = new taikhoan();
        TaikhoanBLL tkbll = new TaikhoanBLL();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnLogic_Click(object sender, EventArgs e)
        {
            tk.Tendangnhap = txtTaiKhoan.Text;
            tk.Matkhau = txtMatKhau.Text;
            string getuser = tkbll.CheckLogin(tk);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "require_admin":
                    MessageBox.Show("Bạn Cần Đăng nhập đúng quyên");
                    return;
                case "require_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "require_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống!");
            this.Hide();
            DashboardForm dashboard = new DashboardForm();
            dashboard.ShowDialog();

            

        }
    }
}
