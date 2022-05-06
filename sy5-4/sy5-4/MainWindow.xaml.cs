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

namespace sy5_4
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

        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            textBlock1.Text = "";
            var p1 = new Progress<int>();
            p1.ProgressChanged += (s, n) =>
            {
                progressBar1.Value = n;
                textBlock1.Text = " " + n.ToString() + "%";
            };

            var p2 = new Progress<int>();
            p2.ProgressChanged += (s, n) =>
            {
                progressBar2.Value = n;
                textBlock2.Text = " " + n.ToString() + "%";
            };

            //传递cts.Token表示该任务接收取消通知
            var t1 = Task.Run(() => MyMethod(p1, cts.Token, 500), cts.Token);
            //传递CancellationToken.None表示该任务不可取消
            var t2 = Task.Run(() => MyMethod(p2, CancellationToken.None, 800));

            try
            {
                await t1;
                if (t1.Exception == null)
                {
                    textBlock1.Text += " 任务完成";
                }
            }
            catch(Exception ex)
            {
                textBlock1.Text += "  " + ex.Message;
            }

            try
            {
                await t2;
                if (t2.Exception == null)
                {
                    textBlock2.Text += " 任务完成";
                }
            }
            catch (Exception ex)
            {
                textBlock2.Text += "  " + ex.Message;
            }

            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }

        private void MyMethod(IProgress<int> progress,CancellationToken ct,int delay)
        {
            int p = 0;
            while(p<100 && ct.IsCancellationRequested == false)
            {
                System.Threading.Thread.Sleep(delay);
                p += 10;
                progress.Report(p);
            }
            ct.ThrowIfCancellationRequested();
        }
    }
}
