using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sy5_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Threading.CancellationTokenSource cts;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            cts = new System.Threading.CancellationTokenSource();
            textBlock1.Text = "开始执行任务.......";

            try
            {
                await Task.Run(()=>Method1(),cts.Token);
                textBlock1.Text += "\n任务1执行完毕";
                var sum = await Task.Run(() => Method2(), cts.Token);
                textBlock1.Text += "\n任务2(计算1到1000的和)结果为：" + sum;
                var a = await Task.Run(()=>Method3(39,8),cts.Token);
                textBlock1.Text += string.Format("\n任务3(求39除以8的商和余数)的结果为：{0},{1}\n",a.Item1,a.Item2);

                while (true)
                {
                    textBlock1.Text += await Task.Run(() => Method1("a"), cts.Token);
                    textBlock1.Text += await Task.Run(() => Method1("b"), cts.Token);
                }
            }
            catch (OperationCanceledException)
            {
                textBlock1.Text += "\n任务被取消";
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }

        public void Method1()
        {
            System.Threading.Thread.Sleep(100);
        }

        public string Method1(string s)
        {
            System.Threading.Thread.Sleep(100);
            return s;
        }

        public int Method2()
        {
            var range = Enumerable.Range(1, 1000);
            int n = range.Sum();
            return n;
        }

        public Tuple<int,int> Method3(int n1,int n2)
        {
            var result = Tuple.Create(n1 / n2,n1%n2);
            System.Threading.Thread.Sleep(100);
            return result;
        }
    }
}
