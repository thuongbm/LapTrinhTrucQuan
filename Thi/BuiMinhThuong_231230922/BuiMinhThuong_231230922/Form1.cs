using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BuiMinhThuong_231230922
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                  AttachDbFilename=|DataDirectory|\ThietBi.mdf;
                  Integrated Security=True;"
            );

            LoadData("SELECT * FROM tblThietBi");
        }

        private void LoadData(string sql)
        {
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            dgvThietBi.DataSource = ds.Tables[0];
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tblThietBi(MaThietBi, TenThietBi, TinhTrang, NgayNhan) VALUES (@MaThietBi, @TenThietBi, @TinhTrang, @NgayNhan)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaThietBi", tbMaThietBi.Text);
            cmd.Parameters.AddWithValue("@TenThietBi", tbTenThietBi.Text);
            cmd.Parameters.AddWithValue("@TinhTrang", lbxTinhTrang.Text);
            cmd.Parameters.AddWithValue("@NgayNhan", dtNgayNhan.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            LoadData("SELECT * FROM tblThietBi");
            MessageBox.Show("Đã thêm thiết bị!");
        }

        private void tbMaThietBI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tblThietBi WHERE MaThietBi=@MaThietBi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaThietBi", tbMaThietBi.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData("SELECT * FROM tblThietBi");
            MessageBox.Show("Đã xóa thiết bị!");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tblThietBi SET TenThietBi=@TenThietBi, TinhTrang=@TinhTrang, NgayNhan=@NgayNhan WHERE MaThietBi=@MaThietBi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaThietBi", tbMaThietBi.Text);
            cmd.Parameters.AddWithValue("@TenThietBi", tbTenThietBi.Text);
            cmd.Parameters.AddWithValue("@TinhTrang", lbxTinhTrang.Text);
            cmd.Parameters.AddWithValue("@NgayNhan", dtNgayNhan.Value);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadData("SELECT * FROM tblThietBi");
            MessageBox.Show("Đã sửa thiết bị!");
        }

        private void btTimBaoHanh_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM tblThietBi WHERE TinhTrang = N'Bảo hành'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(ds);
            dgvThietBi.DataSource = ds;
        }
    }
}
