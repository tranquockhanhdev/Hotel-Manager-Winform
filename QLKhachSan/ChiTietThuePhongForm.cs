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
    public partial class ChiTietThuePhongForm : Form
    {
        DatPhongBLL dpbll = new DatPhongBLL();
        ReportThuePhong rptp = new ReportThuePhong();
        phong phg = new phong();
        chitietthuephong cttp = new chitietthuephong();
        ChitietthuephongBLL cttpbll = new ChitietthuephongBLL();
        khachhang kh = new khachhang();
        KhachHangBLL khbll = new KhachHangBLL();
        public ChiTietThuePhongForm()
        {
            InitializeComponent();
        }

        private void ChiTietThuePhongForm_Load(object sender, EventArgs e)
        {
            dgvChiTietThuePhong.DataSource = cttpbll.GetListThuePhong();
        }

        private void btnTroVeCuaCTPP_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void dgvChiTietThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string mahopdongtp = null;
            mahopdongtp = dgvChiTietThuePhong.CurrentRow.Cells[0].Value.ToString().Trim();
            DataTable dt = new DataTable();
            dt = cttpbll.Laythuephongtheoma(mahopdongtp);
            if (dt.Rows.Count > 0)
            {
                string ngayVao = dt.Rows[0]["ngayvao"].ToString();
                DateTime dtNgayVao;
                DateTime.TryParse(ngayVao, out dtNgayVao);
                dtpNgayDen.Value = dtNgayVao;
                string ngayRa = dt.Rows[0]["ngayra"].ToString();
                DateTime dtNgayRa;
                DateTime.TryParse(ngayRa, out dtNgayRa);
                dtpNgayDi.Value = dtNgayRa;
                txtLoaiPhong.Text = dt.Rows[0]["maphong"].ToString();
                txtSoKhach.Text = dt.Rows[0]["soluong"].ToString();
                txtGiaPhong.Text = dt.Rows[0]["gia"].ToString();
                txtLoaiPhong.Text = dt.Rows[0]["maloai"].ToString();
                txtMaPhong.Text = dt.Rows[0]["maphong"].ToString();
                txtTenkhach.Text = dt.Rows[0]["hoten"].ToString();
                txtDiaChi.Text = dt.Rows[0]["diachi"].ToString();
                txtTenkhach.Text = dt.Rows[0]["hoten"].ToString();
                TimeSpan timeSpan = dtNgayRa.Subtract(dtNgayVao);
                int soDem = (int)timeSpan.TotalDays;
                txtSoDem.Text = soDem.ToString();
                int giaphong = int.Parse(dt.Rows[0]["gia"].ToString());
                int thanhtien = soDem * giaphong;
                txtThanhTien.Text = thanhtien.ToString();
            }
        }

        private void txtLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void dgvChiTietThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
