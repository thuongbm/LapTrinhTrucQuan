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

namespace thi
{
    public partial class Form1 : Form
    {
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
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\tblThietBi .mdf;
                Integrated Security=True;";


            //Gọi phương thức Load dự liệu
            LoadDuLieu("Select * from tbl1");
            //Khi Form mới Load lên thì ẩn các bút Sửa và Xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //An groupbox chi tiet
            HienChiTiet(false);
        }
        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            ds = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvThietBi.DataSource = ds.Tables[0];
        }
        //Phương thức ẩn hiện các control ở groupbox chi tiết
        private void HienChiTiet(Boolean hien)
        {
            btnSua.Enabled = hien;
            btnXoa.Enabled = hien;
            btnThem.Enabled = !hien;
            btnTim.Enabled = !hien;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            string sql;
            if (btnThem.Enabled)
            {
                sql = "INSERT INTO tbl1(MaTB, TenTB, TinhTrang, NgayNhan) VALUES(@MaTB, @TenTB, @TinhTrang, @NgayNhan)";
            }
            else // sửa
            {
                sql = "UPDATE tbl1 SET TenTB=@TenTB, TinhTrang=@TinhTrang, NgayNhan=@NgayNhan WHERE MaTB=@MaTB";
            }

            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaTB", txtMa.Text);
            cmd.Parameters.AddWithValue("@TenTB", txtTen.Text);
            cmd.Parameters.AddWithValue("@TinhTrang", cboTinhTrang.Text);
            cmd.Parameters.AddWithValue("@NgayNhan", dtpNgay.Value);
            cmd.ExecuteNonQuery();

            con.Close();
            LoadDuLieu("SELECT * FROM tbl1");
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HienChiTiet(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa thiết bị {txtMa.Text} không?",
                "Xóa thiết bị", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (con.State != ConnectionState.Open) con.Open();
                string sql = "DELETE FROM tbl1 WHERE MaTB=@MaTB";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaTB", txtMa.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDuLieu("SELECT * FROM tbl1");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl1";
            string dk = "";

            if (txtMa.Text.Trim() != "")
                dk += " MaTB LIKE N'%" + txtMa.Text + "%'";
            if (txtTen.Text.Trim() != "")
            {
                if (dk != "") dk += " AND ";
                dk += " TenTB LIKE N'%" + txtTen.Text + "%'";
            }

            if (dk != "")
                sql += " WHERE " + dk;

            LoadDuLieu(sql);
        }

        private void dgvThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMa.Text = dgvThietBi[0, e.RowIndex].Value.ToString();
                txtTen.Text = dgvThietBi[1, e.RowIndex].Value.ToString();
                cboTinhTrang.Text = dgvThietBi[2, e.RowIndex].Value.ToString();
                dtpNgay.Value = (DateTime)dgvThietBi[3, e.RowIndex].Value;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnTim.Enabled = false;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnTim.Enabled = true;
        }
    }
}
