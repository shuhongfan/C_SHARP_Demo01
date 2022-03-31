using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//绘制正弦曲线
private void DrawSin()
{
    int x1,x2;
    double y1,y2;
    double a;
    Pen myPen = new Pen(Color.Blue, 3);
    x1 = x2 = 0;
    y1 = y2 = panel1.Height / 2;
    for (x2 = 0; x2 < panel1.Width; x2++)
    {
        a = 2 * Math.PI * x2 / panel1.Width;
        y2 = Math.Sin(a);
        y2 = (1 - y2) * panel1.Height / 2;
        panel1.CreateGraphics().DrawLine(myPen, x1, (float)y1, x2, (float)y2);
        x1 = x2;
        y1 = y2;
    }
}
// 绘制正切曲线
private void DrawTan()
{
    int x1, x2;
    double y1, y2;
    double a;
    Pen myPen = new Pen(Color.Yellow, 2);
    x1 = x2 = 0;
    y1 = y2 = panel1.Height / 2;
    for (x2 = 0; x2 < panel1.Width; x2++)
    {
        a = 2 * Math.PI * x2 / panel1.Width;
        y2 = Math.Tan(a);
        y2 = (1 - y2) * panel1.Height / 2;
        panel1.CreateGraphics().DrawLine(myPen, x1, (float)y1, x2, (float)y2);
        x1 = x2;
        y1 = y2;
    }
}
//绘制余弦曲线
private void DrawCos()
{
    int x1, x2;
    double y1, y2;
    double a;
    Pen myPen = new Pen(Color.Red, 2);
    x1 = x2 = 0;
    y1 = y2 = panel1.Height / 2;
    for (x2 = 0; x2 < panel1.Width; x2++)
    {
        a = 2 * Math.PI * x2 / panel1.Width;
        y2 = Math.Cos(a);
        y2 = (1 - y2) * panel1.Height / 2;
        panel1.CreateGraphics().DrawLine(myPen, x1, (float)y1, x2, (float)y2);
        x1 = x2;
        y1 = y2;
    }
}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


    }

        private void button1_Click(object sender, EventArgs e)
        {
                switch (comboBox1.Text)
    {
            case "y=sin(x)":
                DrawSin();
                break;
            case "y=cos(x)":
                DrawCos();
                break;
            case "y=tan(x)":
                DrawTan();

                break;
            default:
                break;
    }

        }

        
    }
}
