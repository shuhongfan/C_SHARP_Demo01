namespace sy7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap myBitmap = new Bitmap("C:\\Users\\shuho\\Documents\\Code\\C_SHARP_Demo01\\sy7-4\\sy7-4\\boy.jpg");
            e.Graphics.DrawImage(myBitmap, 0, 0);
        }
    }
}