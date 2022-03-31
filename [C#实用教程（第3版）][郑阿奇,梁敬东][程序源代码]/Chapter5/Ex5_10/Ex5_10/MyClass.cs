#define DEGUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_10
{
    class MyClass
    {
        static void Main(string[] args)
        {
#if (DEBUG)
            Console.WriteLine("DEBUG is defined");
#else
                Console.WriteLine("DEBUG is not defined");
#endif
            Console.Read();

        }
    }
}
