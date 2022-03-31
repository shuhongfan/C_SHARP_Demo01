using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Ex8_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStreamWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();   	// 实例化一个保存文件对话框
            sf.Filter = "txt文件|*.txt";				// 设置文件保存类型
            sf.AddExtension = true;                   	// 如果用户没有输入扩展名，自动追加后缀
            sf.Title = "写文本文件";                  	// 设置标题
            if (sf.ShowDialog() == DialogResult.OK)		// 如果用户单击了保存按钮
            {
                /*实例化一个文件流，FileMode.Create表示如果有此文件则覆盖，没有就创建*/
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                /*实例化一个StreamWriter，Encoding.Default表示使用系统当前的编码方式*/
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(this.textBox1.Text);			// 开始写入
                sw.Close();						// 关闭流
                fs.Close();						// 关闭流
            }

        }

        private void btnStreamRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();   	// 实例化一个打开文件对话框
            of.Filter = "txt文件|*.txt";				// 设置打开文件类型
            of.Title = "读文本文件";                  	// 设置标题
            if (of.ShowDialog() == DialogResult.OK)		// 如果用户单击了打开按钮
            {
                textBox1.BackColor = Control.DefaultBackColor;  // 设置textBox1的背景色
                /*实例化一个StreamReader，Encoding.Default表示使用系统当前的编码方式*/
                StreamReader sr = new StreamReader(of.FileName, Encoding.Default);
                textBox1.Text = sr.ReadToEnd();			// 读取流并显示 
                sr.Close();
            }

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "bin文件|*.bin";                	// 设置文件保存类型，bin为自定义的类型
            sf.AddExtension = true;
            sf.Title = "写二进制文件";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(textBox1.Text);
                textBox1.Text = "";
                bw.Close();
                fs.Close();
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "bin文件|*.bin";              		// 设置打开文件类型，bin为自定义的类型
            of.Title = "读二进制文件";
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = Control.DefaultBackColor;  // 设置textBox1的背景色
                FileStream fs = new FileStream(of.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = br.ReadString();
                fs.Close();
                br.Close();
            }

        }
    }
}
