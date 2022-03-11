using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy2_3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int num = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        num += j;
                    }
                }
                if (num == i)
                {
                    Console.WriteLine(i);   
                }
            }
        }
    }
}
