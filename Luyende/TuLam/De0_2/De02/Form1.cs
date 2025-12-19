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

namespace De02
{
    public partial class Form1 : Form
    {
        int maMonCu = -1;

        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SUBJECT\LAPTRINHTRUCQUAN\LUYENDE\TULAM\DE0_2\DE02\DMON.MDF;Integrated Security=True";

        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strCon);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi CSDL. Chi tiet: " + ex.Message);
            }

            HienThiDuLieu();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void HienThiDuLieu()
        {
            try
            {
                string querry = "SELECT * FROM MON";
                SqlDataAdapter da = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi hien thi du lieu. Chi tiet: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string querry = "INSERT INTO Mon (MaMon, TenMon, SoTC) Values (@ma, @ten, @tc)";

                SqlCommand cmd = new SqlCommand(querry, conn);

                cmd.Parameters.AddWithValue("@ma", int.Parse(tbMaMon.Text));
                cmd.Parameters.AddWithValue("@ten", tbTenMon.Text);
                cmd.Parameters.AddWithValue("@tc", int.Parse(tbSoTC.Text));


                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Them du lieu thanh cong");
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Them du lieu that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi them du lieu. Chi tiet: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbMaMon.Text))
                {
                    MessageBox.Show("Vui long chon mon hoc can xoa");
                    return;
                }

                DialogResult result = MessageBox.Show("Ban co chac muon xoa mon hoc nay khong?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string querry = "DELETE FROM Mon WHERE MaMon = @ma";
                SqlCommand cmd = new SqlCommand(querry, conn);

                cmd.Parameters.AddWithValue("@ma", int.Parse(tbMaMon.Text));

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Xoa du lieu thanh cong");
                    HienThiDuLieu();

                    tbMaMon.Clear();
                    tbTenMon.Clear();
                    tbSoTC.Clear();
                }
                else
                {
                    MessageBox.Show("Xoa du lieu that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi xoa du lieu. Chi tiet: " + ex.Message);
            }
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                tbMaMon.Text = dgvMon.Rows[rowIndex].Cells["MaMon"].Value.ToString();
                tbTenMon.Text = dgvMon.Rows[rowIndex].Cells["TenMon"].Value.ToString();
                tbSoTC.Text = dgvMon.Rows[rowIndex].Cells["SoTC"].Value.ToString();

                tbMaMon.ReadOnly = true;
            }

            maMonCu = int.Parse(dgvMon.Rows[rowIndex].Cells["MaMon"].Value.ToString());

            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (string.IsNullOrEmpty(tbMaMon.Text))
                {
                    MessageBox.Show("Vui long chon mon hoc can sua");
                    return;
                }

                if (string.IsNullOrEmpty(tbTenMon.Text) || string.IsNullOrEmpty(tbSoTC.Text))
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                    return;
                }

                string querry = "UPDATE Mon SET TenMon = @ten, SoTC = @tc WHERE MaMon = @ma";
                SqlCommand cmd = new SqlCommand(querry, conn);

                cmd.Parameters.AddWithValue("@ten", tbTenMon.Text);
                cmd.Parameters.AddWithValue("@tc", int.Parse(tbSoTC.Text));

                cmd.Parameters.AddWithValue("@ma", tbMaMon.Text);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Sua du lieu thanh cong");
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Sua du lieu that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi sua du lieu. Chi tiet: " + ex.Message);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            tbMaMon.Clear();
            tbTenMon.Clear();
            tbSoTC.Clear();
            tbMaMon.ReadOnly = false;
            btnThem.Enabled = true;
        }
    }
}
