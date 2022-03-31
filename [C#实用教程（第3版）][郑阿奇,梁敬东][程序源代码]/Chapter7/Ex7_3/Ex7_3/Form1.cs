﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex7_3
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 4);		// 实例化一个宽度为4的黑色画笔
            Point pt1 = new Point(30, 30);			// 实例化开始点
            Point pt2 = new Point(160, 30);
            g.DrawLine(myPen, pt1, pt2);			// 画横线

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 4);		// 实例化一个宽度为4的红色画笔
            g.DrawLine(myPen, 210, 30, 210, 130);		// 画竖线

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Green, 4);		// 实例化一个宽度为4的绿色画笔
            g.DrawLine(myPen, 300, 30, 400, 130);		// 画斜线

        }
    }
}
