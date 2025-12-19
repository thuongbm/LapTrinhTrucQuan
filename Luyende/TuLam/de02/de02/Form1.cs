using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de02
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadData(string sql)
        {
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            dgvMonHoc.DataSource = ds.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=|DataDirectory|\DuLieu.mdf;
                Integrated Security=True;";
            LoadData("SELECT * FROM tblMonHoc");
            btnSua.Enabled = btnXoa.Enabled = false;
            tbSoTin.MaxLength = 2;

        }

        private void tbSoTin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbSoTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];

                tbMaMon.Text = row.Cells["MaMon"].Value.ToString();
                tbTenMon.Text = row.Cells["TenMon"].Value.ToString();
                tbSoTin.Text = row.Cells["SoTin"].Value.ToString();

                tbMaMon.Enabled = false;

                btnSua.Enabled = btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaMon.Text))
            {
                MessageBox.Show("Bạn phải chọn môn học cần xóa!", "Thông báo");
            }

            DialogResult res = MessageBox.Show("Bạn có muốn xóa môn học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvMonHoc.SelectedRows)
                {
                    dgvMonHoc.Rows.Remove(row);
                } 
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSoTin.Text) || tbSoTin.Text == "0")
            {
                MessageBox.Show("Số tin phải là số nguyên dương!", "Thông báo");
                tbSoTin.Focus();
                return;
            }

            if (dgvMonHoc.CurrentRow != null)
            {
                dgvMonHoc.CurrentRow.Cells["TenMon"].Value = tbTenMon.Text;
                dgvMonHoc.CurrentRow.Cells["SoTin"].Value = tbSoTin.Text;

                tbMaMon.Enabled = true;
                btnSua.Enabled = false;
            }


        }

        private void lbMaMon_Click(object sender, EventArgs e)
        {

        }
    }
}
