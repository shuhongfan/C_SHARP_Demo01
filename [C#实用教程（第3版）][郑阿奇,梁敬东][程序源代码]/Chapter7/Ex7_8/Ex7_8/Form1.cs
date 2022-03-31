using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 4);
            Point p1 = new Point(40, 40);
            Point p2 = new Point(70, 20);
            Point p3 = new Point(110, 70);

            Point p4 = new Point(70, 130);
            Point[] points = { p1, p2, p3, p4 };
            g.DrawPolygon(myPen, points);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 4);
            PointF p1 = new PointF(160.0F, 40.0F);
            PointF p2 = new PointF(190.0F, 20.0F);
            PointF p3 = new PointF(230.0F, 70.0F);
            PointF p4 = new PointF(190.0F, 130.0F);
            PointF[] points = { p1, p2, p3, p4 };
            g.DrawPolygon(myPen, points);

        }
    }
}
