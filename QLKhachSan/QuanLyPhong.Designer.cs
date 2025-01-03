namespace QLKhachSan
{
    partial class QuanLyPhong
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
            this.loaiphongTableAdapter = new QLKhachSan.QLKhachSanDataSetTableAdapters.loaiphongTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPHG = new System.Windows.Forms.Button();
            this.txtMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLKhachSanDataSet = new QLKhachSan.QLKhachSanDataSet();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDientich = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loaiphongTableAdapter
            // 
            this.loaiphongTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(903, 25);
            this.fillByToolStrip.TabIndex = 15;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaPhong);
            this.groupBox3.Controls.Add(this.btnSuaPhong);
            this.groupBox3.Controls.Add(this.btnThemPHG);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(147, 526);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 103);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Location = new System.Drawing.Point(250, 33);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(104, 49);
            this.btnXoaPhong.TabIndex = 8;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.Location = new System.Drawing.Point(465, 33);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(95, 49);
            this.btnSuaPhong.TabIndex = 9;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPHG
            // 
            this.btnThemPHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPHG.Location = new System.Drawing.Point(48, 30);
            this.btnThemPHG.Name = "btnThemPHG";
            this.btnThemPHG.Size = new System.Drawing.Size(95, 52);
            this.btnThemPHG.TabIndex = 7;
            this.btnThemPHG.Text = "Thêm";
            this.btnThemPHG.UseVisualStyleBackColor = true;
            this.btnThemPHG.Click += new System.EventHandler(this.btnThemPHG_Click);
            // 
            // txtMaLoaiPhong
            // 
            this.txtMaLoaiPhong.Location = new System.Drawing.Point(137, 72);
            this.txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            this.txtMaLoaiPhong.Size = new System.Drawing.Size(173, 30);
            this.txtMaLoaiPhong.TabIndex = 16;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(486, 195);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(173, 30);
            this.txtGiaTien.TabIndex = 15;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(486, 125);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(173, 30);
            this.txtTrangThai.TabIndex = 14;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(486, 72);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(173, 30);
            this.txtSucChua.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giá tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sức chứa";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(137, 128);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(173, 30);
            this.txtTenPhong.TabIndex = 6;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(137, 36);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(173, 30);
            this.txtMaPhong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // qLKhachSanDataSet
            // 
            this.qLKhachSanDataSet.DataSetName = "QLKhachSanDataSet";
            this.qLKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(6, 29);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(867, 213);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 248);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDientich);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaLoaiPhong);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.txtTrangThai);
            this.groupBox2.Controls.Add(this.txtSucChua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenPhong);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 266);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // txtDientich
            // 
            this.txtDientich.Location = new System.Drawing.Point(137, 192);
            this.txtDientich.Name = "txtDientich";
            this.txtDientich.Size = new System.Drawing.Size(173, 30);
            this.txtDientich.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diện Tích";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(486, 29);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(173, 30);
            this.txtDongia.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đơn giá";
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 645);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            this.Load += new System.EventHandler(this.QuanLyPhong_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLKhachSanDataSetTableAdapters.loaiphongTableAdapter loaiphongTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPHG;
        private System.Windows.Forms.TextBox txtMaLoaiPhong;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private QLKhachSanDataSet qLKhachSanDataSet;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDientich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label4;
    }
}