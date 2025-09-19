namespace VidduListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ma 1",
            "giay",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ma 2",
            "ao",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ma 3",
            "quan",
            "100"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.mahang1 = new System.Windows.Forms.TextBox();
            this.soluong1 = new System.Windows.Forms.TextBox();
            this.tenhang1 = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.mahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mahang,
            this.tenhang,
            this.soluong});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(39, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(598, 365);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mahang1
            // 
            this.mahang1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mahang1.Location = new System.Drawing.Point(667, 31);
            this.mahang1.Name = "mahang1";
            this.mahang1.Size = new System.Drawing.Size(117, 22);
            this.mahang1.TabIndex = 1;
            // 
            // soluong1
            // 
            this.soluong1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soluong1.Location = new System.Drawing.Point(667, 122);
            this.soluong1.Name = "soluong1";
            this.soluong1.Size = new System.Drawing.Size(117, 22);
            this.soluong1.TabIndex = 2;
            // 
            // tenhang1
            // 
            this.tenhang1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenhang1.Location = new System.Drawing.Point(667, 74);
            this.tenhang1.Name = "tenhang1";
            this.tenhang1.Size = new System.Drawing.Size(117, 22);
            this.tenhang1.TabIndex = 3;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(675, 182);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(108, 22);
            this.them.TabIndex = 4;
            this.them.Text = "them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(675, 241);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(108, 22);
            this.sua.TabIndex = 5;
            this.sua.Text = "sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(675, 283);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(108, 22);
            this.xoa.TabIndex = 6;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // mahang
            // 
            this.mahang.Text = "Ma";
            this.mahang.Width = 120;
            // 
            // tenhang
            // 
            this.tenhang.Text = "ten san pham";
            this.tenhang.Width = 120;
            // 
            // soluong
            // 
            this.soluong.Text = "So luong";
            this.soluong.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.tenhang1);
            this.Controls.Add(this.soluong1);
            this.Controls.Add(this.mahang1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox mahang1;
        private System.Windows.Forms.TextBox soluong1;
        private System.Windows.Forms.TextBox tenhang1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.ColumnHeader mahang;
        private System.Windows.Forms.ColumnHeader tenhang;
        private System.Windows.Forms.ColumnHeader soluong;
    }
}

