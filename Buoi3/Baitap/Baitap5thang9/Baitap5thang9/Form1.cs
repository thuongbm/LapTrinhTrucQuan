namespace Baitap5thang9;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        addData();
//        throw new System.NotImplementedException();
    }
    
    private void addData()
    {
        listBox1.Items.Add("Kỹ thuật lập trình C#");
        listBox1.Items.Add("Tự học Visual C# trong 21 ngày");
        listBox1.Items.Add("Bài tập C#");
        listBox1.Items.Add(".NET toàn tập-tập 1");
        listBox1.Items.Add(".NET toàn tập-tập 2");
        listBox1.Items.Add(".NET toàn tập-tập 3");
        listBox1.Items.Add(".NET toàn tập-tập 4");
        listBox1.Items.Add("Cơ bản về XML");
        listBox1.Items.Add("Phân tích thiết kế hệ thống");
        listBox1.Items.Add("Sử dụng Word");
        listBox1.Items.Add("Đến với Word 2003");
    }

    private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string curItem = listBox1.SelectedItem.ToString();


        int index = listBox1.FindString(curItem);

        if (index != -1)
        {
            listBox1.Items.Add(curItem);
        }
        else
        {
            MessageBox.Show("Mat hang mua da co roi");
        }
    }
    
    private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        int index = listBox2.SelectedIndex;
        if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            listBox2.Items.RemoveAt(index);
    }
    
    private string HinhThucLL()
    {
        string a = "";
        if (checkBox1.Checked == true)
        {
            a += " " + checkBox1.Text;
        }
        if (checkBox4.Checked == true)
        {
            a += " " + checkBox4.Text;
        }
        if (checkBox3.Checked == true)
        {
            a += " " + checkBox3.Text;
        }
        return a;
    }

    private string ThanhToan()
    {
        string s = "";
        if (radioButton1.Checked == true)
        {
            s += radioButton1.Text;
        }
        else if (radioButton2.Checked == true)
        {
            s += radioButton2.Text;
        }
        else if (radioButton3.Checked == true)
        {
            s += radioButton3.Text;
        }
        return s;
    }

    
    private void label1_Click(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void label2_Click(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void label4_Click(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
//        throw new System.NotImplementedException();
    }
    
}