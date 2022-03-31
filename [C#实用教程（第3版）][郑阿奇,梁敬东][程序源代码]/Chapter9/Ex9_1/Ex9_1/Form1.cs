using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ex9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection sqlcon;
            using (sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                MessageBox.Show("数据库连接状态：" + sqlcon.State.ToString(), "第一个对话框");
            }

            MessageBox.Show("数据库连接状态：" + sqlcon.State.ToString(), "第二个对话框");

        }
    }
}
