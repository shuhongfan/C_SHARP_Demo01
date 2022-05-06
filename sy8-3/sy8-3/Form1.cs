using System.Text;

namespace sy8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "txt文件 | *.txt";
            sf.Title = "写文本文件";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                sw.Write(this.textBox1.Text);
                textBox1.Text = "";
                sw.Close();
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "txt文件 | *.txt";
            of.Title = "读文本文件";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = Control.DefaultBackColor;
                StreamReader sr = new StreamReader(of.FileName,Encoding.Default);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bin文件 | *.bin";
            sf.AddExtension = true;
            sf.Title = "写二进制文件";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName,FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(textBox1.Text);
                textBox1.Text = "";
                bw.Close();
                fs.Close();
            }
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "bin文件 | *.bin";
            of.Title = "读取二进制文件";
            if (of.ShowDialog()==DialogResult.OK)
            {
                textBox1.BackColor = Control.DefaultBackColor;
                FileStream fs = new FileStream(of.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = br.ReadString();
                fs.Close();
                br.Close();
            }
        }
    }
}