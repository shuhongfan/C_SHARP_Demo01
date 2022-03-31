using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MDIChild = new Form2();
            // 设置子窗体的父窗体
            MDIChild.MdiParent = this;
            // 创建一个MDI子窗体并显示
            MDIChild.Show();
        }
    }
}
