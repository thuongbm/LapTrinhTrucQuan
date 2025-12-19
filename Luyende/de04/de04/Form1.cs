using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace de04
{
    public partial class Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LAPTOP-255KNM82\sqlexpress;Initial Catalog=DuLieu;Integrated Security=True";
        //do máy thuongdz có SQL Server LocalDB đã có database tên NhanVienDB đang attach nên không dùng cái dưới này được
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            // Chọn cả dòng thay vì chỉ ô
            dgNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNhanVien.MultiSelect = false;

            // Gán sự kiện SelectionChanged
            dgNhanVien.SelectionChanged += dgNhanVien_SelectionChanged;

            btnSua.Enabled = btnXoa.Enabled = false;

        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaNV.Text = dgNhanVien.Rows[i].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgNhanVien.Rows[i].Cells["TenNV"].Value.ToString();
                txtSDT.Text = dgNhanVien.Rows[i].Cells["SDT"].Value.ToString();
                txtMucLuong.Text = dgNhanVien.Rows[i].Cells["MucLuong"].Value.ToString();
                cbPhongBan.Text = dgNhanVien.Rows[i].Cells["PhongBan"].Value.ToString();

                string gioiTinh = dgNhanVien.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rbNam.Checked = true;
                }
                else if (gioiTinh == "Nữ")
                {
                    rbNu.Checked = true;
                }

                btnSua.Enabled = btnXoa.Enabled = true;
            }
        }

        private void lbMaNV_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM tblNhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgNhanVien.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string gt = rbNam.Checked ? "Nam" : "Nữ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra trùng mã NV
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tblNhanVien WHERE MaNV = @MaNV", conn);
                checkCmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm mới nếu không trùng
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tblNhanVien VALUES(@MaNV, @TenNV, @SoDT, @GioiTinh, @PhongBan, @Luong, @Anh, @MatKhau)", conn);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@SoDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                cmd.Parameters.AddWithValue("@PhongBan", cbPhongBan.Text);
                cmd.Parameters.AddWithValue("@Luong", txtMucLuong.Text);
                cmd.Parameters.AddWithValue("@Anh", DBNull.Value);
                cmd.Parameters.AddWithValue("@MatKhau", "123");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblNhanVien WHERE MaNV = @MaNV", conn);
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                        LoadData();
                        ClearFields(); // xoá dữ liệu ở các ô nhập để tránh hiểu nhầm
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để xóa!", "Lỗi");
                    }
                }
            }
        }

        private void dgNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgNhanVien.SelectedRows[0];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtSDT.Text = row.Cells["SoDT"].Value.ToString();
                txtMucLuong.Text = row.Cells["MucLuong"].Value.ToString();
                cbPhongBan.Text = row.Cells["PhongBan"].Value.ToString();

                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                rbNam.Checked = (gioiTinh == "Nam");
                rbNu.Checked = (gioiTinh == "Nữ");

                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnThem.Enabled = false;
            }
        }

        void Form1_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            dgNhanVien.ClearSelection();
        }

        private void ClearFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtMucLuong.Clear();
            cbPhongBan.SelectedIndex = -1;
            rbNam.Checked = rbNu.Checked = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gt = rbNam.Checked ? "Nam" : "Nữ";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update tblNhanVien SET TenNV = @TenNV, SoDT = @SoDT, MucLuong = @MucLuong, PhongBan = @PhongBan, GioiTinh = @GioiTinh WHERE MaNV = @MaNV", conn);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@SoDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@MucLuong", txtMucLuong.Text);
                cmd.Parameters.AddWithValue("@PhongBan", cbPhongBan.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", gt);
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }
    }
}

