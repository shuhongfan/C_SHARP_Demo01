using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe2
{
    class Exe2
    {
        static void Main(string[] args)
        {
            int a, b;
            a = b = 1;
            b += a / b++;
            Console.Write("a={0}, b={1}, ", a, b);
            b += --a + (++b);
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.Read();
        }
    }
}
