using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text==string.Empty||pwd.Text==string.Empty)
            {
                MessageBox.Show("信息不完整!","提示");
                return;
            }

            if (!username.Text.Equals("admin") || !pwd.Text.Equals("admin"))
            {
                MessageBox.Show("用户名或密码不正确!", "提示");
            }
            else
            {
                Welcome.updateForm.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pwd.Text = "";
        }
    }
}
