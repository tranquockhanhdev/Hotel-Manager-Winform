namespace QLKhachSan
{
    partial class ChiTietThuePhongForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtSoKhach = new System.Windows.Forms.TextBox();
            this.dgvChiTietThuePhong = new System.Windows.Forms.DataGridView();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoDem = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.lblChiTietThanhTien = new System.Windows.Forms.Label();
            this.lblChiTietSoDem = new System.Windows.Forms.Label();
            this.lblChiTietNgayDi = new System.Windows.Forms.Label();
            this.lblChiTietQuocTich = new System.Windows.Forms.Label();
            this.lblChiTietTenKhach = new System.Windows.Forms.Label();
            this.lblChiTietSoPhong = new System.Windows.Forms.Label();
            this.lblChiTietGiaPhong = new System.Windows.Forms.Label();
            this.lblChiTietNgayVao = new System.Windows.Forms.Label();
            this.lblChiTietSoKhach = new System.Windows.Forms.Label();
            this.lblChiTietLoaiPhong = new System.Windows.Forms.Label();
            this.lblChiTietPP = new System.Windows.Forms.Label();
            this.btnTroVeCuaCTPP = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(766, 203);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(169, 22);
            this.dtpNgayDi.TabIndex = 135;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(261, 161);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(149, 22);
            this.dtpNgayDen.TabIndex = 134;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.Pink;
            this.btnInHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInHoaDon.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(946, 454);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(84, 87);
            this.btnInHoaDon.TabIndex = 130;
            this.btnInHoaDon.Text = "In";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(261, 205);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(149, 22);
            this.txtGiaPhong.TabIndex = 126;
            // 
            // txtSoKhach
            // 
            this.txtSoKhach.Location = new System.Drawing.Point(261, 115);
            this.txtSoKhach.Name = "txtSoKhach";
            this.txtSoKhach.Size = new System.Drawing.Size(149, 22);
            this.txtSoKhach.TabIndex = 125;
            // 
            // dgvChiTietThuePhong
            // 
            this.dgvChiTietThuePhong.AllowDrop = true;
            this.dgvChiTietThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhachhang,
            this.ngaylap,
            this.noidung,
            this.ngayvao,
            this.ngayra,
            this.soluong});
            this.dgvChiTietThuePhong.Location = new System.Drawing.Point(32, 300);
            this.dgvChiTietThuePhong.Name = "dgvChiTietThuePhong";
            this.dgvChiTietThuePhong.RowHeadersVisible = false;
            this.dgvChiTietThuePhong.RowHeadersWidth = 51;
            this.dgvChiTietThuePhong.RowTemplate.Height = 24;
            this.dgvChiTietThuePhong.Size = new System.Drawing.Size(903, 367);
            this.dgvChiTietThuePhong.TabIndex = 124;
            this.dgvChiTietThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietThuePhong_CellClick);
            this.dgvChiTietThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietThuePhong_CellContentClick);
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "makhachhang";
            this.makhachhang.HeaderText = "makhachhang";
            this.makhachhang.MinimumWidth = 6;
            this.makhachhang.Name = "makhachhang";
            this.makhachhang.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "ngaylap";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "noidung";
            this.noidung.HeaderText = "noidung";
            this.noidung.MinimumWidth = 6;
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            // 
            // ngayvao
            // 
            this.ngayvao.DataPropertyName = "ngayvao";
            this.ngayvao.HeaderText = "ngayvao";
            this.ngayvao.MinimumWidth = 6;
            this.ngayvao.Name = "ngayvao";
            this.ngayvao.ReadOnly = true;
            // 
            // ngayra
            // 
            this.ngayra.DataPropertyName = "ngayra";
            this.ngayra.HeaderText = "ngayra";
            this.ngayra.MinimumWidth = 6;
            this.ngayra.Name = "ngayra";
            this.ngayra.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "soluong";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // txtSoDem
            // 
            this.txtSoDem.Location = new System.Drawing.Point(261, 250);
            this.txtSoDem.Name = "txtSoDem";
            this.txtSoDem.Size = new System.Drawing.Size(149, 22);
            this.txtSoDem.TabIndex = 118;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(767, 145);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(168, 22);
            this.txtDiaChi.TabIndex = 117;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(766, 97);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(168, 22);
            this.txtTenkhach.TabIndex = 116;
            // 
            // lblChiTietThanhTien
            // 
            this.lblChiTietThanhTien.AutoSize = true;
            this.lblChiTietThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietThanhTien.Location = new System.Drawing.Point(665, 250);
            this.lblChiTietThanhTien.Name = "lblChiTietThanhTien";
            this.lblChiTietThanhTien.Size = new System.Drawing.Size(82, 19);
            this.lblChiTietThanhTien.TabIndex = 114;
            this.lblChiTietThanhTien.Text = "Thành tiền";
            // 
            // lblChiTietSoDem
            // 
            this.lblChiTietSoDem.AutoSize = true;
            this.lblChiTietSoDem.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoDem.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoDem.Location = new System.Drawing.Point(158, 250);
            this.lblChiTietSoDem.Name = "lblChiTietSoDem";
            this.lblChiTietSoDem.Size = new System.Drawing.Size(57, 19);
            this.lblChiTietSoDem.TabIndex = 113;
            this.lblChiTietSoDem.Text = "Số đêm";
            // 
            // lblChiTietNgayDi
            // 
            this.lblChiTietNgayDi.AutoSize = true;
            this.lblChiTietNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayDi.Location = new System.Drawing.Point(665, 203);
            this.lblChiTietNgayDi.Name = "lblChiTietNgayDi";
            this.lblChiTietNgayDi.Size = new System.Drawing.Size(62, 19);
            this.lblChiTietNgayDi.TabIndex = 112;
            this.lblChiTietNgayDi.Text = "Ngày đi";
            // 
            // lblChiTietQuocTich
            // 
            this.lblChiTietQuocTich.AutoSize = true;
            this.lblChiTietQuocTich.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietQuocTich.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietQuocTich.Location = new System.Drawing.Point(665, 151);
            this.lblChiTietQuocTich.Name = "lblChiTietQuocTich";
            this.lblChiTietQuocTich.Size = new System.Drawing.Size(61, 19);
            this.lblChiTietQuocTich.TabIndex = 111;
            this.lblChiTietQuocTich.Text = "Địa Chỉ";
            // 
            // lblChiTietTenKhach
            // 
            this.lblChiTietTenKhach.AutoSize = true;
            this.lblChiTietTenKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenKhach.Location = new System.Drawing.Point(665, 103);
            this.lblChiTietTenKhach.Name = "lblChiTietTenKhach";
            this.lblChiTietTenKhach.Size = new System.Drawing.Size(77, 19);
            this.lblChiTietTenKhach.TabIndex = 110;
            this.lblChiTietTenKhach.Text = "Tên khách";
            // 
            // lblChiTietSoPhong
            // 
            this.lblChiTietSoPhong.AutoSize = true;
            this.lblChiTietSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoPhong.Location = new System.Drawing.Point(665, 52);
            this.lblChiTietSoPhong.Name = "lblChiTietSoPhong";
            this.lblChiTietSoPhong.Size = new System.Drawing.Size(76, 19);
            this.lblChiTietSoPhong.TabIndex = 109;
            this.lblChiTietSoPhong.Text = "Mã Phòng";
            // 
            // lblChiTietGiaPhong
            // 
            this.lblChiTietGiaPhong.AutoSize = true;
            this.lblChiTietGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietGiaPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietGiaPhong.Location = new System.Drawing.Point(146, 212);
            this.lblChiTietGiaPhong.Name = "lblChiTietGiaPhong";
            this.lblChiTietGiaPhong.Size = new System.Drawing.Size(78, 19);
            this.lblChiTietGiaPhong.TabIndex = 108;
            this.lblChiTietGiaPhong.Text = "Giá phòng";
            // 
            // lblChiTietNgayVao
            // 
            this.lblChiTietNgayVao.AutoSize = true;
            this.lblChiTietNgayVao.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayVao.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayVao.Location = new System.Drawing.Point(146, 161);
            this.lblChiTietNgayVao.Name = "lblChiTietNgayVao";
            this.lblChiTietNgayVao.Size = new System.Drawing.Size(72, 19);
            this.lblChiTietNgayVao.TabIndex = 107;
            this.lblChiTietNgayVao.Text = "Ngày vào";
            // 
            // lblChiTietSoKhach
            // 
            this.lblChiTietSoKhach.AutoSize = true;
            this.lblChiTietSoKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoKhach.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoKhach.Location = new System.Drawing.Point(146, 118);
            this.lblChiTietSoKhach.Name = "lblChiTietSoKhach";
            this.lblChiTietSoKhach.Size = new System.Drawing.Size(69, 19);
            this.lblChiTietSoKhach.TabIndex = 106;
            this.lblChiTietSoKhach.Text = "Số khách";
            // 
            // lblChiTietLoaiPhong
            // 
            this.lblChiTietLoaiPhong.AutoSize = true;
            this.lblChiTietLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietLoaiPhong.Location = new System.Drawing.Point(146, 54);
            this.lblChiTietLoaiPhong.Name = "lblChiTietLoaiPhong";
            this.lblChiTietLoaiPhong.Size = new System.Drawing.Size(81, 19);
            this.lblChiTietLoaiPhong.TabIndex = 104;
            this.lblChiTietLoaiPhong.Text = "Loại phòng";
            // 
            // lblChiTietPP
            // 
            this.lblChiTietPP.AutoSize = true;
            this.lblChiTietPP.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietPP.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPP.Location = new System.Drawing.Point(389, 7);
            this.lblChiTietPP.Name = "lblChiTietPP";
            this.lblChiTietPP.Size = new System.Drawing.Size(351, 37);
            this.lblChiTietPP.TabIndex = 103;
            this.lblChiTietPP.Text = "CHI TIẾT PHIẾU PHÒNG";
            // 
            // btnTroVeCuaCTPP
            // 
            this.btnTroVeCuaCTPP.BackColor = System.Drawing.Color.Pink;
            this.btnTroVeCuaCTPP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVeCuaCTPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVeCuaCTPP.Location = new System.Drawing.Point(32, 9);
            this.btnTroVeCuaCTPP.Name = "btnTroVeCuaCTPP";
            this.btnTroVeCuaCTPP.Size = new System.Drawing.Size(96, 36);
            this.btnTroVeCuaCTPP.TabIndex = 102;
            this.btnTroVeCuaCTPP.Text = "Trở về";
            this.btnTroVeCuaCTPP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVeCuaCTPP.UseVisualStyleBackColor = false;
            this.btnTroVeCuaCTPP.Click += new System.EventHandler(this.btnTroVeCuaCTPP_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(753, 250);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(149, 22);
            this.txtThanhTien.TabIndex = 137;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(766, 51);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(168, 22);
            this.txtMaPhong.TabIndex = 138;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(251, 54);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(168, 22);
            this.txtLoaiPhong.TabIndex = 139;
            this.txtLoaiPhong.TextChanged += new System.EventHandler(this.txtLoaiPhong_TextChanged);
            // 
            // ChiTietThuePhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 706);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.dtpNgayDi);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.txtSoKhach);
            this.Controls.Add(this.dgvChiTietThuePhong);
            this.Controls.Add(this.txtSoDem);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.lblChiTietThanhTien);
            this.Controls.Add(this.lblChiTietSoDem);
            this.Controls.Add(this.lblChiTietNgayDi);
            this.Controls.Add(this.lblChiTietQuocTich);
            this.Controls.Add(this.lblChiTietTenKhach);
            this.Controls.Add(this.lblChiTietSoPhong);
            this.Controls.Add(this.lblChiTietGiaPhong);
            this.Controls.Add(this.lblChiTietNgayVao);
            this.Controls.Add(this.lblChiTietSoKhach);
            this.Controls.Add(this.lblChiTietLoaiPhong);
            this.Controls.Add(this.lblChiTietPP);
            this.Controls.Add(this.btnTroVeCuaCTPP);
            this.Name = "ChiTietThuePhongForm";
            this.Text = "ChiTietThuePhongForm";
            this.Load += new System.EventHandler(this.ChiTietThuePhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtSoKhach;
        private System.Windows.Forms.DataGridView dgvChiTietThuePhong;
        private System.Windows.Forms.TextBox txtSoDem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.Label lblChiTietThanhTien;
        private System.Windows.Forms.Label lblChiTietSoDem;
        private System.Windows.Forms.Label lblChiTietNgayDi;
        private System.Windows.Forms.Label lblChiTietQuocTich;
        private System.Windows.Forms.Label lblChiTietTenKhach;
        private System.Windows.Forms.Label lblChiTietSoPhong;
        private System.Windows.Forms.Label lblChiTietGiaPhong;
        private System.Windows.Forms.Label lblChiTietNgayVao;
        private System.Windows.Forms.Label lblChiTietSoKhach;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.Label lblChiTietPP;
        private System.Windows.Forms.Button btnTroVeCuaCTPP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahopdongtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayra;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
    }
}