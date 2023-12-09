namespace BAUCUATOMCA
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.chon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tienCuoc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TienHienTai = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cb_ca = new System.Windows.Forms.CheckBox();
            this.cb_cua = new System.Windows.Forms.CheckBox();
            this.cb_tom = new System.Windows.Forms.CheckBox();
            this.cb_ga = new System.Windows.Forms.CheckBox();
            this.cb_bau = new System.Windows.Forms.CheckBox();
            this.cb_nai = new System.Windows.Forms.CheckBox();
            this.naptien = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(948, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn";
            // 
            // chon
            // 
            this.chon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chon.FormattingEnabled = true;
            this.chon.Items.AddRange(new object[] {
            "Nai",
            "Bầu",
            "Gà",
            "Cá",
            "Cua",
            "Tôm"});
            this.chon.Location = new System.Drawing.Point(948, 100);
            this.chon.Name = "chon";
            this.chon.Size = new System.Drawing.Size(233, 28);
            this.chon.TabIndex = 3;
            this.chon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(948, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiền cược";
            // 
            // tienCuoc
            // 
            this.tienCuoc.FormattingEnabled = true;
            this.tienCuoc.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "20",
            "50",
            "100",
            "200",
            "500",
            "1000",
            "5000"});
            this.tienCuoc.Location = new System.Drawing.Point(948, 194);
            this.tienCuoc.Name = "tienCuoc";
            this.tienCuoc.Size = new System.Drawing.Size(233, 28);
            this.tienCuoc.TabIndex = 3;
            this.tienCuoc.SelectedIndexChanged += new System.EventHandler(this.tienCuoc_SelectedIndexChanged);
            this.tienCuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tienCuoc_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(1012, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "SPIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("#9Slide03 Maven Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(371, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = global::BAUCUATOMCA.Properties.Resources._6;
            this.pictureBox3.Location = new System.Drawing.Point(383, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::BAUCUATOMCA.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(224, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::BAUCUATOMCA.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(59, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // TienHienTai
            // 
            this.TienHienTai.AutoSize = true;
            this.TienHienTai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TienHienTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TienHienTai.Location = new System.Drawing.Point(60, 33);
            this.TienHienTai.Name = "TienHienTai";
            this.TienHienTai.Size = new System.Drawing.Size(72, 28);
            this.TienHienTai.TabIndex = 6;
            this.TienHienTai.Text = "10000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TienHienTai);
            this.groupBox2.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(969, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiền hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 SFU Helvetica Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(584, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 SFU Helvetica Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(237, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide03 SFU Helvetica Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiền xơi được:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1062, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lần chơi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1179, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(371, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(541, 310);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // cb_ca
            // 
            this.cb_ca.AutoSize = true;
            this.cb_ca.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ca.Location = new System.Drawing.Point(513, 327);
            this.cb_ca.Name = "cb_ca";
            this.cb_ca.Size = new System.Drawing.Size(18, 17);
            this.cb_ca.TabIndex = 9;
            this.cb_ca.UseVisualStyleBackColor = true;
            this.cb_ca.Visible = false;
            // 
            // cb_cua
            // 
            this.cb_cua.AutoSize = true;
            this.cb_cua.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_cua.Location = new System.Drawing.Point(676, 327);
            this.cb_cua.Name = "cb_cua";
            this.cb_cua.Size = new System.Drawing.Size(18, 17);
            this.cb_cua.TabIndex = 9;
            this.cb_cua.UseVisualStyleBackColor = true;
            this.cb_cua.Visible = false;
            // 
            // cb_tom
            // 
            this.cb_tom.AutoSize = true;
            this.cb_tom.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_tom.Location = new System.Drawing.Point(831, 327);
            this.cb_tom.Name = "cb_tom";
            this.cb_tom.Size = new System.Drawing.Size(18, 17);
            this.cb_tom.TabIndex = 9;
            this.cb_tom.UseVisualStyleBackColor = true;
            this.cb_tom.Visible = false;
            // 
            // cb_ga
            // 
            this.cb_ga.AutoSize = true;
            this.cb_ga.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ga.Location = new System.Drawing.Point(831, 171);
            this.cb_ga.Name = "cb_ga";
            this.cb_ga.Size = new System.Drawing.Size(18, 17);
            this.cb_ga.TabIndex = 9;
            this.cb_ga.UseVisualStyleBackColor = true;
            this.cb_ga.Visible = false;
            // 
            // cb_bau
            // 
            this.cb_bau.AutoSize = true;
            this.cb_bau.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_bau.Location = new System.Drawing.Point(676, 171);
            this.cb_bau.Name = "cb_bau";
            this.cb_bau.Size = new System.Drawing.Size(18, 17);
            this.cb_bau.TabIndex = 9;
            this.cb_bau.UseVisualStyleBackColor = true;
            this.cb_bau.Visible = false;
            // 
            // cb_nai
            // 
            this.cb_nai.AutoSize = true;
            this.cb_nai.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_nai.Location = new System.Drawing.Point(514, 171);
            this.cb_nai.Name = "cb_nai";
            this.cb_nai.Size = new System.Drawing.Size(18, 17);
            this.cb_nai.TabIndex = 9;
            this.cb_nai.UseVisualStyleBackColor = true;
            this.cb_nai.Visible = false;
            // 
            // naptien
            // 
            this.naptien.BackColor = System.Drawing.Color.CadetBlue;
            this.naptien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naptien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naptien.Font = new System.Drawing.Font("#9Slide03 Cabin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.naptien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.naptien.Location = new System.Drawing.Point(68, 100);
            this.naptien.Name = "naptien";
            this.naptien.Size = new System.Drawing.Size(137, 43);
            this.naptien.TabIndex = 21;
            this.naptien.Text = "Nạp tiền";
            this.naptien.UseVisualStyleBackColor = false;
            this.naptien.Click += new System.EventHandler(this.naptien_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(1076, 134);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(105, 24);
            this.checkBox7.TabIndex = 25;
            this.checkBox7.Text = "Chọn nhiều";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(948, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button4.Location = new System.Drawing.Point(1100, 597);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 36);
            this.button4.TabIndex = 29;
            this.button4.Text = "Đổi card";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button5.Location = new System.Drawing.Point(1087, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 35);
            this.button5.TabIndex = 30;
            this.button5.Text = "ALL IN";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 429);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 204);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#9Slide03 SFU Helvetica Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(118, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lịch sử";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1224, 678);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.naptien);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.cb_tom);
            this.Controls.Add(this.cb_cua);
            this.Controls.Add(this.cb_ca);
            this.Controls.Add(this.cb_ga);
            this.Controls.Add(this.cb_bau);
            this.Controls.Add(this.cb_nai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tienCuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẦU CUA TÔM CÁ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ComboBox chon;
        private Label label2;
        private ComboBox tienCuoc;
        private Button button1;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label TienHienTai;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
        private CheckBox cb_ca;
        private CheckBox cb_cua;
        private CheckBox cb_tom;
        private CheckBox cb_ga;
        private CheckBox cb_bau;
        private CheckBox cb_nai;
        private Button naptien;
        private CheckBox checkBox7;
        private Button button2;
        private Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button5;
        private ListBox listBox1;
        private Label label8;
    }
}