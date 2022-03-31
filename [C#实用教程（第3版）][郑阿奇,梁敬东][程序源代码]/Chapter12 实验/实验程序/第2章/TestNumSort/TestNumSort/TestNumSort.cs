using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNumSort
{
    class TestNumSort
    {
        static void Main(string[] args)
        {
            int a, b, c, d;                                                                     // a,b,c,d分别代表红、黄、黑、白
            for (a = 1; a <= 4; a++)
                for (b = 1; b <= 4; b++)
                    for (c = 1; c <= 4; c++)
                        if (a != b && a != c && b != c)                                         //注释(1)
                        {
                            d = 10 - a - b - c;                                                 //盒子编号之和为10
                            if ((c == 1 ^ b == 2) && (c == 2 ^ d == 3) && (a == 2 ^ d == 4))    //注释(2)
                            {
                                Console.Write("红球放置在{0}号,黄球放置在{1}号,", a, b);
                                Console.WriteLine("黑球放置在{0}号,白球放置在{1}号", c, d);
                            }
                        }
            Console.Read();
        }
    }
}
