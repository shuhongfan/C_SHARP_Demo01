using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum, i;
            Sum = 0; i = 1;
            while (i <= 100)
            {
                Sum += i;
                i++;
            }
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
        }
    }
}
