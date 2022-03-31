using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_3
{
    class Point
    {
        public double x, y;
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;                  // 当this在实例构造函数中使用时，
            this.y = y;                  // 它的值就是对该构造的对象的引用。
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            Point b = new Point(3, 4);    // 用构造函数初始化对象
            Console.WriteLine("a.x={0}, a.y={1}", a.x, a.y);
            Console.WriteLine("b.x={0}, b.y={1}", b.x, b.y);
            Console.Read();
        }
    }
}
