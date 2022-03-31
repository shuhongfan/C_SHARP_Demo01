using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Black);			// 定义颜色为黑色的笔
            Graphics g = this.CreateGraphics();				// 创建Graphics对象
            g.DrawRectangle(myPen, 40, 20, 200, 120);		// 用笔画矩形

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();					// 创建Graphics对象
            SolidBrush mySBrush = new SolidBrush(Color.Red);	// 定义颜色为红色的画刷
            g.FillRectangle(mySBrush, 40, 20, 200, 120);			// 用画刷给矩形着色

        }
    }
}
