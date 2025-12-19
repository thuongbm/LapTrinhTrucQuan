namespace btklamlai
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
            this.components = new System.ComponentModel.Container();
            this.lbTenCay = new System.Windows.Forms.Label();
            this.lbMaCay = new System.Windows.Forms.Label();
            this.lbNgayTrong = new System.Windows.Forms.Label();
            this.lbChieuCao = new System.Windows.Forms.Label();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbChieuCao = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvQuanLyCay = new System.Windows.Forms.DataGridView();
            this.quanLyCayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duLieuDataSet = new btklamlai.DuLieuDataSet();
            this.quanLyCayTableAdapter = new btklamlai.DuLieuDataSetTableAdapters.QuanLyCayTableAdapter();
            this.MaCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTrongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chieuCaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyCay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenCay
            // 
            this.lbTenCay.AutoSize = true;
            this.lbTenCay.Location = new System.Drawing.Point(46, 31);
            this.lbTenCay.Name = "lbTenCay";
            this.lbTenCay.Size = new System.Drawing.Size(56, 16);
            this.lbTenCay.TabIndex = 0;
            this.lbTenCay.Text = "Tên cây";
            this.lbTenCay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbMaCay
            // 
            this.lbMaCay.AutoSize = true;
            this.lbMaCay.Location = new System.Drawing.Point(46, 80);
            this.lbMaCay.Name = "lbMaCay";
            this.lbMaCay.Size = new System.Drawing.Size(53, 16);
            this.lbMaCay.TabIndex = 1;
            this.lbMaCay.Text = "Mã Cây";
            // 
            // lbNgayTrong
            // 
            this.lbNgayTrong.AutoSize = true;
            this.lbNgayTrong.Location = new System.Drawing.Point(46, 126);
            this.lbNgayTrong.Name = "lbNgayTrong";
            this.lbNgayTrong.Size = new System.Drawing.Size(73, 16);
            this.lbNgayTrong.TabIndex = 2;
            this.lbNgayTrong.Text = "Ngày trồng";
            // 
            // lbChieuCao
            // 
            this.lbChieuCao.AutoSize = true;
            this.lbChieuCao.Location = new System.Drawing.Point(352, 31);
            this.lbChieuCao.Name = "lbChieuCao";
            this.lbChieuCao.Size = new System.Drawing.Size(67, 16);
            this.lbChieuCao.TabIndex = 3;
            this.lbChieuCao.Text = "Chiều cao";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(352, 80);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(72, 16);
            this.lbTinhTrang.TabIndex = 4;
            this.lbTinhTrang.Text = "Tình Trạng";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Tốt ",
            "Trung bình ",
            "Kém"});
            this.cbTinhTrang.Location = new System.Drawing.Point(442, 80);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 24);
            this.cbTinhTrang.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // tbChieuCao
            // 
            this.tbChieuCao.Location = new System.Drawing.Point(442, 25);
            this.tbChieuCao.Name = "tbChieuCao";
            this.tbChieuCao.Size = new System.Drawing.Size(100, 22);
            this.tbChieuCao.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(221, 387);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(442, 387);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvQuanLyCay
            // 
            this.dgvQuanLyCay.AutoGenerateColumns = false;
            this.dgvQuanLyCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyCay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCay,
            this.tenCayDataGridViewTextBoxColumn,
            this.ngayTrongDataGridViewTextBoxColumn,
            this.chieuCaoDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dgvQuanLyCay.DataSource = this.quanLyCayBindingSource;
            this.dgvQuanLyCay.Location = new System.Drawing.Point(49, 217);
            this.dgvQuanLyCay.Name = "dgvQuanLyCay";
            this.dgvQuanLyCay.RowHeadersWidth = 51;
            this.dgvQuanLyCay.RowTemplate.Height = 24;
            this.dgvQuanLyCay.Size = new System.Drawing.Size(711, 150);
            this.dgvQuanLyCay.TabIndex = 12;
            // 
            // quanLyCayBindingSource
            // 
            this.quanLyCayBindingSource.DataMember = "QuanLyCay";
            this.quanLyCayBindingSource.DataSource = this.duLieuDataSet;
            // 
            // duLieuDataSet
            // 
            this.duLieuDataSet.DataSetName = "DuLieuDataSet";
            this.duLieuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyCayTableAdapter
            // 
            this.quanLyCayTableAdapter.ClearBeforeFill = true;
            // 
            // MaCay
            // 
            this.MaCay.DataPropertyName = "MaCay";
            this.MaCay.HeaderText = "MaCay";
            this.MaCay.MinimumWidth = 6;
            this.MaCay.Name = "MaCay";
            this.MaCay.Width = 125;
            // 
            // tenCayDataGridViewTextBoxColumn
            // 
            this.tenCayDataGridViewTextBoxColumn.DataPropertyName = "TenCay";
            this.tenCayDataGridViewTextBoxColumn.HeaderText = "TenCay";
            this.tenCayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenCayDataGridViewTextBoxColumn.Name = "tenCayDataGridViewTextBoxColumn";
            this.tenCayDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTrongDataGridViewTextBoxColumn
            // 
            this.ngayTrongDataGridViewTextBoxColumn.DataPropertyName = "NgayTrong";
            this.ngayTrongDataGridViewTextBoxColumn.HeaderText = "NgayTrong";
            this.ngayTrongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTrongDataGridViewTextBoxColumn.Name = "ngayTrongDataGridViewTextBoxColumn";
            this.ngayTrongDataGridViewTextBoxColumn.Width = 125;
            // 
            // chieuCaoDataGridViewTextBoxColumn
            // 
            this.chieuCaoDataGridViewTextBoxColumn.DataPropertyName = "ChieuCao";
            this.chieuCaoDataGridViewTextBoxColumn.HeaderText = "ChieuCao";
            this.chieuCaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chieuCaoDataGridViewTextBoxColumn.Name = "chieuCaoDataGridViewTextBoxColumn";
            this.chieuCaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvQuanLyCay);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbChieuCao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbChieuCao);
            this.Controls.Add(this.lbNgayTrong);
            this.Controls.Add(this.lbMaCay);
            this.Controls.Add(this.lbTenCay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyCay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duLieuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenCay;
        private System.Windows.Forms.Label lbMaCay;
        private System.Windows.Forms.Label lbNgayTrong;
        private System.Windows.Forms.Label lbChieuCao;
        private System.Windows.Forms.Label lbTinhTrang;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbChieuCao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvQuanLyCay;
        private DuLieuDataSet duLieuDataSet;
        private System.Windows.Forms.BindingSource quanLyCayBindingSource;
        private DuLieuDataSetTableAdapters.QuanLyCayTableAdapter quanLyCayTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTrongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chieuCaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
    }
}

