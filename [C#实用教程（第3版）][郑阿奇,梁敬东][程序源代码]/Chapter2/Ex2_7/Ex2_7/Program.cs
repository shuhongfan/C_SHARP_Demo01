using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_7
{
    class Sum100
    {
        static void Main(string[] args)
        {
            int Sum, i;
            for (Sum = 0, i = 1; i <= 100; i++)
                Sum += i;
            Console.WriteLine("Sum is " + Sum);
            for (Sum = 0, i = 1; i <= 100; Sum += i, i++)
                ;                                // 循环体是一空语句
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
        }
    }
}
