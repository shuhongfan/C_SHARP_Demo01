using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Account acc = new Account(200);		// 实例化 Account 对象，开始位置为 200
            for (int i = 0; i < 10; i++)				// 实例化 10 个线程
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }
            for (int i = 0; i < 10; i++)				// 开启这 10 个线程
            {
                threads[i].Start();
            }
            Console.Read();

        }
    }
}
