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
    public partial class Update : Form
    {
        public static string path;
        public static string info;

        public Update()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelNowTime.Text = string.Format("现在时间: {0}", DateTime.Now.ToLongTimeString());
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }

        }

        private void button1_Click(object sender, EventArgs e) // 提交
        {
            info = "学号" + sno.Text + "\r\n";
            info += "姓名："+sname.Text+ "\r\n";
            foreach (Control control in gbxSex.Controls)
            {
                if ((control as RadioButton).Checked)
                {
                    info += "性别：" + (control as RadioButton).Text;
                }
            }

            info += "爱好:";
            foreach (Control control in gBxFavor.Controls)
            {
                if ((control as CheckBox).Checked)
                {
                    info+=(control as CheckBox).Text+" ";
                }
            }

            info += "\r\n出生日期：" + dateTimePicker1.Text;
            info += "\r\n专业：" + comboBox1.Text;
            info += "\r\n奖惩情况：\r\n";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                info += listBox1.Items[i].ToString() + "\r\n";
            }

            info += "备注信息：";
            if (textBox3.Text!="")
            {
                info += "\r\n" + textBox3.Text;
            }
            else
            {
                info += "\r\n无";
            }

            Welcome.browserForm = new Browser();
            Welcome.browserForm.Show();
            this.Opacity = 0;
        }

        private void button2_Click(object sender, EventArgs e)  // 退出
        {
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)  // 浏览
        {
            // 设置文件对话框显示的初始目录
            this.openFileDialog1.InitialDirectory = @"D:\My Documents";
            // 设置当前选定筛选器字符串以决定对话框中"文档类型"选项
            this.openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpeg文件(*.jpg)|*.jpg";
            // 设置对话框中当前选定筛选器的索引
            this.openFileDialog1.FilterIndex = 3;
            // 关闭对话框，还原当前的目录
            this.openFileDialog1.RestoreDirectory = true;
            // 设置对话框的标题
            this.openFileDialog1.Title = "选择学生照片";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = this.openFileDialog1.FileName;    // 获取文件路径
            }
            pictureBox1.Image = Image.FromFile(path);   // 加载照片
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // 首先清除所有现有项
            listBox1.Items.Clear();
            // 用Add方法插入新项
            listBox1.Items.Add("2017年度校优秀团员");
            listBox1.Items.Add("2017年度一等奖学金");
            // 用Insert方法插入新项
            listBox1.Items.Insert(2, "2017年度校运动会10000米游泳冠军");
            // 使第二项选中
            listBox1.SelectedIndex = 1;
            // 获得添加的记录数
            string msg = string.Format("已添加奖惩记录{0}条", listBox1.Items.Count);
            MessageBox.Show(msg, "提示");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
