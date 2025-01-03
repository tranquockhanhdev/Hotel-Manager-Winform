namespace QLKhachSan
{
    partial class quanliloaidichvu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiDichVu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenLoaiDV = new System.Windows.Forms.TextBox();
            this.txtMaLoaiDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoaiDichVu);
            this.groupBox1.Location = new System.Drawing.Point(68, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(656, 271);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại dịch vụ";
            // 
            // dgvLoaiDichVu
            // 
            this.dgvLoaiDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDichVu.Location = new System.Drawing.Point(36, 38);
            this.dgvLoaiDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiDichVu.Name = "dgvLoaiDichVu";
            this.dgvLoaiDichVu.RowHeadersWidth = 62;
            this.dgvLoaiDichVu.RowTemplate.Height = 28;
            this.dgvLoaiDichVu.Size = new System.Drawing.Size(463, 211);
            this.dgvLoaiDichVu.TabIndex = 0;
            this.dgvLoaiDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDichVu_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtTenLoaiDV);
            this.groupBox2.Controls.Add(this.txtMaLoaiDichVu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(68, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(637, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại dịch vụ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(442, 108);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 41);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(442, 62);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 41);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(442, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 41);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(176, 118);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(196, 22);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtTenLoaiDV
            // 
            this.txtTenLoaiDV.Location = new System.Drawing.Point(176, 79);
            this.txtTenLoaiDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiDV.Name = "txtTenLoaiDV";
            this.txtTenLoaiDV.Size = new System.Drawing.Size(196, 22);
            this.txtTenLoaiDV.TabIndex = 7;
            // 
            // txtMaLoaiDichVu
            // 
            this.txtMaLoaiDichVu.AcceptsReturn = true;
            this.txtMaLoaiDichVu.Location = new System.Drawing.Point(176, 37);
            this.txtMaLoaiDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoaiDichVu.Name = "txtMaLoaiDichVu";
            this.txtMaLoaiDichVu.Size = new System.Drawing.Size(196, 22);
            this.txtMaLoaiDichVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại dịch vụ";
            // 
            // quanliloaidichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "quanliloaidichvu";
            this.Text = "quanliloaidichvu";
            this.Load += new System.EventHandler(this.quanliloaidichvu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiDichVu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenLoaiDV;
        private System.Windows.Forms.TextBox txtMaLoaiDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}