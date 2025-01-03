using DTO;
using QLKhachSan.Properties;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void tabControl_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void đặtPhòngKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhongKhachSan dpks = new DatPhongKhachSan();
            dpks.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chiTiếtPhiếuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietThuePhongForm cttpf = new ChiTietThuePhongForm();
            cttpf.ShowDialog();
        }

        private void quảnLíPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            qlp.ShowDialog();
        }

        private void quảnLíLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLoaiPhong qllp = new QuanLyLoaiPhong();
            qllp.ShowDialog();
        }

        private void quảnLíLoạiDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanliloaidichvu qlldv = new quanliloaidichvu();
            qlldv.ShowDialog();
        }

        private void quảnLíDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlidichvu qldv = new quanlidichvu();
            qldv.ShowDialog();
        }
    }
}
