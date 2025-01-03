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
    public partial class QuanLyLoaiPhong : Form
    {
        loaiphongBLL lpbll = new loaiphongBLL();
        loaiphong lp = new loaiphong();
        public QuanLyLoaiPhong()
        {
            InitializeComponent();
            dgvLoaiPhong.DataSource = lpbll.GetLisloaiPhong();
        }

        private void QuanLyLoaiPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnThemLoaiPHG_Click(object sender, EventArgs e)
        {
            lp.Maloai = txtMaLoaiPHG.Text;
            lp.Tenloai = txtTenLoaiPHG.Text;
            lp.Ghichu = txtGhiChu.Text;
            if (lpbll.Themloaiphong(lp) == true)
            {
                MessageBox.Show("đã thêm 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiPhong.DataSource = lpbll.GetLisloaiPhong();
            }
        }

        private void btnXoaLoaiPHG_Click(object sender, EventArgs e)
        {
            lp.Maloai = txtMaLoaiPHG.Text;
            lp.Tenloai = txtTenLoaiPHG.Text;
            lp.Ghichu = txtGhiChu.Text;
            if (lpbll.Xoaloaiphong(lp) == true)
            {
                MessageBox.Show("đã xoá 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiPhong.DataSource = lpbll.GetLisloaiPhong();
            }
        }

        private void btnSuaLoaiPHG_Click(object sender, EventArgs e)
        {
            lp.Maloai = txtMaLoaiPHG.Text;
            lp.Tenloai = txtTenLoaiPHG.Text;
            lp.Ghichu = txtGhiChu.Text;
            if (lpbll.Capnhatloaiphong(lp) == true)
            {
                MessageBox.Show("đã cập nhật 1 phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLoaiPhong.DataSource = lpbll.GetLisloaiPhong();
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maloai = null;
            maloai = dgvLoaiPhong.CurrentRow.Cells[0].Value.ToString().Trim();
            DataTable dt = new DataTable();
            dt = lpbll.layloaiphongtheoma(maloai);
            if (dt.Rows.Count > 0)
            {
                txtMaLoaiPHG.Text = dt.Rows[0]["maloai"].ToString();
                txtTenLoaiPHG.Text = dt.Rows[0]["tenloai"].ToString();
                txtGhiChu.Text = dt.Rows[0]["ghichu"].ToString();
            }
        }
    }
}
