using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_10
{
    class MutexSample
    {
        private static Mutex mut = new Mutex();    	// 创建一个未命名的 Mutex 对象
        private const int numThreads = 3;          	// 所要创建的线程数

        static void Main(string[] args)
        {
            for (int i = 0; i < numThreads; i++)     	// 开启3个线程
            {

                Thread myThread = new Thread(new ThreadStart(MyThreadProc));
                myThread.Name = String.Format("线程{0}", i + 1);
                myThread.Start();
            }
            Console.Read();

        }
        private static void MyThreadProc()
        {
            mut.WaitOne();                   		// 阻止当前线程，直到收到信号
            Console.WriteLine("{0}开始执行", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("{0}停止执行\r\n", Thread.CurrentThread.Name);
            mut.ReleaseMutex();                	// 释放这个对象
        }

    }
}
