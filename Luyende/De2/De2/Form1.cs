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

namespace De2
{
    public partial class Form1 : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương
            con.ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\DuLieu.mdf;
            Integrated Security=True";
            //Gọi phương thức Load dự liệu
            LoadDuLieu("Select * from tblMonHoc");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSoTC.MaxLength = 2;
        }
        //Viết một hàm nạp dữ liệu lên DataGrid
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvKetQua.DataSource = ds.Tables[0];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void txtSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím điều khiển (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chặn
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTC.Text) || txtSoTC.Text == "0")
            {
                MessageBox.Show("Số tín chỉ phải là số nguyên dương!", "Thông báo");
                txtSoTC.Focus();
                return;
            }
            if (dgvKetQua.CurrentRow != null)
            {
                dgvKetQua.CurrentRow.Cells["TenMonHoc"].Value = txtTenMon.Text;
                dgvKetQua.CurrentRow.Cells["SoTinChi"].Value = txtSoTC.Text;

                MessageBox.Show("Cập nhật thành công!", "Thông báo");

                // Reset form
                txtMaMon.Enabled = true;
                btnSua.Enabled = false;
            }

        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Yellow;
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }
        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click tiêu đề
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgvKetQua.Rows[e.RowIndex];

                // Đổ dữ liệu lên TextBox
                txtMaMon.Text = row.Cells["MaMon"].Value.ToString();
                txtTenMon.Text = row.Cells["TenMonHoc"].Value.ToString();
                txtSoTC.Text = row.Cells["SoTinChi"].Value.ToString();

                // Khóa không cho sửa Mã môn
                txtMaMon.Enabled = false;

                // Enable 2 nút Sửa + Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Bạn phải chọn môn học cần xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa môn học này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Xóa dòng được chọn trong DataGridView
                foreach (DataGridViewRow row in dgvKetQua.SelectedRows)
                {
                    dgvKetQua.Rows.Remove(row);
                }

                MessageBox.Show("Xóa thành công!", "Thông báo");

                // Sau khi xóa: Clear TextBox + Disable nút
                txtMaMon.Clear();
                txtTenMon.Clear();
                txtSoTC.Clear();

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txtMaMon.Enabled = true; // cho nhập lại nếu cần
            }
        }
    }
}
