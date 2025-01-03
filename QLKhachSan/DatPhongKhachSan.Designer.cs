namespace QLKhachSan
{
    partial class DatPhongKhachSan
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
            this.components = new System.ComponentModel.Container();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.HuyDatPhong = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.dtNgayDi = new System.Windows.Forms.DateTimePicker();
            this.dtNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaThuePhong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaKhachhang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.loaiphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLKhachSanDataSet = new QLKhachSan.QLKhachSanDataSet();
            this.loaiphongTableAdapter = new QLKhachSan.QLKhachSanDataSetTableAdapters.loaiphongTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dientich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiphongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(155, 325);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(131, 56);
            this.btnDatPhong.TabIndex = 14;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(163, 146);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(189, 27);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // HuyDatPhong
            // 
            this.HuyDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyDatPhong.Location = new System.Drawing.Point(307, 325);
            this.HuyDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.HuyDatPhong.Name = "HuyDatPhong";
            this.HuyDatPhong.Size = new System.Drawing.Size(127, 56);
            this.HuyDatPhong.TabIndex = 16;
            this.HuyDatPhong.Text = "Hủy";
            this.HuyDatPhong.UseVisualStyleBackColor = true;
            this.HuyDatPhong.Click += new System.EventHandler(this.HuyDatPhong_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(162, 233);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(464, 27);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtCccd
            // 
            this.txtCccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCccd.Location = new System.Drawing.Point(163, 186);
            this.txtCccd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(463, 27);
            this.txtCccd.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(75, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Địa chỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số CMT/CCCD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(163, 76);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(465, 27);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodienthoai.Location = new System.Drawing.Point(162, 111);
            this.txtSodienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(166, 27);
            this.txtSodienthoai.TabIndex = 4;
            // 
            // dtNgayDi
            // 
            this.dtNgayDi.CustomFormat = "dd-MM-yyyy";
            this.dtNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDi.Location = new System.Drawing.Point(127, 313);
            this.dtNgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayDi.Name = "dtNgayDi";
            this.dtNgayDi.Size = new System.Drawing.Size(232, 27);
            this.dtNgayDi.TabIndex = 11;
            this.dtNgayDi.Value = new System.DateTime(2020, 12, 25, 20, 21, 24, 129);
            // 
            // dtNgayDen
            // 
            this.dtNgayDen.CustomFormat = "dd-MM-yyyy";
            this.dtNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDen.Location = new System.Drawing.Point(127, 267);
            this.dtNgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayDen.Name = "dtNgayDen";
            this.dtNgayDen.Size = new System.Drawing.Size(232, 27);
            this.dtNgayDen.TabIndex = 10;
            this.dtNgayDen.Value = new System.DateTime(2020, 12, 24, 20, 21, 24, 131);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dgvDatPhong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 30);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1114, 245);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm phòng còn trống";
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.maloai,
            this.tenphong,
            this.dientich,
            this.gia,
            this.trangthai,
            this.dongiathue});
            this.dgvDatPhong.Location = new System.Drawing.Point(7, 27);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.RowHeadersWidth = 51;
            this.dgvDatPhong.RowTemplate.Height = 24;
            this.dgvDatPhong.Size = new System.Drawing.Size(1068, 189);
            this.dgvDatPhong.TabIndex = 0;
            this.dgvDatPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatPhong_CellClick);
            this.dgvDatPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatPhong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaThuePhong);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNoidung);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtMaKhachhang);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnDatPhong);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.HuyDatPhong);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtCccd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.txtSodienthoai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(472, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(648, 390);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtMaThuePhong
            // 
            this.txtMaThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuePhong.Location = new System.Drawing.Point(492, 31);
            this.txtMaThuePhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaThuePhong.Name = "txtMaThuePhong";
            this.txtMaThuePhong.Size = new System.Drawing.Size(124, 27);
            this.txtMaThuePhong.TabIndex = 32;
            this.txtMaThuePhong.TextChanged += new System.EventHandler(this.txtMaThuePhong_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(372, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Mã Hợp Đồng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(360, 277);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(124, 27);
            this.txtSoluong.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(272, 280);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Số Lượng";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidung.Location = new System.Drawing.Point(113, 280);
            this.txtNoidung.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(124, 27);
            this.txtNoidung.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 280);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Nội Dung";
            // 
            // txtMaKhachhang
            // 
            this.txtMaKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachhang.Location = new System.Drawing.Point(161, 31);
            this.txtMaKhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKhachhang.Name = "txtMaKhachhang";
            this.txtMaKhachhang.Size = new System.Drawing.Size(191, 27);
            this.txtMaKhachhang.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mã Khách Hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtTrangthai);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTenphong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaphong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoaiPhong);
            this.groupBox1.Controls.Add(this.dtNgayDi);
            this.groupBox1.Controls.Add(this.dtNgayDen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(13, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(435, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt phòng";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(127, 172);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(232, 27);
            this.txtTrangthai.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Trạng Thái";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(127, 127);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(232, 27);
            this.txtGia.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Giá";
            // 
            // txtTenphong
            // 
            this.txtTenphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenphong.Location = new System.Drawing.Point(127, 84);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(232, 27);
            this.txtTenphong.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tên Phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphong.Location = new System.Drawing.Point(127, 35);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(232, 27);
            this.txtMaphong.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã Phòng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DataSource = this.loaiphongBindingSource;
            this.cboLoaiPhong.DisplayMember = "tenloai";
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(127, 217);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(232, 28);
            this.cboLoaiPhong.TabIndex = 13;
            // 
            // loaiphongBindingSource
            // 
            this.loaiphongBindingSource.DataMember = "loaiphong";
            this.loaiphongBindingSource.DataSource = this.qLKhachSanDataSet;
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiphongTableAdapter
            // 
            this.loaiphongTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1133, 27);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "maphong";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            this.maphong.Width = 125;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "maloai";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            this.maloai.Width = 125;
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "tenphong";
            this.tenphong.MinimumWidth = 6;
            this.tenphong.Name = "tenphong";
            this.tenphong.ReadOnly = true;
            this.tenphong.Width = 125;
            // 
            // dientich
            // 
            this.dientich.DataPropertyName = "dientich";
            this.dientich.HeaderText = "dientich";
            this.dientich.MinimumWidth = 6;
            this.dientich.Name = "dientich";
            this.dientich.ReadOnly = true;
            this.dientich.Width = 125;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "gia";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "trangthai";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 125;
            // 
            // dongiathue
            // 
            this.dongiathue.DataPropertyName = "dongiathue";
            this.dongiathue.HeaderText = "dongia";
            this.dongiathue.MinimumWidth = 6;
            this.dongiathue.Name = "dongiathue";
            this.dongiathue.ReadOnly = true;
            this.dongiathue.Width = 125;
            // 
            // DatPhongKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 702);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatPhongKhachSan";
            this.Text = "DatPhongKhachSan";
            this.Load += new System.EventHandler(this.DatPhongKhachSan_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiphongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Button HuyDatPhong;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.DateTimePicker dtNgayDi;
        private System.Windows.Forms.DateTimePicker dtNgayDen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private System.Windows.Forms.TextBox txtMaKhachhang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private System.Windows.Forms.BindingSource loaiphongBindingSource;
        private QLKhachSanDataSetTableAdapters.loaiphongTableAdapter loaiphongTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaThuePhong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientich;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiathue;
    }
}