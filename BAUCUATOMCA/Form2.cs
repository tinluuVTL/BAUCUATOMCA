using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAUCUATOMCA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            label2.Text = f.money();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form4 frm = new Form4();
            int doitien = int.Parse(label2.Text);
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (doitien > 25000)
                    frm.ShowDialog();
                else
                    MessageBox.Show("Bạn không đủ tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
