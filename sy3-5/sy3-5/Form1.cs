namespace sy3_5
{
    public partial class Form1 : Form
    {
        // 定义名为TravelPlan的委托
        public delegate double TravelPlan(double s);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Active(TravelPlan travelPlan)
        {
            double distance = 200;
            double time = travelPlan(distance);
            MessageBox.Show("旅途需要的时间是：" + time + "小时");

            Eat();
        }

        public void Eat()
        {
            MessageBox.Show("先吃顿大餐");
        }

        private double DriveCar(double distance)
        {
            // 开汽车
            double speed = 100;
            double time = distance / speed;
            return time;
        }


        private double DriveMoto(double distance)
        {
            // 骑摩托
            double speed = 60;
            double time = distance / speed;
            return time;
        }
        private double RideBike(double distance)
        {
            // 骑自行车
            double speed = 30;
            double time = distance / speed;
            return time;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string? goMethod = comboBox1.SelectedItem.ToString();

            if (goMethod=="开汽车")
            {
                TravelPlan travelPlan = new TravelPlan(DriveCar);
                form1.Active(travelPlan);
            }
            else if (goMethod == "骑摩托")
            {
                TravelPlan travelPlan = new TravelPlan(DriveMoto);
                form1.Active(travelPlan);
            }
            else if (goMethod == "骑自行车")
            {
                TravelPlan travelPlan = new TravelPlan(RideBike);
                form1.Active(travelPlan);
            }
        }
    }
}