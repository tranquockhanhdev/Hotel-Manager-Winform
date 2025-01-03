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
    public partial class quanlidichvu : Form
    {
        dichvu dv = new dichvu();
        dichvuBLL dvbll = new dichvuBLL();
        public quanlidichvu()
        {
            InitializeComponent();
            dgvDichVu.DataSource = dvbll.GetListdichvu();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void quanlidichvu_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dv.Madichvu = txtMaDichVu.Text;
                dv.Maloaidv = txtMaLoaiDV.Text;
                dv.Tendichvu = txtTenDV.Text;
                dv.Giatien = int.Parse(txtGiaTien.Text);
                dv.Trangthai = int.Parse(txtTrangThai.Text);

                if (dvbll.Themdichvu(dv))
                {
                    MessageBox.Show("Đã thêm 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDichVu.DataSource = dvbll.GetListdichvu();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền và trạng thái phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dv.Madichvu = txtMaDichVu.Text;
                dv.Maloaidv = txtMaLoaiDV.Text;
                dv.Tendichvu = txtTenDV.Text;
                dv.Giatien = int.Parse(txtGiaTien.Text);
                dv.Trangthai = int.Parse(txtTrangThai.Text);

                if (dvbll.Capnhatdichvu(dv))
                {
                    MessageBox.Show("Đã sửa 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDichVu.DataSource = dvbll.GetListdichvu();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá tiền và trạng thái phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dv.Madichvu = txtMaDichVu.Text;

            if (dvbll.Xoadichvu(dv) == true)
            {
                MessageBox.Show("Đã xoá 1 dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDichVu.DataSource = dvbll.GetListdichvu();
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDichVu.CurrentRow != null)
            {
                string madichvu = dgvDichVu.CurrentRow.Cells[0].Value.ToString().Trim();
                DataTable dt = dvbll.LayDichVuTheoMa(madichvu);
                if (dt.Rows.Count > 0)
                {
                    txtMaDichVu.Text = dt.Rows[0]["madichvu"].ToString();
                    txtMaLoaiDV.Text = dt.Rows[0]["maloaidv"].ToString();
                    txtTenDV.Text = dt.Rows[0]["tendichvu"].ToString();
                    txtGiaTien.Text = dt.Rows[0]["giatien"].ToString();
                    txtTrangThai.Text = dt.Rows[0]["trangthai"].ToString();
                }
            }
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
