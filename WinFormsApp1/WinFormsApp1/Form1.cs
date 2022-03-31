namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty||textBox2.Text==string.Empty)
            {
                MessageBox.Show("输入不完整");
                return;
            }

            // int a = int.Parse(textBox1.Text);
            // int b = int.Parse(textBox2.Text);
            // int c = a + b;
            // textBox3.Text = c.ToString();

            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }
    }
}