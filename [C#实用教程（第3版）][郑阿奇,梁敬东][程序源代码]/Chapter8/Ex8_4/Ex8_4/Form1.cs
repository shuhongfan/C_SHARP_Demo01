using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Ex8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Create(@"..\..\abc.txt");			// 在此项目目录下创建一个abc.txt文件
            listView1.GridLines = true;			// 显示各个记录的分隔线 
            listView1.FullRowSelect = true;		// 要选择就是一行 
            listView1.View = View.Details;			// 定义列表显示的方式 
            listView1.Scrollable = true;			// 需要时显示滚动条 
            listView1.MultiSelect = false; 			// 不可以多行选择 
            DirectoryInfo directory = new DirectoryInfo(@"..\..\");
            listView1.Columns.Add("文件名", 120, HorizontalAlignment.Right);		// 添加文件名列
            listView1.Columns.Add("大小", 40, HorizontalAlignment.Left);			// 添加大小列
            listView1.Columns.Add("创建时间", 130, HorizontalAlignment.Left);		// 添加创建时间列
            foreach (FileInfo finfo in directory.GetFiles())						// 遍历所有的文件
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Clear();

                lvi.SubItems[0].Text = finfo.Name;							// 文件名
                lvi.SubItems.Add(finfo.Length / 1024 + "KB");					// 大小
                lvi.SubItems.Add(finfo.CreationTime.ToString());					// 创建时间
                listView1.Items.Add(lvi);
            }

        }
    }
}
