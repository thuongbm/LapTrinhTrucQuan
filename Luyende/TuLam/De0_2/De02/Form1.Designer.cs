namespace De02
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
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbSoTC = new System.Windows.Forms.TextBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.lblSoTC = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnInfo.SuspendLayout();
            this.pnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.btnSua);
            this.pnInfo.Controls.Add(this.btnXoa);
            this.pnInfo.Controls.Add(this.btnThem);
            this.pnInfo.Controls.Add(this.tbSoTC);
            this.pnInfo.Controls.Add(this.tbTenMon);
            this.pnInfo.Controls.Add(this.tbMaMon);
            this.pnInfo.Controls.Add(this.lblSoTC);
            this.pnInfo.Controls.Add(this.lblTenMon);
            this.pnInfo.Controls.Add(this.lblMaMon);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(800, 215);
            this.pnInfo.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(620, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 33);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(620, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 33);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbSoTC
            // 
            this.tbSoTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoTC.Location = new System.Drawing.Point(153, 163);
            this.tbSoTC.Name = "tbSoTC";
            this.tbSoTC.Size = new System.Drawing.Size(141, 22);
            this.tbSoTC.TabIndex = 13;
            // 
            // tbTenMon
            // 
            this.tbTenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTenMon.Location = new System.Drawing.Point(153, 110);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(141, 22);
            this.tbTenMon.TabIndex = 12;
            // 
            // tbMaMon
            // 
            this.tbMaMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaMon.Location = new System.Drawing.Point(153, 50);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(141, 22);
            this.tbMaMon.TabIndex = 11;
            // 
            // lblSoTC
            // 
            this.lblSoTC.AutoSize = true;
            this.lblSoTC.Location = new System.Drawing.Point(70, 165);
            this.lblSoTC.Name = "lblSoTC";
            this.lblSoTC.Size = new System.Drawing.Size(45, 16);
            this.lblSoTC.TabIndex = 10;
            this.lblSoTC.Text = "Số TC";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(70, 110);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(60, 16);
            this.lblTenMon.TabIndex = 9;
            this.lblTenMon.Text = "Tên môn";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(70, 50);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(55, 16);
            this.lblMaMon.TabIndex = 8;
            this.lblMaMon.Text = "Mã môn";
            // 
            // pnData
            // 
            this.pnData.Controls.Add(this.dgvMon);
            this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnData.Location = new System.Drawing.Point(0, 215);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(800, 235);
            this.pnData.TabIndex = 1;
            // 
            // dgvMon
            // 
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Location = new System.Drawing.Point(12, 0);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(788, 235);
            this.dgvMon.TabIndex = 0;
            this.dgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMon_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(460, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 33);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.pnInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbSoTC;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.Label lblSoTC;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Button btnSua;
    }
}

