using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Đề_03
{
    public partial class Form1 : Form
    {
        ProcessDatabase db = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        //txtSoTC chỉ được nhập số nguyên dương với độ dài tối đa là 2 ký tự
        private void txtSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)){
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if(txtSoTC.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }
            if(txtSoTC.Text.Length >= 2)
            {
                e.Handled = true;
                return;
            }

        }

        private void txtMaMon_Enter(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox != null)
            {
                currentTextBox.BackColor = Color.Yellow;
            }
        }

        private void txtMaMon_Leave(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox != null)
            {
                // Đổi màu nền về TRẮNG
                currentTextBox.BackColor = Color.White;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // 1. Lấy giá trị từ cả 3 textbox
            string maMon = txtMaMon.Text.Trim();
            string tenMon = txtTenMon.Text.Trim();
            string soTC = txtSoTC.Text.Trim();

            // 2. Bắt đầu xây dựng câu SQL
            string sqlQuery = "SELECT MaMon, TenMon, SoTC FROM tblMonHoc";

            // Tạo một danh sách để chứa các điều kiện (WHERE)
            List<string> conditions = new List<string>();

            // Nếu ô MaMon có nhập -> thêm điều kiện MaMon
            if (!string.IsNullOrEmpty(maMon))
            {
                conditions.Add("MaMon LIKE N'%" + maMon + "%'");
            }

            // Nếu ô TenMon có nhập -> thêm điều kiện TenMon
            if (!string.IsNullOrEmpty(tenMon))
            {
                conditions.Add("TenMon LIKE N'%" + tenMon + "%'");
            }

            // Nếu ô SoTC có nhập -> thêm điều kiện SoTC
            if (!string.IsNullOrEmpty(soTC))
            {
                // (Chúng ta có thể dùng '=' vì đã validate chỉ nhập số)
                conditions.Add("SoTC = " + soTC);
            }

            // 3. Nối các điều kiện lại bằng "AND"
            // Nếu có ít nhất 1 điều kiện (list > 0)
            if (conditions.Count > 0)
            {
                // Nối tất cả các điều kiện bằng " AND "
                sqlQuery += " WHERE " + string.Join(" AND ", conditions);
            }
            // Nếu list rỗng (cả 3 ô đều trống) -> câu SQL giữ nguyên
            // -> Tự động thực hiện yêu cầu "Nếu không nhập gì sẽ đưa ra tất cả"

            // 4. Thực thi truy vấn (Phần này giống như cũ)
            DataTable dt;
            try
            {
                dt = db.DocBang(sqlQuery); // Gọi hàm DocBang từ class của bạn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn CSDL: " + ex.Message);
                return;
            }

            // 5. Hiển thị dữ liệu lên DataGridView
            dgvMonHoc.DataSource = dt;

            // 6. Hiển thị thông báo (Yêu cầu 4 & 5)
            int soLuong = dt.Rows.Count;
            if (soLuong > 0)
            {
                MessageBox.Show($"Tìm thấy {soLuong} môn học.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không có thông tin môn học nào.", "Thông báo");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin môn học nào.", "Thông báo");
                return; // Dừng lại, không làm gì cả
            }

            // 1. Khởi tạo các đối tượng Excel
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Lỗi: Không thể khởi tạo Excel. Bạn đã cài đặt Microsoft Excel chưa?");
                return;
            }

            excelApp.Visible = true; // Hiển thị ứng dụng Excel lên

            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            worksheet.Name = "DanhSachMonHoc"; // Đặt tên cho Sheet

            // 2. Ghi Tiêu đề cột (Dòng 1 trong Excel)
            // Duyệt qua các cột trong DataGridView
            for (int i = 0; i < dgvMonHoc.Columns.Count; i++)
            {
                // Gán giá trị HeaderText (Tên cột) vào ô Excel
                worksheet.Cells[1, i + 1] = dgvMonHoc.Columns[i].HeaderText;
            }

            // 3. Ghi Dữ liệu (Từ dòng 2 trở đi)
            // Duyệt qua các dòng trong DataGridView
            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                // Duyệt qua các ô trong dòng đó
                for (int j = 0; j < dgvMonHoc.Columns.Count; j++)
                {
                    // Gán giá trị của ô (Value) vào ô Excel
                    // worksheet.Cells[i + 2, ...] vì dòng 1 đã là tiêu đề
                    worksheet.Cells[i + 2, j + 1] = dgvMonHoc.Rows[i].Cells[j].Value;
                }
            }

            // 4. Tự động căn chỉnh độ rộng cột
            worksheet.Columns.AutoFit();
        }
    }
}
