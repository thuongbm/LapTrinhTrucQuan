namespace Dialogs
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
            this.luu = new System.Windows.Forms.Button();
            this.mo = new System.Windows.Forms.Button();
            this.chu = new System.Windows.Forms.Button();
            this.mau = new System.Windows.Forms.Button();
            this.luu1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(641, 63);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(105, 28);
            this.luu.TabIndex = 0;
            this.luu.Text = "luu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // mo
            // 
            this.mo.Location = new System.Drawing.Point(641, 121);
            this.mo.Name = "mo";
            this.mo.Size = new System.Drawing.Size(105, 28);
            this.mo.TabIndex = 1;
            this.mo.Text = "mo";
            this.mo.UseVisualStyleBackColor = true;
            // 
            // chu
            // 
            this.chu.Location = new System.Drawing.Point(641, 184);
            this.chu.Name = "chu";
            this.chu.Size = new System.Drawing.Size(105, 28);
            this.chu.TabIndex = 2;
            this.chu.Text = "chu";
            this.chu.UseVisualStyleBackColor = true;
            // 
            // mau
            // 
            this.mau.Location = new System.Drawing.Point(641, 247);
            this.mau.Name = "mau";
            this.mau.Size = new System.Drawing.Size(105, 28);
            this.mau.TabIndex = 3;
            this.mau.Text = "mau";
            this.mau.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mau);
            this.Controls.Add(this.chu);
            this.Controls.Add(this.mo);
            this.Controls.Add(this.luu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button mo;
        private System.Windows.Forms.Button chu;
        private System.Windows.Forms.Button mau;
        private System.Windows.Forms.SaveFileDialog luu1;
    }
}

