using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe1
{
    class Exe1
    {
        static void Main(string[] args)
        {
            int x, y, z;
            bool s;
            x = y = z = 0;
            s = x++ != 0 || ++y != 0 && ++y != 0;
            Console.WriteLine("x={0}, y={1}, z={2}, s={3}", x, y, z, s);
            Console.Read();
        }
    }
}
