using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_2
{
    public class Time
    {
        private int hour, minute, second;
        public Time()
        {
            hour = minute = second = 0;
        }
        public Time(int h)
        {
            hour = h;
            minute = second = 0;
        }
        public Time(int h, int m)
        {
            hour = h;
            minute = m;
            second = 0;
        }
        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Time t1, t2, t3, t4;        // 对t1, t2, t3, t4分别调用不同的构造函数
            t1 = new Time();
            t2 = new Time(8);
            t3 = new Time(8, 30);
            t4 = new Time(8, 30, 30);
        }
    }
}
