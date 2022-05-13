using System.Data.SqlClient;

namespace sy9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string strcon = @"Data Source=shfomen7\sqlexpress;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection sqlConnection;
            using (sqlConnection = new SqlConnection(strcon))
            {
                sqlConnection.Open();
                MessageBox.Show("数据库连接状态：" + sqlConnection.State.ToString());
                
            }
            MessageBox.Show("数据库连接状态：" + sqlConnection.State.ToString());

        }
    }
}