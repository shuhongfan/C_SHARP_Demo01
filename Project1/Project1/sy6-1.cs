using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy6_1
    {
        private static int interval;

        static void DisplayNumbers()
        {
            // 获取当前运行线程的Thread对象实例
            Thread thisThread = Thread.CurrentThread;
            Console.WriteLine("线程："+thisThread.Name+" 已经开始运行");
            for (int i = 1; i <= 8*interval; i++)
            {
                if (i%interval==0)
                {
                    Console.WriteLine(thisThread.Name+": 当前计数为:"+i);
                }
            }
            Console.WriteLine("线程："+thisThread.Name+"完成");
        }

        static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            interval = int.Parse(Console.ReadLine());

            Thread thisThread = Thread.CurrentThread;
            thisThread.Name = "Main Thread";

            Thread workThread = new Thread(new ThreadStart(DisplayNumbers));
            workThread.Name = "Worker Thread";

            workThread.Start();
            workThread.Suspend();
            DisplayNumbers();
            workThread.Resume();
        }
    }
}
