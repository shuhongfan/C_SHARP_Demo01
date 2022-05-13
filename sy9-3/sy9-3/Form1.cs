using System.Data;
using System.Data.SqlClient;

namespace sy9_3
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=shfomen7\sqlexpress;Initial Catalog=XSCJDB;Integrated Security=True";
        DataSet myst = new DataSet();
        private SqlConnection sqlConnection;
        private SqlDataAdapter myda;

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
            using (sqlConnection = new SqlConnection(strcon))
            {
                sqlConnection.Open();
                string sql = "select * from xsb";
                SqlCommand command = new SqlCommand(sql, sqlConnection);
                myda = new SqlDataAdapter(command);
                myst.Tables.Clear();
                myda.Fill(myst, "xsb");
                dataGridView1.DataSource = myst.Tables["xsb"];
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
                myda = new SqlDataAdapter(command);
                myda.Fill(myst, "xsb");
                MessageBox.Show("插入成功!");
                display();
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