using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_1
{
    public class Area
    {
        public readonly double Radius;   // Radius是只读字段
        private double x, y;
        public double Size;
        public static double Sum = 0.0;
        public Area()
        {
            Radius = 1.0;        		//  通过构造函数对radius赋值
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Area s1 = new Area();
            Console.WriteLine("Radius={0}, Size={1},Sum={2}", s1.Radius, s1.Size, Area.Sum);
            //  静态字段通过类访问Area.Sum，实例字段通过对象访问s1.Size
            Console.Read();
        }
    }
}
