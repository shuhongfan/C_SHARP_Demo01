using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_5
{
    class Point
    {
        private int x, y;
        public Point()
        {
            x = 0; y = 0;
            Console.WriteLine("Point() constructor : {0} ", this);
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Point(x,y) constructor : {0} ", this);
        }
    }
    class Circle : Point
    {
        private double radius;
        public Circle()     		// 缺省约定调用基类的无参构造函数Point()
        {
            Console.WriteLine("Circle () constructor : {0} ", this);
        }
        public Circle(double radius)
            : base()
        {
            this.radius = radius;
            Console.WriteLine("Circle (radius) constructor : {0} ", this);
        }
        public Circle(int x, int y, double radius)
            : base(x, y)
        {
            this.radius = radius;
            Console.WriteLine("Circle (x, y, radius) constructor : {0} ", this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            Circle b = new Circle(3.5);
            Circle c = new Circle(1, 1, 4.8);
            Console.Read();
        }
    }
}
