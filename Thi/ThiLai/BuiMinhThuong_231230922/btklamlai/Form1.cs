using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btklamlai
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.quanLyCayTableAdapter.Fill(this.duLieuDataSet.QuanLyCay);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Lấy dữ liệu từ các ô nhập
        //        string tenCay = textBox1.Text;
        //        int maCay = textBox2.Text;
        //        DateTime ngayTrong = dateTimePicker1.Value;
        //        float chieuCao = float.Parse(tbChieuCao.Text);
        //        string tinhTrang = cbTinhTrang.Text;

        //        // Gọi Insert của TableAdapter
        //        quanLyCayTableAdapter.Insert(maCay, tenCay, ngayTrong, chieuCao, tinhTrang);

        //        // Load lại dữ liệu lên DataGridView
        //        quanLyCayTableAdapter.Fill(duLieuDataSet.QuanLyCay);

        //        MessageBox.Show("Thêm thành công!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}

    }
}
