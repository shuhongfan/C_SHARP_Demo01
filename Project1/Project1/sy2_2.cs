using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy2_2
    {
        static void Main(String[] args)
        {
            int count = 0;
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0)
                {
                    Console.Write("{0,3}", num);
                    count++;
                    if (count % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("1-100之间含有因子3的数共有"+count+"个");
        }
    }
}
