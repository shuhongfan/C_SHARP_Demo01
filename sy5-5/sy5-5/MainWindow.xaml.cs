using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace sy5_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CancellationTokenSource cts;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyMethod(CancellationTokenSource cts)
        {
            var ct = cts.Token;
            while (ct.IsCancellationRequested == false)
            {
                System.Threading.Thread.Sleep(100);
            }
            ct.ThrowIfCancellationRequested();
        }

        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "开始执行任务...";

            cts = new CancellationTokenSource();
            var t1 = Task.Run(() => MyMethod(cts), cts.Token);
            textBlock1.Text += "\n任务状态(每秒获取1次):";
            while (t1.IsCanceled == false)
            {
                textBlock1.Text += t1.Status + "----";
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            try
            {
                await t1;
            } catch(Exception ex)
            {
                textBlock1.Text += "\n" + ex.Message;
                textBlock1.Text += String.Format("\nStatus:{0},IsCompleted:{1},IsFaulted:{2},IsCanceled:{3}",t1.Status,t1.IsCompleted,t1.IsFaulted,t1.IsCanceled);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }
    }
}
