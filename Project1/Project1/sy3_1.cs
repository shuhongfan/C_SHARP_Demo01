using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// (1) Rectangle类中包括有字段长度length、宽度width，以公开方式访问字段的属性Length和Width;
// (2)为Rectangle类添加一个构造函数（带两个参数，分别对应length和width）；
// (3)成员方法Area()用来计算矩形面积。
// (4)在Main()方法中创建Rectangle类对象，通过属性给长度和宽度赋值，要求输出矩形的长、宽及面积值。

namespace Project1
{
    internal class sy3_1
    {
        static void Main(String[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine("矩形的长为：{0:f2}", r.Length);
            Console.WriteLine("矩形的宽为：{0:f2}",r.Width);
            Console.WriteLine("矩形的面积：{0:f2}", r.area());
        }
    }

    class Rectangle
    {
        private double length { get; set; }
        private double width { get; set; }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return length; }
            set { length = value; }
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double area()
        {
            return this.length * this.width;
        }
    }
}
