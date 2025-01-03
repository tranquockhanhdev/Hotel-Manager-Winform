namespace QLKhachSan
{
    partial class QuanLyLoaiPhong
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenLoaiPHG = new System.Windows.Forms.TextBox();
            this.txtMaLoaiPHG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiPhong = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaLoaiPHG = new System.Windows.Forms.Button();
            this.btnSuaLoaiPHG = new System.Windows.Forms.Button();
            this.btnThemLoaiPHG = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.txtTenLoaiPHG);
            this.groupBox2.Controls.Add(this.txtMaLoaiPHG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(143, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 253);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(154, 176);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(173, 30);
            this.txtGhiChu.TabIndex = 15;
            // 
            // txtTenLoaiPHG
            // 
            this.txtTenLoaiPHG.Location = new System.Drawing.Point(159, 118);
            this.txtTenLoaiPHG.Name = "txtTenLoaiPHG";
            this.txtTenLoaiPHG.Size = new System.Drawing.Size(168, 30);
            this.txtTenLoaiPHG.TabIndex = 6;
            // 
            // txtMaLoaiPHG
            // 
            this.txtMaLoaiPHG.Location = new System.Drawing.Point(159, 60);
            this.txtMaLoaiPHG.Name = "txtMaLoaiPHG";
            this.txtMaLoaiPHG.Size = new System.Drawing.Size(168, 30);
            this.txtMaLoaiPHG.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoaiPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 250);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại phòng";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Location = new System.Drawing.Point(32, 41);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.RowHeadersWidth = 51;
            this.dgvLoaiPhong.RowTemplate.Height = 24;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(506, 193);
            this.dgvLoaiPhong.TabIndex = 0;
            this.dgvLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiPhong_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaLoaiPHG);
            this.groupBox3.Controls.Add(this.btnSuaLoaiPHG);
            this.groupBox3.Controls.Add(this.btnThemLoaiPHG);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(528, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 242);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaLoaiPHG
            // 
            this.btnXoaLoaiPHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiPHG.Location = new System.Drawing.Point(48, 100);
            this.btnXoaLoaiPHG.Name = "btnXoaLoaiPHG";
            this.btnXoaLoaiPHG.Size = new System.Drawing.Size(95, 49);
            this.btnXoaLoaiPHG.TabIndex = 8;
            this.btnXoaLoaiPHG.Text = "Xóa";
            this.btnXoaLoaiPHG.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPHG.Click += new System.EventHandler(this.btnXoaLoaiPHG_Click);
            // 
            // btnSuaLoaiPHG
            // 
            this.btnSuaLoaiPHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiPHG.Location = new System.Drawing.Point(48, 175);
            this.btnSuaLoaiPHG.Name = "btnSuaLoaiPHG";
            this.btnSuaLoaiPHG.Size = new System.Drawing.Size(95, 43);
            this.btnSuaLoaiPHG.TabIndex = 9;
            this.btnSuaLoaiPHG.Text = "Sửa";
            this.btnSuaLoaiPHG.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPHG.Click += new System.EventHandler(this.btnSuaLoaiPHG_Click);
            // 
            // btnThemLoaiPHG
            // 
            this.btnThemLoaiPHG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiPHG.Location = new System.Drawing.Point(48, 38);
            this.btnThemLoaiPHG.Name = "btnThemLoaiPHG";
            this.btnThemLoaiPHG.Size = new System.Drawing.Size(95, 43);
            this.btnThemLoaiPHG.TabIndex = 7;
            this.btnThemLoaiPHG.Text = "Thêm";
            this.btnThemLoaiPHG.UseVisualStyleBackColor = true;
            this.btnThemLoaiPHG.Click += new System.EventHandler(this.btnThemLoaiPHG_Click);
            // 
            // QuanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "QuanLyLoaiPhong";
            this.Text = "QuanLyLoaiPhong";
            this.Load += new System.EventHandler(this.QuanLyLoaiPhong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenLoaiPHG;
        private System.Windows.Forms.TextBox txtMaLoaiPHG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaLoaiPHG;
        private System.Windows.Forms.Button btnSuaLoaiPHG;
        private System.Windows.Forms.Button btnThemLoaiPHG;
    }
}