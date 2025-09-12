using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string fontName = listBox1.SelectedItem.ToString();
                this.Font = new Font(fontName, 12);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        private void listBox1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hSR_Scroll(object sender, ScrollEventArgs e)
        {
            RN.Text = hSR.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            BN.Text = hSB.Value.ToString();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            GN.Text = hSG.Value.ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Green_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void ColorChange(object sender, EventArgs e)
        {
            int r = hSR.Value;
            int g = hSG.Value;
            int b = hSB.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            RN.Text = r.ToString();
            GN.Text = g.ToString();
            BN.Text = b.ToString();
        }

        private void ColorCharge(object sender, ScrollEventArgs e)
        {

        }
    }
}
