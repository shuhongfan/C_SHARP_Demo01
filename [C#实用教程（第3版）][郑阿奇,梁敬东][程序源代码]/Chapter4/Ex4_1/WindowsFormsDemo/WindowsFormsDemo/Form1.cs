using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("输入不完整!");
                return;
            }
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            textBox3.Text = c.ToString();
        }
    }
}
