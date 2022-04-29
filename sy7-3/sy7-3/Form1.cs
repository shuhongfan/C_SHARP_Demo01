using System.Drawing.Drawing2D;

namespace sy7_3
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
            LinearGradientBrush mybrush = new LinearGradientBrush
                (ClientRectangle, Color.Red, Color.Blue, LinearGradientMode.Horizontal);
            Font myfont = new Font("隶书",30, FontStyle.Bold);
            string ff = "海上生明月，天涯共此时。";
            g.DrawString(ff, myfont, mybrush, new PointF(10, 20));
        }
    }
}