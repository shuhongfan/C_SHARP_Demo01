using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDINotepad
{
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTxt MDIChild = new frmTxt();
            MDIChild.MdiParent = this;          	// 设置子窗体的父窗体
            MDIChild.Show();					// 创建并显示一个子窗体
        }

        private void 垂直平铺VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);  	// 垂直平铺子窗体
        }

        private void 层叠CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);     	// 层叠子窗体
        }

        private void 水平平铺HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);	// 水平平铺子窗体
        }

        private void 全部关闭LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();            	// 关闭子窗体
            }
        }
    }
}
