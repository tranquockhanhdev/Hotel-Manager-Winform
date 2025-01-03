using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class quanliloaidichvu : Form
    {
        loaidichvuBLL ldvbll = new loaidichvuBLL();
        loaidichhvu dv = new loaidichhvu();
        public quanliloaidichvu()
        {
            InitializeComponent();
            dgvLoaiDichVu.DataSource = ldvbll.GetListLoaidichvu();
        }

        private void quanliloaidichvu_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dv.Maloaidv = txtMaLoaiDichVu.Text;
            dv.TenloaiDV = txtTenLoaiDV.Text;
            dv.Ghichu = txtGhiChu.Text;
            if(txtTenLoaiDV.Text=="thue xe")
            {
                MessageBox.Show("Dich vu da ton tai", "Thong bao");
            }
            else if
            (ldvbll.themloaidichvu(dv) == true)
            {
                MessageBox.Show("đã thêm 1 loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiDichVu.DataSource = ldvbll.GetListLoaidichvu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dv.Maloaidv = txtMaLoaiDichVu.Text;
            dv.TenloaiDV = txtTenLoaiDV.Text;
            dv.Ghichu = txtGhiChu.Text;
            if (ldvbll.xoaloaidichvu(dv) == true)
            {
                MessageBox.Show("đã xoá 1 loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiDichVu.DataSource = ldvbll.GetListLoaidichvu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dv.Maloaidv = txtMaLoaiDichVu.Text;
            dv.TenloaiDV = txtTenLoaiDV.Text;
            dv.Ghichu = txtGhiChu.Text;
            if (ldvbll.Capnhatdichvu(dv) == true)
            {
                MessageBox.Show("đã cập nhật 1 loại dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiDichVu.DataSource = ldvbll.GetListLoaidichvu();
            }
        }

        private void dgvLoaiDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maloai = null;
            maloai = dgvLoaiDichVu.CurrentRow.Cells[0].Value.ToString().Trim();
            DataTable dt = new DataTable();
            dt = ldvbll.LayloaiDichVuTheoMa(maloai);
            if (dt.Rows.Count > 0)
            {
                txtMaLoaiDichVu.Text = dt.Rows[0]["maloaidv"].ToString();
                txtTenLoaiDV.Text = dt.Rows[0]["tenloaidv"].ToString();
                txtGhiChu.Text = dt.Rows[0]["ghichu"].ToString();
            }
        }
    }
}
