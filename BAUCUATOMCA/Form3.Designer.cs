﻿namespace BAUCUATOMCA
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.naptien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // naptien
            // 
            this.naptien.BackColor = System.Drawing.Color.CadetBlue;
            this.naptien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naptien.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.naptien.ForeColor = System.Drawing.Color.Snow;
            this.naptien.Location = new System.Drawing.Point(115, 459);
            this.naptien.Name = "naptien";
            this.naptien.Size = new System.Drawing.Size(145, 55);
            this.naptien.TabIndex = 12;
            this.naptien.Text = "Nạp tiền";
            this.naptien.UseVisualStyleBackColor = false;
            this.naptien.Click += new System.EventHandler(this.naptien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã thẻ cào";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "(nhập sai số tiền = mất thẻ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide03 BoosterNextFYBlack", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(99, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 52);
            this.label6.TabIndex = 10;
            this.label6.Text = "NẠP THẺ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seri";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(34, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 34);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(34, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.FormattingEnabled = true;
            this.textBox3.Items.AddRange(new object[] {
            " 10.000 VNĐ",
            " 20.000 VNĐ ",
            " 50.000 VNĐ",
            " 100.000 VNĐ",
            " 200.000 VNĐ",
            " 500.000 VNĐ",
            " 1.000.000 VNĐ"});
            this.textBox3.Location = new System.Drawing.Point(34, 377);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 36);
            this.textBox3.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 555);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.naptien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Nạp thẻ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button naptien;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox textBox3;
    }
}