namespace sy3_5
{
    public partial class Form1 : Form
    {
        // ������ΪTravelPlan��ί��
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
            MessageBox.Show("��;��Ҫ��ʱ���ǣ�" + time + "Сʱ");

            Eat();
        }

        public void Eat()
        {
            MessageBox.Show("�ȳԶٴ��");
        }

        private double DriveCar(double distance)
        {
            // ������
            double speed = 100;
            double time = distance / speed;
            return time;
        }


        private double DriveMoto(double distance)
        {
            // ��Ħ��
            double speed = 60;
            double time = distance / speed;
            return time;
        }
        private double RideBike(double distance)
        {
            // �����г�
            double speed = 30;
            double time = distance / speed;
            return time;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string? goMethod = comboBox1.SelectedItem.ToString();

            if (goMethod=="������")
            {
                TravelPlan travelPlan = new TravelPlan(DriveCar);
                form1.Active(travelPlan);
            }
            else if (goMethod == "��Ħ��")
            {
                TravelPlan travelPlan = new TravelPlan(DriveMoto);
                form1.Active(travelPlan);
            }
            else if (goMethod == "�����г�")
            {
                TravelPlan travelPlan = new TravelPlan(RideBike);
                form1.Active(travelPlan);
            }
        }
    }
}