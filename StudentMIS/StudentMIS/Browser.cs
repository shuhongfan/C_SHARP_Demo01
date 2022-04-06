using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentMIS.Update;

namespace StudentMIS
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            textBox1.Text = info;
            Welcome.updateForm = new Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome.updateForm.Show();
            this.Hide();
        }
    }
}
