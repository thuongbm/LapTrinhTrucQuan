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

namespace Thi1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        /*cau 4*/
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=|DataDirectory|\DuLieu.mdf;
      Integrated Security=True";
            LoadData("SELECT * FROM tblMonHoc");
        }
        private void LoadData(string sql)
        {
            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            dgvDL.DataSource = ds.Tables[0];
        }
        /*cau 2*/
        // Validate that only numeric input is allowed in the txtSoTC TextBox
        private void txtSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTC_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTC.Text.Length > 2)
            {
                MessageBox.Show("Số tín chỉ không được vượt quá 2 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTC.Text = txtSoTC.Text.Substring(0, 2);
                txtSoTC.SelectionStart = txtSoTC.Text.Length; // Đặt con trỏ về cuối chuỗi
            }
        }
        /*cau 3*/
        // Close the application when the "Thoat" button is clicked
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }
        /*cau 5*/
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (txtMa.Text.Trim() == "")
            {
                errForm.SetError(txtMa,"Phải điền mã môn học");
                return;
            } else errForm.Clear();
            if (txtTen.Text.Trim() == "")
            {
                errForm.SetError(txtTen, "Phải điền tên môn học");
                return;
            }
            else errForm.Clear();
            if (txtSoTC.Text.Trim() == "")
            {
                errForm.SetError(txtSoTC, "Phải điền số tín chỉ");
                return;
            }
            else errForm.Clear();
            // Kiem tra ma mon hoc da ton tai chua
            sql = "SELECT COUNT(*) FROM tblMonHoc WHERE MaMon = '" + txtMa + "'";
            cmd = new SqlCommand(sql, conn);
            int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                errForm.SetError(txtMa, "Mã môn học đã tồn tại.");
                return;
            }
            errForm.Clear();
            // Them du lieu moi
            sql = "INSERT INTO tblMonHoc (MaMon, TenMon, SoTC) VALUES (";
            sql += "N'" + txtMa.Text + "',N'" + txtTen.Text + "',N'" + txtSoTC.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            //Cap nhat lai DataGrid
            sql = "Select * from tblMonHoc";
            LoadData(sql);
            //dong ket noi
            conn.Close();
        }
    }
}
