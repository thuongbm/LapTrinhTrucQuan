namespace de02
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.lbSoTin = new System.Windows.Forms.Label();
            this.lbTenMon = new System.Windows.Forms.Label();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbSoTin = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Location = new System.Drawing.Point(70, 36);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(55, 16);
            this.lbMaMon.TabIndex = 1;
            this.lbMaMon.Text = "Mã môn";
            this.lbMaMon.Click += new System.EventHandler(this.lbMaMon_Click);
            // 
            // lbSoTin
            // 
            this.lbSoTin.AutoSize = true;
            this.lbSoTin.Location = new System.Drawing.Point(70, 150);
            this.lbSoTin.Name = "lbSoTin";
            this.lbSoTin.Size = new System.Drawing.Size(60, 16);
            this.lbSoTin.TabIndex = 2;
            this.lbSoTin.Text = "Số tín chỉ";
            this.lbSoTin.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbTenMon
            // 
            this.lbTenMon.AutoSize = true;
            this.lbTenMon.Location = new System.Drawing.Point(70, 89);
            this.lbTenMon.Name = "lbTenMon";
            this.lbTenMon.Size = new System.Drawing.Size(60, 16);
            this.lbTenMon.TabIndex = 3;
            this.lbTenMon.Text = "Tên môn";
            // 
            // tbMaMon
            // 
            this.tbMaMon.Location = new System.Drawing.Point(175, 30);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(100, 22);
            this.tbMaMon.TabIndex = 4;
            this.tbMaMon.Enter += new System.EventHandler(this.TextBox_Enter);
            this.tbMaMon.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(175, 83);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(100, 22);
            this.tbTenMon.TabIndex = 5;
            this.tbTenMon.Enter += new System.EventHandler(this.TextBox_Enter);
            this.tbTenMon.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // tbSoTin
            // 
            this.tbSoTin.Location = new System.Drawing.Point(175, 144);
            this.tbSoTin.Name = "tbSoTin";
            this.tbSoTin.Size = new System.Drawing.Size(100, 22);
            this.tbSoTin.TabIndex = 6;
            this.tbSoTin.TextChanged += new System.EventHandler(this.tbSoTin_TextChanged);
            this.tbSoTin.Enter += new System.EventHandler(this.TextBox_Enter);
            this.tbSoTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoTin_KeyPress);
            this.tbSoTin.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(546, 33);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(546, 89);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(73, 215);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 51;
            this.dgvMonHoc.RowTemplate.Height = 24;
            this.dgvMonHoc.Size = new System.Drawing.Size(666, 204);
            this.dgvMonHoc.TabIndex = 9;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.tbSoTin);
            this.Controls.Add(this.tbTenMon);
            this.Controls.Add(this.tbMaMon);
            this.Controls.Add(this.lbTenMon);
            this.Controls.Add(this.lbSoTin);
            this.Controls.Add(this.lbMaMon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cập nhật danh sách môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.Label lbSoTin;
        private System.Windows.Forms.Label lbTenMon;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.TextBox tbSoTin;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvMonHoc;
    }
}

