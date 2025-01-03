using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QLKhachSan
{
    public partial class DatPhongKhachSan : Form
    {
        
         DatPhongBLL dpbll = new DatPhongBLL();
         phong phg = new phong();
         chitietthuephong cttp = new chitietthuephong();
         ChitietthuephongBLL cttpbll = new ChitietthuephongBLL();
         khachhang kh = new khachhang();
         KhachHangBLL khbll = new KhachHangBLL();
         
        public DatPhongKhachSan()
        {
            InitializeComponent();

            // hiển thị danh sách đặt phòng trong DataGridView
            dgvDatPhong.DataSource = dpbll.GetListDatPhong();

        }
        private void HuyDatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatPhongKhachSan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKhachSanDataSet.loaiphong' table. You can move, or remove it, as needed.
            this.loaiphongTableAdapter.Fill(this.qLKhachSanDataSet.loaiphong);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loaiphongTableAdapter.FillBy(this.qLKhachSanDataSet.loaiphong);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            cttp.Mahopdongtp = txtMaThuePhong.Text;
            cttp.Maphong = txtMaphong.Text;
            cttp.Noidung = txtNoidung.Text;
            cttp.Ngayvao = dtNgayDen.Value;
            cttp.Ngayra = dtNgayDi.Value;
            cttp.Soluong = int.Parse(txtSoluong.Text);
            cttp.Makhachhang = txtMaKhachhang.Text;
            kh.Makhachhang = txtMaKhachhang.Text;
            kh.Hoten = txtTenKH.Text;
            kh.Ngaysinh = dtNgaySinh.Value;
            kh.Sodienthoai = txtSodienthoai.Text;
            kh.Diachi = txtDiaChi.Text;
            kh.Cmnd = txtCccd.Text;
            phg.Maphong = txtMaphong.Text.Trim();
            if (dtNgayDi.Value > dtNgayDen.Value)
            {
            if (khbll.Themkhachhang(kh) == true)
            {
                MessageBox.Show("đã thêm 1 Khách Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(cttpbll.Themchitietthuephong(cttp) == true)
                {
                    MessageBox.Show("đã thêm 1 hợp đồng thuê phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(dpbll.CapNhatTrangThai(phg) == true)
                    {
                        this.Hide();
                        ChiTietThuePhongForm dashboard = new ChiTietThuePhongForm();
                        dashboard.ShowDialog();
                    }    
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm khách hàng", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            else
            {
                MessageBox.Show("Vui Long nhap lai ngay di va den", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void dgvDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphong = null;
            maphong = dgvDatPhong.CurrentRow.Cells[0].Value.ToString().Trim();
            DataTable dt = new DataTable(); 
            dt = dpbll.LayPhongTheoMa(maphong);
            if (dt.Rows.Count > 0)
            {
                txtMaphong.Text = dt.Rows[0]["maphong"].ToString();
                txtTenphong.Text = dt.Rows[0]["tenphong"].ToString();
                txtGia.Text = dt.Rows[0]["gia"].ToString();
                txtTrangthai.Text = dt.Rows[0]["trangthai"].ToString();
                cboLoaiPhong.Text = dt.Rows[0]["tenloai"].ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaThuePhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
