namespace Baitap5thang9;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        listBox1 = new System.Windows.Forms.ListBox();
        listBox2 = new System.Windows.Forms.ListBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        radioButton3 = new System.Windows.Forms.RadioButton();
        radioButton2 = new System.Windows.Forms.RadioButton();
        radioButton1 = new System.Windows.Forms.RadioButton();
        groupBox2 = new System.Windows.Forms.GroupBox();
        checkBox4 = new System.Windows.Forms.CheckBox();
        checkBox3 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox1 = new System.Windows.Forms.CheckBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(53, 12);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(63, 23);
        label1.TabIndex = 0;
        label1.Text = "Họ tên";
        label1.Click += label1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(111, 12);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(178, 27);
        textBox1.TabIndex = 1;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(464, 16);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 2;
        label2.Text = "Điện thoại";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(570, 16);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(181, 27);
        textBox2.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(71, 56);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(194, 23);
        label3.TabIndex = 4;
        label3.Text = "Danh sách các mặt hàng";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(466, 56);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(129, 23);
        label4.TabIndex = 5;
        label4.Text = "hàng đặt mua";
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(71, 100);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(173, 104);
        listBox1.TabIndex = 6;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.Location = new System.Drawing.Point(475, 100);
        listBox2.Name = "listBox2";
        listBox2.Size = new System.Drawing.Size(184, 104);
        listBox2.TabIndex = 7;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton3);
        groupBox1.Controls.Add(radioButton2);
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Location = new System.Drawing.Point(71, 223);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(200, 152);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Phương thức thanh toán";
        // 
        // radioButton3
        // 
        radioButton3.Location = new System.Drawing.Point(16, 94);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new System.Drawing.Size(104, 24);
        radioButton3.TabIndex = 2;
        radioButton3.TabStop = true;
        radioButton3.Text = "Thẻ tín dụng";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.Location = new System.Drawing.Point(16, 64);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new System.Drawing.Size(104, 24);
        radioButton2.TabIndex = 1;
        radioButton2.TabStop = true;
        radioButton2.Text = "Sec";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        radioButton1.Location = new System.Drawing.Point(16, 34);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(104, 24);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "Tiền mặt";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(checkBox4);
        groupBox2.Controls.Add(checkBox3);
        groupBox2.Controls.Add(checkBox2);
        groupBox2.Controls.Add(checkBox1);
        groupBox2.Location = new System.Drawing.Point(475, 223);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(200, 152);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "Hình thức";
        // 
        // checkBox4
        // 
        checkBox4.Location = new System.Drawing.Point(24, 76);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new System.Drawing.Size(104, 24);
        checkBox4.TabIndex = 3;
        checkBox4.Text = "Fax";
        checkBox4.UseVisualStyleBackColor = true;
        // 
        // checkBox3
        // 
        checkBox3.Location = new System.Drawing.Point(24, 102);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(104, 24);
        checkBox3.TabIndex = 2;
        checkBox3.Text = "Email";
        checkBox3.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(34, 102);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(8, 8);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "checkBox2";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(24, 46);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(104, 24);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "Điện thoại";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(214, 394);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(92, 27);
        button1.TabIndex = 10;
        button1.Text = "Đồng ý";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(432, 394);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(102, 35);
        button2.TabIndex = 11;
        button2.Text = "Thoát";
        button2.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(listBox2);
        Controls.Add(listBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Text = "Form1";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}