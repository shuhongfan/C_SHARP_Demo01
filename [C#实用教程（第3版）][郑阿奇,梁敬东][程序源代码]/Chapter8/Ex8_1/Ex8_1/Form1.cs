using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Ex8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string str in Directory.GetDirectories(@"C:\"))
            {
                TreeNode node = new TreeNode();
                node.Text = str;
                treeView1.Nodes.Add(node);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Clear();
            DirectoryInfo dirinfo = new DirectoryInfo(e.Node.Text);
            foreach (DirectoryInfo dir in dirinfo.GetDirectories())
            {
                listView1.Items.Add(dir.Name, 1);
            }

        }
    }
}
