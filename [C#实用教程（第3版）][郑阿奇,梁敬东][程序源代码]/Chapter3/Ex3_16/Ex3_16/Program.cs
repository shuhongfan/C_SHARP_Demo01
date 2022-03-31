using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_16
{
    class Myclass              // 该类中有max方法的四个不同版本
    // 它们或者参数类型不同，或者参数个数不同。
    {
        public int max(int x, int y)
        {
            return x >= y ? x : y;
        }
        public double max(double x, double y)
        {
            return x >= y ? x : y;
        }
        public int max(int x, int y, int z)
        {
            return max(max(x, y), z);
        }
        public double max(double x, double y, double z)
        {
            return max(max(x, y), z);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            int a, b, c;
            double e, f, g;
            a = 10; b = 20; c = 30;
            e = 1.5; f = 3.5; g = 5.5;
            // 调用方法时，编译器会根据实参的类型和个数调用不同的方法。
            Console.WriteLine("max({0},{1})= {2} ", a, b, m.max(a, b));
            Console.WriteLine("max({0},{1},{2})= {3} ", a, b, c, m.max(a, b, c));
            Console.WriteLine("max({0},{1})= {2} ", e, f, m.max(e, f));
            Console.WriteLine("max({0},{1},{2})= {3} ", e, f, g, m.max(e, f, g));
            Console.Read();
        }
    }
}
