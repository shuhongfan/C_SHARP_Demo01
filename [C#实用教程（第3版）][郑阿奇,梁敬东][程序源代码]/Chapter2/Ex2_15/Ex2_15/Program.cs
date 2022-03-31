using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_15
{
    class Schedule
    {
        static void Main(string[] args)
        {
            Console.Write("输入一个0~6之间的数字代表星期日至星期六");
            int week;
            string sline;
            RepIn: sline = Console.ReadLine();
            week = int.Parse(sline);
            switch (week)
            {
                case 0:
                case 6: Console.WriteLine("今天是周末，自行安排！");
                    break;
                case 1: Console.WriteLine("今天的课程是：哲学、英语、C#");
                    break;
                case 2: Console.WriteLine("今天的课程是：数学、英语、体育");
                    break;
                case 3: Console.WriteLine("今天下午政治学习");
                    goto case 1;
                case 4: Console.WriteLine("今天的课程是：数学、英语、C#");
                    break;
                case 5: Console.WriteLine("今天下午打扫卫生");
                    goto case 2;
                default: Console.WriteLine("输入数据有错，请重新输入！");
                    goto RepIn;
            }
            Console.Read();

        }
    }
}
