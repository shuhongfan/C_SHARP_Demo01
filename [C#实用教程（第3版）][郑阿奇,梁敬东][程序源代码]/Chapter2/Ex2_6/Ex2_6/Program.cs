using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_6
{
    class Sum100
    {
        static void Main(string[] args)
        {
            int Sum, i;
            Sum = 0;
            for (i = 1; i <= 100; i++)
                Sum += i;
            Console.WriteLine("Sum is " + Sum);
            Sum = 0;
            for (i = 100; i > 0; i--)         // i也可以每次减1
                Sum += i;
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
        }
    }
}
