namespace sy6_2
{
    public partial class Form1 : Form
    {
        private delegate void WriteTextBox(char ch);

        private WriteTextBox writeTextBox;

        public Form1()
        {
            InitializeComponent();
            // 允许跨线程调用
            CheckForIllegalCrossThreadCalls = false;
        }

        private void DoTsk1()
        {
            if (checkBox1.Checked == true)
            {
                groupBox2.Text = "运行中……";
                groupBox2.Refresh();
                textBox1.Clear();
                textBox1.Refresh();
                writeTextBox = new WriteTextBox(WriTextBox1);
                WriTxt(writeTextBox);
                groupBox2.Text = "任务1";
                textBox3.Focus();
                textBox3.SelectAll();
            }
        }

        private void DoTsk2()
        {
            if (checkBox2.Checked == true)
            {
                groupBox2.Refresh();
                groupBox3.Text = "运行中……";
                groupBox3.Refresh();
                textBox2.Clear();
                textBox2.Refresh();
                //
                writeTextBox = new WriteTextBox(WriTextBox2);
                WriTxt(writeTextBox);
                //
                groupBox3.Text = "任务2";
                textBox3.Focus();
                textBox3.SelectAll();
            }
        }

        private void WriTxt(WriteTextBox wMethod)
        {
            string strdata = textBox3.Text;
            for (int i = 0; i < strdata.Length; i++)
            {
                wMethod(strdata[i]);
                //间歇延时
                DateTime now = DateTime.Now;
                while (now.AddSeconds(1) > DateTime.Now) { }
            }
        }

        private void WriTextBox1(char ch)
        {
            textBox1.AppendText(ch + "\r");
        }

        private void WriTextBox2(char ch)
        {
            textBox2.AppendText(ch + "\r");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart doTask1 = new ThreadStart(DoTsk1);
            Thread tsk1Thread = new Thread(doTask1);
            tsk1Thread.Start();
            ThreadStart doTask2 = new ThreadStart(DoTsk2);
            Thread tsk2Thread = new Thread(doTask2);
            tsk2Thread.Start();
        }
    }
}