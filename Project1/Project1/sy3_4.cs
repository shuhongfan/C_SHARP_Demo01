using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy3_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请分别输入矩形的长和宽:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle1 r1 = new Rectangle1(a,b);
            Console.WriteLine("矩形面积为:"+r1.Area());
            Console.WriteLine();
            Console.WriteLine("请分别输入椭圆的长半轴和短半轴:");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Ellipse e1 = new Ellipse(c,d);
            Console.WriteLine("椭圆的面积为:"+e1.Area());
        }
    }

    class Shape
    {
        public const double PI = 3.14159;
        protected double x,y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }
    }

    class Rectangle1:Shape
    {
        public Rectangle1()
        {
        }

        public Rectangle1(double x, double y) : base(x, y)
        {
        }

        public override double Area()
        {
            // return base.Area();
            return x * y;
        }
    }

    class Ellipse:Shape
    {
        public Ellipse(double x, double y) : base(x, y)
        {
        }

        public override double Area()
        {
            // return base.Area();
            return PI * x *y;
        }
    }
}
