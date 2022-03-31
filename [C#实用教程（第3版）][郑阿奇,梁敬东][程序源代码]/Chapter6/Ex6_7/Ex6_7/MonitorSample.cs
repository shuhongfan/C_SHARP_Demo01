using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_7
{
    public class Cell
    {
        int cellContents;			//  Cell对象里边的内容
        bool readerFlag = false;		// 状态标志，为true时可以读取，为false则正在写入
        public int ReadFromCell()
        {
            lock (this)			//  Lock关键字保证了什么，请大家看前面对lock的介绍
            {
                if (!readerFlag)	// 如果现在不可读取
                {
                    try
                    {
                        // 等待WriteToCell方法中调用Monitor.Pulse()方法
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine("Consume: {0}", cellContents);
                readerFlag = false;	// 重置readerFlag标志，表示消费行为已经完成
                Monitor.Pulse(this);	// 通知WriteToCell()方法（该方法在另外一个线程中执行，等待中）
            }
            return cellContents;
        }
        public void WriteToCell(int n)
        {
            lock (this)
            {
                if (readerFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        // 当同步方法（指Monitor类除Enter之外的方法）在非同步的代码区被调用
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        // 当线程在等待状态的时候中止
                        Console.WriteLine(e);
                    }
                }
                cellContents = n;
                Console.WriteLine("Produce: {0}", cellContents);
                readerFlag = true;
                Monitor.Pulse(this);	//通知另外一个线程中正在等待的 ReadFromCell() 方法
            }
        }
    }
    // 生产者类
    public class CellProd
    {
        Cell cell;								// 被操作的 Cell 对象
        int quantity = 1;							// 生产者生产次数，初始化为1
        public CellProd(Cell box, int request)
        {
            // 构造函数
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            for (int looper = 1; looper <= quantity; looper++)
                cell.WriteToCell(looper);				// 生产者向操作对象写入信息
        }
    }
    // 消费者类
    public class CellCons
    {
        Cell cell;
        int quantity = 1;
        public CellCons(Cell box, int request)
        {
            cell = box;
            quantity = request;
        }
        public void ThreadRun()
        {
            int valReturned;
            for (int looper = 1; looper <= quantity; looper++)
                valReturned = cell.ReadFromCell();		// 消费者从操作对象中读取信息
        }
    }

    class MonitorSample
    {
        static void Main(string[] args)
        {
            // 一个标志位，如果是 0 表示程序没有出错，如果是 1 表明有错误发生
            int result = 0;
            Cell cell = new Cell();
            // 下面使用 cell 初始化 CellProd 和 CellCons 两个类，生产和消费次数均为 20 次
            CellProd prod = new CellProd(cell, 20);
            CellCons cons = new CellCons(cell, 20);
            Thread producer = new Thread(new ThreadStart(prod.ThreadRun));
            Thread consumer = new Thread(new ThreadStart(cons.ThreadRun));
            // 生产者线程和消费者线程都已经被创建，但是没有开始执行
            try
            {
                producer.Start();
                consumer.Start();
                producer.Join();
                consumer.Join();
                Console.ReadLine();
            }
            catch (ThreadStateException e)
            {
                // 当线程因为所处状态的原因而不能执行被请求的操作
                Console.WriteLine(e);
                result = 1;
            }
            catch (ThreadInterruptedException e)
            {
                // 当线程在等待状态的时候中止
                Console.WriteLine(e);
                result = 1;
            }
            // 尽管Main()函数没有返回值，但下面这条语句可以向父进程返回执行结果
            Environment.ExitCode = result;

        }
    }
}
