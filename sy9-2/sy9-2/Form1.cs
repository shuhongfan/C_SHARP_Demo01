using System.Data;
using System.Data.SqlClient;

namespace sy9_2
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=shfomen7\sqlexpress;Initial Catalog=XSCJDB;Integrated Security=True";
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void display()
        {
            textBox3.Clear();
            using (sqlConnection = new SqlConnection(strcon))
            {
                sqlConnection.Open();
                string sql = "select * from xsb";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox3.Text += reader[0].ToString() + "\t\t" + reader[1].ToString() + "\t\t" + reader[2].ToString() + "\t\t" + reader[3].ToString().Split(" ")[0] + "   \t\t" + reader[4].ToString() + "\t\t" + reader[5].ToString() + "\r\n";
                    }
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                string id = textBox1.Text.Trim();
                string name = textBox2.Text.Trim();
                string xb;
                if (radioButton1.Checked)
                {
                    xb = "男";
                }
                else
                {
                    xb = "女";
                }

                string birthday = dateTimePicker1.Value.ToShortDateString().Split(" ")[0];
                string major = textBox4.Text.Trim();
                string credit = textBox5.Text.Trim();
                SqlCommand command = new SqlCommand();
                command.CommandText = "insert into xsb(XH,XM,XB,CSRQ,ZY,ZXF) VALUES('" + id + "','" + name + "','" + xb + "','" + birthday + "','" + major + "','" + credit + "')";
                command.CommandType = CommandType.Text;
                command.Connection = sqlcon;
                sqlcon.Open();
                if (command.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("插入成功!");
                    display();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}