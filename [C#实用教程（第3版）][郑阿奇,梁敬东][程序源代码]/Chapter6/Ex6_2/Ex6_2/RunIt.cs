using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_2
{
    class RunIt
    {
        static void Main(string[] args)
        {
            //给当前线程起名为"System Thread"
            Thread.CurrentThread.Name = "System Thread";
            Console.WriteLine(Thread.CurrentThread.Name + "'Status:"+ Thread.CurrentThread.ThreadState);
            Console.Read();

        }
    }
}
