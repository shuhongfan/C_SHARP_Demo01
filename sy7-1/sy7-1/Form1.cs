namespace sy7_1
{
    public partial class Form1 : Form
    {
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 4);
            Point pt1 = new Point(50, 30);
            Point pt2 = new Point(200,30);
            g.DrawLine(myPen,pt1,pt2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red,4);
            g.DrawLine(myPen,350,30,450,130);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Green,4);
            g.DrawLine(myPen,600,30,700,130);
        }
    }
}