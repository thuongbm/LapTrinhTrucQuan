using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidduListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        List<String> ds = new List<String>();
        private void them_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            item.Text = mahang1.Text;
            item.SubItems.Add(tenhang1.Text);
            item.SubItems.Add(soluong1.Text);
            if (ds.Contains(mahang.Text) == true)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
            }
            if (mahang1.Text=="")
            {
                MessageBox.Show("Mã hàng không được để trống");
            }
            if (tenhang1.Text == "")
            {
                MessageBox.Show("Tên hàng không được để trống");
            }
            if (soluong1.Text == "")
            {
                MessageBox.Show("Số lượng không được để trống");
            }
            else
            {
                ds.Add(mahang1.Text);
                listView1.Items.Add(item);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = mahang1.Text;
                listView1.Items[i].SubItems[1].Text = tenhang1.Text;
                listView1.Items[i].SubItems[2].Text = soluong1.Text;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn xóa không?", "Xóa", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    ds.Remove(listView1.Items[i].SubItems[0].Text);
                    listView1.Items[i].Remove();
                }
            }
        }

        private void listView1_SelectedIndex(object sender, MouseEventArgs e)
        {
            ListViewItem Is = new ListViewItem();
            if (listView1.SelectedItems.Count > 0)
            {
                Is = listView1.SelectedItems[0];
                mahang.Text = Is.Text;
                tenhang.Text = Is.SubItems[1].Text;
                soluong.Text = Is.SubItems[2].Text;
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng");
            }
        }
    }
}
