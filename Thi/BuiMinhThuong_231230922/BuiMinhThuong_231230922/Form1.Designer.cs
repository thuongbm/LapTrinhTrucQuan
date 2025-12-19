namespace BuiMinhThuong_231230922
{
    partial class Form1
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
            this.lbMaThietBi = new System.Windows.Forms.Label();
            this.lbTenThietBi = new System.Windows.Forms.Label();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.lbNgayNhan = new System.Windows.Forms.Label();
            this.tbMaThietBi = new System.Windows.Forms.TextBox();
            this.tbTenThietBi = new System.Windows.Forms.TextBox();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbxTinhTrang = new System.Windows.Forms.ComboBox();
            this.btTimBaoHanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaThietBi
            // 
            this.lbMaThietBi.AutoSize = true;
            this.lbMaThietBi.Location = new System.Drawing.Point(23, 13);
            this.lbMaThietBi.Name = "lbMaThietBi";
            this.lbMaThietBi.Size = new System.Drawing.Size(67, 16);
            this.lbMaThietBi.TabIndex = 0;
            this.lbMaThietBi.Text = "Mã thiết bị";
            // 
            // lbTenThietBi
            // 
            this.lbTenThietBi.AutoSize = true;
            this.lbTenThietBi.Location = new System.Drawing.Point(23, 60);
            this.lbTenThietBi.Name = "lbTenThietBi";
            this.lbTenThietBi.Size = new System.Drawing.Size(72, 16);
            this.lbTenThietBi.TabIndex = 1;
            this.lbTenThietBi.Text = "Tên thiết bị";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(437, 13);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(66, 16);
            this.lbTinhTrang.TabIndex = 2;
            this.lbTinhTrang.Text = "Tình trạng";
            // 
            // lbNgayNhan
            // 
            this.lbNgayNhan.AutoSize = true;
            this.lbNgayNhan.Location = new System.Drawing.Point(437, 132);
            this.lbNgayNhan.Name = "lbNgayNhan";
            this.lbNgayNhan.Size = new System.Drawing.Size(72, 16);
            this.lbNgayNhan.TabIndex = 3;
            this.lbNgayNhan.Text = "Ngày nhận";
            // 
            // tbMaThietBi
            // 
            this.tbMaThietBi.Location = new System.Drawing.Point(170, 13);
            this.tbMaThietBi.Name = "tbMaThietBi";
            this.tbMaThietBi.Size = new System.Drawing.Size(100, 22);
            this.tbMaThietBi.TabIndex = 4;
            this.tbMaThietBi.TextChanged += new System.EventHandler(this.tbMaThietBI_TextChanged);
            // 
            // tbTenThietBi
            // 
            this.tbTenThietBi.Location = new System.Drawing.Point(170, 60);
            this.tbTenThietBi.Name = "tbTenThietBi";
            this.tbTenThietBi.Size = new System.Drawing.Size(100, 22);
            this.tbTenThietBi.TabIndex = 6;
            // 
            // dtNgayNhan
            // 
            this.dtNgayNhan.Location = new System.Drawing.Point(584, 126);
            this.dtNgayNhan.Name = "dtNgayNhan";
            this.dtNgayNhan.Size = new System.Drawing.Size(200, 22);
            this.dtNgayNhan.TabIndex = 7;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(26, 182);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.Size = new System.Drawing.Size(740, 150);
            this.dgvThietBi.TabIndex = 9;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(137, 377);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(290, 377);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(434, 377);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbxTinhTrang
            // 
            this.lbxTinhTrang.FormattingEnabled = true;
            this.lbxTinhTrang.Items.AddRange(new object[] {
            "Tốt",
            "Bảo hành",
            "Thanh lý"});
            this.lbxTinhTrang.Location = new System.Drawing.Point(598, 10);
            this.lbxTinhTrang.Name = "lbxTinhTrang";
            this.lbxTinhTrang.Size = new System.Drawing.Size(121, 24);
            this.lbxTinhTrang.TabIndex = 13;
            // 
            // btTimBaoHanh
            // 
            this.btTimBaoHanh.Location = new System.Drawing.Point(563, 377);
            this.btTimBaoHanh.Name = "btTimBaoHanh";
            this.btTimBaoHanh.Size = new System.Drawing.Size(109, 23);
            this.btTimBaoHanh.TabIndex = 14;
            this.btTimBaoHanh.Text = "Tìm bảo hành";
            this.btTimBaoHanh.UseVisualStyleBackColor = true;
            this.btTimBaoHanh.Click += new System.EventHandler(this.btTimBaoHanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTimBaoHanh);
            this.Controls.Add(this.lbxTinhTrang);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.dtNgayNhan);
            this.Controls.Add(this.tbTenThietBi);
            this.Controls.Add(this.tbMaThietBi);
            this.Controls.Add(this.lbNgayNhan);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbTenThietBi);
            this.Controls.Add(this.lbMaThietBi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaThietBi;
        private System.Windows.Forms.Label lbTenThietBi;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.Label lbNgayNhan;
        private System.Windows.Forms.TextBox tbMaThietBi;
        private System.Windows.Forms.TextBox tbTenThietBi;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ComboBox lbxTinhTrang;
        private System.Windows.Forms.Button btTimBaoHanh;
    }
}

