using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Ex7_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //获得一个图形对象的引用
            Graphics g = this.CreateGraphics();
            LinearGradientBrush myBrush = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.Horizontal);
            Font myFont = new Font("Times New Roman", 24);
            FontFamily[] families = FontFamily.GetFamilies(e.Graphics);

            Font font;
            string familyString;
            float spacing = 0f;
            int top = families.Length > 10 ? 10 : families.Length;
            for (int i = 0; i < top; i++)
            {
                font = new Font(families[i], 16, FontStyle.Bold);
                familyString = "This is the " + families[i].Name + "family.";
                e.Graphics.DrawString(familyString, font, Brushes.Black, new PointF(0, spacing));
                spacing += font.Height + 3;
            }

        }
    }
}
