
namespace BAUCUATOMCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int demsolanchoi = 0;
        private void chon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void naptien_Click(object sender, EventArgs e)
        {

            Form3 f1 = new Form3();
            f1.ShowDialog();
            int tienhientai = int.Parse(TienHienTai.Text);
            int tiennap = int.Parse(f1.trans());
            TienHienTai.Text = (tiennap + tienhientai).ToString();
            MessageBox.Show("Nạp: " + string.Format("{0:N0} VNĐ thành công!", f1.trans()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add(DateTime.Now.ToString() + "  | Nạp: " + string.Format("{0:N0}", f1.trans()));
            button1.Enabled = true;
            if (tienhientai >= 0)
                button1.Enabled = true;


            else
            {
                listBox1.Items.Add(DateTime.Now.ToString() + "  | Nạp không thành công!");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                cb_nai.Show();
                cb_bau.Show();
                cb_ga.Show();
                cb_ca.Show();
                cb_cua.Show();
                cb_tom.Show();
                cb_nai.Checked = false;
                cb_bau.Checked = false;
                cb_ga.Checked = false;
                cb_ca.Checked = false;
                cb_cua.Checked = false;
                cb_tom.Checked = false;
                chon.Enabled = false;
            }
            else
            {
                cb_nai.Hide();
                cb_bau.Hide();
                cb_ga.Hide();
                cb_ca.Hide();
                cb_cua.Hide();
                cb_tom.Hide();
                chon.Enabled = true;
            }
        }

        private void tienCuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Text = tienCuoc.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            tienCuoc.Text = button2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            

        }

        public string money() { return TienHienTai.Text; }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tienCuoc.Text = TienHienTai.Text;
        }

        private void tienCuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            demsolanchoi++;
            label7.Text = demsolanchoi.ToString();

            int tiencuoc = 0;
            int tong = 0;
            tiencuoc = int.Parse(tienCuoc.Text);
            tong = int.Parse(TienHienTai.Text);
            label4.Show();
            int count = 0;

            // kiểm tra chọn vật
            if (chon.SelectedIndex == -1)
            {
                MessageBox.Show("Mời bạn vui lòng chọn con vật để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chon.SelectedIndex = 0;
                return;
            }

            //kiểm tra tiền cược
            if (tienCuoc.Text == "")
            {
                MessageBox.Show("Mời bạn vui lòng đặt tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tienCuoc.Focus();
                return;
            }
            int tienhientai = int.Parse(TienHienTai.Text);

            //kiểm tra số tiền
            if (tienhientai <= 0)
            {
                MessageBox.Show("Bạn đã hết tiền, vui lòng nạp thêm tiền để tiếp tục chơi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = false;
                TienHienTai.Text = "0";
                tienhientai = 0;
                return;
            }
            Random r = new Random();
            Random r1 = new Random();
            Random r2 = new Random();

            

            var tieude = new List<string> {
                Application.StartupPath + "\\1.png",
                Application.StartupPath + "\\2.png",
                Application.StartupPath + "\\3.png",
                Application.StartupPath + "\\4.png",
                Application.StartupPath + "\\5.png",
                Application.StartupPath + "\\6.png"
            };

            var ckb = new List<string> {"cb_nai", "cb_bau", "cb_ga", "cb_ca", "cb_cua", "cb_tom" };

            int i_tieude = r.Next(tieude.Count);
            int i_tieude1 = r1.Next(tieude.Count);
            int i_tieude2 = r2.Next(tieude.Count);

            pictureBox1.ImageLocation = tieude[i_tieude];
            pictureBox2.ImageLocation = tieude[i_tieude1];
            pictureBox3.ImageLocation = tieude[i_tieude2];

            for (int i = 0; i < 6; i++)
            {
                if (chon.SelectedIndex == i)
                {
                    if (pictureBox1.ImageLocation == tieude[i])
                        count++;
                    if (pictureBox2.ImageLocation == tieude[i])
                        count++;
                    if (pictureBox3.ImageLocation == tieude[i])
                        count++;
                    if (count == 0)
                    {
                        if (tienhientai <= 0)
                        {
                            TienHienTai.Text = "0";
                            label4.Text = "0";
                        }   
                        else
                        {
                            TienHienTai.Text = (tong - tiencuoc).ToString();
                            label4.Text = (count - tiencuoc).ToString();
                        }
                        
                    }
                    else
                    {
                        TienHienTai.Text = (tong + tiencuoc * count).ToString();
                        label4.Text = "+" + (tiencuoc * count).ToString();
                    }
                }
            }
            label3.Show();
            listBox1.Items.Add(DateTime.Now.ToString() + "  | " + label4.Text + " [" + chon.Text + "]  ×" + count);
        }
    }
}