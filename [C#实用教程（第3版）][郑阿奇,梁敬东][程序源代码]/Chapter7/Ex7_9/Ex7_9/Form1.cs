using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Ex7_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            LinearGradientBrush myBrush = new
            LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow,LinearGradientMode.Vertical);
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 100);
            Point point3 = new Point(100, 0);
            Point[] curvePoints = { point1, point2, point3 };
            e.Graphics.FillPolygon(myBrush, curvePoints);
            g.FillRectangle(myBrush, new RectangleF(50, 50, 100, 100));
            g.FillPie(myBrush, new Rectangle(0, 0, 300, 300), 0, 90);

        }
    }
}
