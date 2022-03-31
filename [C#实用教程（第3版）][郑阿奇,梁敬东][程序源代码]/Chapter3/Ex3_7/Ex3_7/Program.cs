using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_7
{
    public class Point
    {
        private int x, y;
        ~Point()
        {
            Console.WriteLine("Point's  destructor ");
        }
    }
    public class Circle : Point
    {
        private double radius;
        ~Circle()     // 缺省约定调用基类的无参构造函数Point()。
        {
            Console.WriteLine("Circle's  destructor  ");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Circle b = new Circle();
            b = null;
            GC.Collect();
            Console.Read();
        }
    }
}
