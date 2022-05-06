namespace sy8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Create(@"..\..\abc.txt");
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Scrollable = true;
            listView1.MultiSelect = false;

            DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\");
            listView1.Columns.Add("文件名", 120, HorizontalAlignment.Right);
            listView1.Columns.Add("大小", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("创建时间", 130, HorizontalAlignment.Left);

            foreach (FileInfo info in directoryInfo.GetFiles())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Clear();

                lvi.SubItems[0].Text = info.Name;
                lvi.SubItems.Add(info.Length / 1024 + "KB");
                lvi.SubItems.Add(info.CreationTime.ToString());
                listView1.Items.Add(lvi);

            }
        }
    }
}