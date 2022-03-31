using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Ex8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] di = DriveInfo.GetDrives();		// 获取驱动器
            foreach (DriveInfo d in di)
            {
                comboBox1.Items.Add(d.Name);    		// 添加到comboBox1中
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();					// 清空节点
            foreach (string str in Directory.GetDirectories(comboBox1.Text))
            {
                TreeNode node = new TreeNode();
                node.Text = str;
                treeView1.Nodes.Add(node);
            }

        }
    }
}
