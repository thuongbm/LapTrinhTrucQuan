namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hSR = new System.Windows.Forms.HScrollBar();
            this.hSB = new System.Windows.Forms.HScrollBar();
            this.hSG = new System.Windows.Forms.HScrollBar();
            this.Red = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.Blue = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.RN = new System.Windows.Forms.Label();
            this.BN = new System.Windows.Forms.Label();
            this.GN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Time new romand",
            "App"});
            this.listBox1.Location = new System.Drawing.Point(220, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 82);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(184, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(604, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.GN);
            this.groupBox1.Controls.Add(this.BN);
            this.groupBox1.Controls.Add(this.RN);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Controls.Add(this.hSG);
            this.groupBox1.Controls.Add(this.hSB);
            this.groupBox1.Controls.Add(this.hSR);
            this.groupBox1.Location = new System.Drawing.Point(121, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu nền";
            // 
            // hSR
            // 
            this.hSR.Location = new System.Drawing.Point(198, 52);
            this.hSR.Name = "hSR";
            this.hSR.Size = new System.Drawing.Size(301, 26);
            this.hSR.TabIndex = 0;
            this.hSR.TabStop = true;
            this.hSR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorChange);
            // 
            // hSB
            // 
            this.hSB.Location = new System.Drawing.Point(198, 98);
            this.hSB.Name = "hSB";
            this.hSB.Size = new System.Drawing.Size(301, 26);
            this.hSB.TabIndex = 1;
            this.hSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorCharge);
            // 
            // hSG
            // 
            this.hSG.Location = new System.Drawing.Point(198, 154);
            this.hSG.Name = "hSG";
            this.hSG.Size = new System.Drawing.Size(301, 26);
            this.hSG.TabIndex = 2;
            this.hSG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorCharge);
            // 
            // Red
            // 
            this.Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Red.Location = new System.Drawing.Point(60, 52);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(108, 26);
            this.Red.TabIndex = 6;
            this.Red.Text = "Red";
            this.Red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(549, 107);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(10, 23);
            this.hScrollBar3.TabIndex = 6;
            // 
            // Blue
            // 
            this.Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Blue.Location = new System.Drawing.Point(60, 98);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(108, 26);
            this.Blue.TabIndex = 7;
            this.Blue.Text = "Blue";
            this.Blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Blue.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Green
            // 
            this.Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Green.Location = new System.Drawing.Point(60, 154);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(108, 26);
            this.Green.TabIndex = 8;
            this.Green.Text = "Green";
            this.Green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // RN
            // 
            this.RN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RN.Location = new System.Drawing.Point(524, 52);
            this.RN.Name = "RN";
            this.RN.Size = new System.Drawing.Size(48, 26);
            this.RN.TabIndex = 9;
            this.RN.Text = "0";
            this.RN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RN.UseCompatibleTextRendering = true;
            this.RN.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // BN
            // 
            this.BN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BN.Location = new System.Drawing.Point(524, 98);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(48, 26);
            this.BN.TabIndex = 10;
            this.BN.Text = "0";
            this.BN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BN.UseCompatibleTextRendering = true;
            // 
            // GN
            // 
            this.GN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GN.Location = new System.Drawing.Point(524, 154);
            this.GN.Name = "GN";
            this.GN.Size = new System.Drawing.Size(48, 26);
            this.GN.TabIndex = 11;
            this.GN.Text = "0";
            this.GN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GN.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBox1;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hSR;
        private System.Windows.Forms.HScrollBar hSG;
        private System.Windows.Forms.HScrollBar hSB;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Label RN;
        private System.Windows.Forms.Label GN;
        private System.Windows.Forms.Label BN;
    }
}

