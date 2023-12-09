using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUCUATOMCA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string a;
        private void naptien_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Vui lòng không bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (textBox3.SelectedIndex == 0)
                    a = "10000";
                if (textBox3.SelectedIndex == 1)
                    a = "20000";
                if (textBox3.SelectedIndex == 2)
                    a = "50000";
                if (textBox3.SelectedIndex == 3)
                    a = "100000";
                if (textBox3.SelectedIndex == 4)
                    a = "200000";
                if (textBox3.SelectedIndex == 5)
                    a = "500000";
                if (textBox3.SelectedIndex == 6)
                    a = "1000000";
                if (textBox3.SelectedIndex == -1)
                    a = "0";
                this.Close();

            }

        }

        public string trans() { return a; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }
    }
}
