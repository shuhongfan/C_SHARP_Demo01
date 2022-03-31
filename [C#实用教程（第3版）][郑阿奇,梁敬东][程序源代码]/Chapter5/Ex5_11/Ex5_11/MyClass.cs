#define A
#undef  B
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_11
{
    class MyClass
    {
        static void Main(string[] args)
        {
#if (A && !B)
                Console.WriteLine("A is defined");
#elif (!A && B)
                Console.WriteLine("B is defined");
#elif (A && B)
                Console.WriteLine("A and B are defined");
#else
            Console.WriteLine("A and B are not defined");
#endif
            Console.Read();

        }
    }
}
