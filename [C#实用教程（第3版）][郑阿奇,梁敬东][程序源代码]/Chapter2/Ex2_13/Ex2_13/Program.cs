using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = y = z = 0;
            for (x = 1; x <= 100 / 5; x++)
                for (y = 1; y <= 100 / 3; y++)
                {
                    z = 100 - x - y;
                    if (z % 3 == 0 && 5 * x + 3 * y + z / 3 == 100)
                        goto end;
                    // 直接从内循环中转出，跳了二层循环，这是break语句做不到的。
                }
            end: Console.WriteLine("Cock={0}  Hen={1}  Chick={2}", x, y, z);
            Console.Read();
        }
    }
}
