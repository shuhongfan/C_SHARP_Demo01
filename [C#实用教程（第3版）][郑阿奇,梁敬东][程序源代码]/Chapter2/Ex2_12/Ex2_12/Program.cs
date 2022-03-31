using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_12
{
    class Prime100
    {
        public static bool prime(int m)
        {
            for (int i = 2; i < m; i++)
                if (m % i == 0)
                    return false;        	// 返回给调用者
            return true;
        }
        static void Main(string[] args)
        {
            int m, k, n = 1;
            Console.Write("{0,-4}", 2);
            for (m = 3; m < 100; m += 2)
            {
                if (prime(m))            // 调用方法prime
                {
                    Console.Write("{0,-4}", m);
                    if (++n % 10 == 0)
                        Console.WriteLine("\n");
                }
            }
            Console.Read();
        }
    }
}
