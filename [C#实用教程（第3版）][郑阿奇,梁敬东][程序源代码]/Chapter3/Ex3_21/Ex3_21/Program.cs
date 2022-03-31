using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_21
{
    class Point
    {
        int x, y;
        public int X
        {
            get
            { return x; }
        }
        public int Y
        {
            get
            { return y; }
        }
        public Point()
        { x = y = 0; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Label
    {
        Point p1 = new Point();
        Point p2 = new Point(5, 10);
        public int Width      //  计算两点之间的宽度
        {
            get
            {
                return p2.X - p1.X;
            }
        }
        public int Height      // 计算两点之间的高度
        {
            get
            {
                return p2.Y - p1.Y;
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Label Label1 = new Label();
            Console.WriteLine("Label1.Width= {0} ", Label1.Width);
            Console.WriteLine("Label1.Height= {0} ", Label1.Height);
            Console.Read();
        }
    }
}
