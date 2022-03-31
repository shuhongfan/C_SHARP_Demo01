using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_9
{
    class Myclass
    {
        public void Sort(int x, int y, int z)
        {
            int tmp;             // tmp是方法Sort的局部变量
            // 将x, y, z按从小到大排序
            if (x > y) { tmp = x; x = y; y = tmp; }
            if (x > z) { tmp = x; x = z; z = tmp; }
            if (y > z) { tmp = y; y = z; z = tmp; }
        }
    }     
    class Test
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            int a, b, c;
            a = 30; b = 20; c = 10;
            m.Sort(a, b, c);
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.Read();
        }
    }
}
