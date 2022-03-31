using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe4
{
    class Exe4
    {
        static void Main(string[] args)
        {
            int a = 2, b = 7, c = 5;
            switch (a > 0)
            {
                case true:
                    switch (b < 10)
                    {
                        case true: Console.Write("^"); break;
                        case false: Console.Write("!"); break;
                    }
                    break;
                case false:
                    switch (c == 5)
                    {
                        case false: Console.Write("*"); break;
                        case true: Console.Write("#"); break;
                    }
                    break;
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
