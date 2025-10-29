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

namespace ThucHanh17_10
{
    public partial class frmMatHang : Form
    {

        //Khai báo các biến toàn cục 
        SqlConnection con;//Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu 
        SqlCommand cmd;//Khai báo đối tượng thực hiện các câu lệnh truy vấn 
        SqlDataAdapter dap;//Khai báo đối tượng gắn kết DataSource với DataSet 
        DataSet ds;//Đối tượng chứa dữ liệu tại local
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng Connection 
            con = new SqlConnection();
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu 
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\QLBanHang.mdf;Integrated Security=True;";
            //Gọi phương thức Load dự liệu 
            LoadDuLieu("Select * from [Table]");
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
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng 
            dap = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet 
            dap.Fill(ds);
            //Gắn dữ liệu từ DataSet lên DataGridView 
            dgvKetQua.DataSource = ds.Tables[0];
        }
        //Phương thức ẩn hiện các control ở groupbox chi tiết 
        private void HienChiTiet(Boolean hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy 
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        //Chức năng tìm kiếm 
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Cập nhật trên nhãn tiêu đề 
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";
            //Cấm nút Sửa và Xóa 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Viet cau lenh SQL cho tim kiem 
            String sql = "SELECT * FROM [Table]";
            String dk = "";
            //Tim theo MaSP khac rong 
            if (txtTKMaSP.Text.Trim() != "")
            {
                dk += " MaSP like '%" + txtTKMaSP.Text + "%'";
            }
            //kiem tra TenSP va MaSP khac rong 
            if (txtTKTenSP.Text.Trim() != "" && dk != "")
            {
                dk += " AND TenSP like N'%" + txtTKTenSP.Text + "%'";
            }
            //Tim kiem theo TenSP khi MaSP la rong 
            if (txtTKTenSP.Text.Trim() != "" && dk == "")
            {
                dk += " TenSP like N'%" + txtTKTenSP.Text + "%'";
            }
            //Ket hoi dk 
            if (dk != "")
            {
                sql += " WHERE" + dk;
            }
            //Goi phương thức Load dữ liệu kết hợp điều kiện tìm kiếm 
            LoadDuLieu(sql);
        }

        //Sự kiện thêm mới mặt hàng 
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            //Xoa trang GroupBox chi tiết sản phẩm 
            XoaTrangChiTiet();
            //Cam nut sua xoa 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết 
            HienChiTiet(true);
        }

        //Sư kiện khi người dùng chọn một hàng trên DataGridView 
        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua 
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid 
            try
            {
                txtMaSP.Text = dgvKetQua[0, e.RowIndex].Value.ToString();
                txtTenSP.Text = dgvKetQua[1, e.RowIndex].Value.ToString();
                dtpNgaySX.Value = (DateTime)dgvKetQua[2, e.RowIndex].Value;
                dtpNgayHH.Value = (DateTime)dgvKetQua[3, e.RowIndex].Value;
                txtDonVi.Text = dgvKetQua[4, e.RowIndex].Value.ToString();
                txtDonGia.Text = dgvKetQua[5, e.RowIndex].Value.ToString();
                txtGhiChu.Text = dgvKetQua[6, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        //Sự kiện Click của nút sửa 
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cập nhật tiêu đề 
            lblTieuDe.Text = "CẬP NHẬT MẶ HÀNG";
            //Ẩn hai nút Thêm và Sửa 
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện gropbox chi tiết 
            HienChiTiet(true);
        }

        //Sự kiện Click của nút Xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng 
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtMaSP.Text + " không ? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                //Hiện gropbox chi tiết 
                HienChiTiet(true);
            }
        }

        // Sự kiện click vào button Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";

            // Mở kết nối nếu chưa mở
            if (con.State != ConnectionState.Open)
                con.Open();

            // ==== KIỂM TRA DỮ LIỆU NHẬP VÀO ====

            // 1. Tên sản phẩm
            if (txtTenSP.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenSP, "Bạn không để trống tên sản phẩm!");
                return;
            }
            errChiTiet.Clear();

            // 2. Ngày sản xuất
            if (dtpNgaySX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!");
                return;
            }
            errChiTiet.Clear();

            // 3. Ngày hết hạn
            if (dtpNgayHH.Value < dtpNgaySX.Value)
            {
                errChiTiet.SetError(dtpNgayHH, "Ngày hết hạn nhỏ hơn ngày sản xuất!");
                return;
            }
            errChiTiet.Clear();

            // 4. Đơn vị
            if (txtDonVi.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vị!");
                return;
            }
            errChiTiet.Clear();

            // 5. Đơn giá
            if (txtDonGia.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!");
                return;
            }
            errChiTiet.Clear();


            // ==== XỬ LÝ CÂU LỆNH SQL THEO CHỨC NĂNG ====

            // --- THÊM MỚI ---
            if (btnThem.Enabled == true)
            {
                // Kiểm tra mã sản phẩm
                if (txtMaSP.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtMaSP, "Bạn không để trống mã sản phẩm!");
                    return;
                }

                // Kiểm tra trùng mã sản phẩm
                sql = $"SELECT COUNT(*) FROM [Table] WHERE MaSP = N'{txtMaSP.Text}'";
                cmd = new SqlCommand(sql, con);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    errChiTiet.SetError(txtMaSP, "Mã sản phẩm đã tồn tại trong cơ sở dữ liệu!");
                    return;
                }
                errChiTiet.Clear();

                // Câu lệnh Insert
                sql = $@"
            INSERT INTO [Table] (MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
            VALUES (
                N'{txtMaSP.Text}',
                N'{txtTenSP.Text}',
                '{dtpNgaySX.Value:yyyy-MM-dd}',
                '{dtpNgayHH.Value:yyyy-MM-dd}',
                N'{txtDonVi.Text}',
                N'{txtDonGia.Text}',
                N'{txtGhiChu.Text}'
            )";
            }

            // --- SỬA ---
            else if (btnSua.Enabled == true)
            {
                sql = $@"
            UPDATE [Table] SET
                TenSP = N'{txtTenSP.Text}',
                NgaySX = '{dtpNgaySX.Value:yyyy-MM-dd}',
                NgayHH = '{dtpNgayHH.Value:yyyy-MM-dd}',
                DonVi = N'{txtDonVi.Text}',
                DonGia = '{txtDonGia.Text}',
                GhiChu = N'{txtGhiChu.Text}'
            WHERE MaSP = N'{txtMaSP.Text}'";
            }

            // --- XÓA ---
            else if (btnXoa.Enabled == true)
            {
                sql = $"DELETE FROM [Table] WHERE MaSP = N'{txtMaSP.Text}'";
            }

            // ==== THỰC THI CÂU LỆNH SQL ====
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            // Cập nhật lại DataGrid
            LoadDuLieu("SELECT * FROM [Table]");

            // Đóng kết nối
            con.Close();

            // Cập nhật trạng thái các nút
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }



        // ======================= NÚT HỦY =======================

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Thiết lập lại trạng thái ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;

            // Xóa trắng form nhập
            XoaTrangChiTiet();

            // Ẩn phần nhập chi tiết
            HienChiTiet(false);
        }



        // ======================= NÚT THOÁT =======================

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }

        private void XoaTrangChiTiet()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();

            // Xóa luôn lỗi hiển thị nếu có
            errChiTiet.Clear();

            // Đưa con trỏ về ô đầu tiên
            txtMaSP.Focus();
        }
    }
}
