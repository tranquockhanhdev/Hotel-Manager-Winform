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
    public partial class QuanLyPhong : Form
    {
        DatPhongBLL dpbll = new DatPhongBLL();
        phong phg = new phong();
        phongBLL phgbll = new phongBLL();
        public QuanLyPhong()
        {
            InitializeComponent();
            dgvPhong.DataSource = phgbll.GetLisPhong();
        }

        private void btnThemPHG_Click(object sender, EventArgs e)
        {
            phg.Maphong = txtMaPhong.Text;
            phg.Maloai = txtMaLoaiPhong.Text;
            phg.Dientich = int.Parse(txtDientich.Text);
            phg.Tenphong = txtTenPhong.Text;
            phg.Dongiathue = int.Parse(txtDongia.Text);
            phg.Succhua = int.Parse(txtSucChua.Text);
            phg.Trangthai = int.Parse(txtTrangThai.Text);
            phg.Gia = int.Parse(txtGiaTien.Text);

            if(phgbll.Themphong(phg) == true && int.Parse(txtDongia.Text) > 10000)
            {
                MessageBox.Show("đã thêm 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhong.DataSource = phgbll.GetLisPhong();
            }
            else
            {
                MessageBox.Show("loi them phong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphong = null;
            maphong = dgvPhong.CurrentRow.Cells[0].Value.ToString().Trim();
            DataTable dt = new DataTable();
            dt = dpbll.LayPhongTheoMa(maphong);
            if (dt.Rows.Count > 0)
            {
                txtMaPhong.Text = dt.Rows[0]["maphong"].ToString();
                txtMaLoaiPhong.Text = dt.Rows[0]["maloai"].ToString();
                txtTenPhong.Text = dt.Rows[0]["tenphong"].ToString();
                txtSucChua.Text = dt.Rows[0]["succhua"].ToString();
                txtTrangThai.Text = dt.Rows[0]["trangthai"].ToString();
                txtGiaTien.Text = dt.Rows[0]["gia"].ToString();
                txtDientich.Text = dt.Rows[0]["dientich"].ToString();
                txtDongia.Text = dt.Rows[0]["dongiathue"].ToString();
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            phg.Maphong = txtMaPhong.Text;
            phg.Maloai = txtMaLoaiPhong.Text;
            phg.Dientich = int.Parse(txtDientich.Text);
            phg.Tenphong = txtTenPhong.Text;
            phg.Dongiathue = int.Parse(txtDongia.Text);
            phg.Succhua = int.Parse(txtSucChua.Text);
            phg.Trangthai = int.Parse(txtTrangThai.Text);
            phg.Gia = int.Parse(txtGiaTien.Text);
            if (phgbll.Xoaphong(phg) == true)
            {
                MessageBox.Show("đã xoá 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhong.DataSource = phgbll.GetLisPhong();
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            phg.Maphong = txtMaPhong.Text;
            phg.Maloai = txtMaLoaiPhong.Text;
            phg.Dientich = int.Parse(txtDientich.Text);
            phg.Tenphong = txtTenPhong.Text;
            phg.Dongiathue = int.Parse(txtDongia.Text);
            phg.Succhua = int.Parse(txtSucChua.Text);
            phg.Trangthai = int.Parse(txtTrangThai.Text);
            phg.Gia = int.Parse(txtGiaTien.Text);
            if (phgbll.Capnhatphong(phg) == true)
            {
                MessageBox.Show("đã sửa 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvPhong.DataSource = phgbll.GetLisPhong();
            }
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
