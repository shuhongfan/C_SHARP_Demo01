using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuStrip_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuStrip_Open_Click(object sender, EventArgs e)
        {
            MyForm myForm = new MyForm();
            myForm.Show();
        }
    }
}
