using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_10
{
    class Factor3
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 3 != 0)
                    continue;         // 如果n不能被3整除，则直接进入下一轮循环
                Console.WriteLine(n);   // 只有能被3整除的数，才会执行到此
            }
            Console.ReadLine();
        }
    }
}
