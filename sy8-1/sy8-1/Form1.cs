namespace sy8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(e.Node.Text);
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                listView1.Items.Add(dir.Name, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String str in Directory.GetDirectories(@"C:\"))
            {
                TreeNode node = new TreeNode();
                node.Text=str;
                treeView1.Nodes.Add(node);
            }
        }
    }
}