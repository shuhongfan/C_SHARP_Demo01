using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_4
{
    class ThreadApp
    {
        static int interval;
        static void DisplayNumbers()
        {
            // 获取当前运行线程的 Thread 对象实例
            Thread thisThread = Thread.CurrentThread;
            Console.WriteLine("线程: " + thisThread.Name + " 已开始运行.");
            // 循环计数直到结束，在指定的间隔输出当前计数值
            for (int i = 1; i <= 8 * interval; i++)
            {
                if (i % interval == 0)
                {
                    Console.WriteLine(thisThread.Name + ": 当前计数为 " + i);
                }
            }
            Console.WriteLine("线程 " + thisThread.Name + " 完成！");
        }

        static void Main(string[] args)
        {
            // 获取用户输入的数字
            Console.Write("请输入一个数字:");
            interval = int.Parse(Console.ReadLine());
            // 定义当前主线程对象的名字
            Thread thisThread = Thread.CurrentThread;
            thisThread.Name = "Main Thread";
            // 建立新线程对象
            ThreadStart workerStart = new ThreadStart(DisplayNumbers);
            Thread workerThread = new Thread(workerStart);
            workerThread.Name = "Worker Thread";
            workerThread.IsBackground = true;
            // 启动新线程
            workerThread.Start();
            // 挂起工作者线程
            //workerThread.Suspend();
            // 主线程同步进行计数
            DisplayNumbers();

            // 恢复工作者线程
            //workerThread.Resume();
            Console.Read();

        }
    }
}
