using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_14
{
    class Chook100
    {
        static void Main(string[] args)
        {
            int x, y, z;
            bool flag = false;
            x = y = z = 0;
            for (x = 1; x <= 100 / 5; x++)
            {
                for (y = 1; y <= 100 / 3; y++)
                {
                    z = 100 - x - y;
                    if (z % 3 == 0 && 5 * x + 3 * y + z / 3 == 100)
                    { flag = true; break; }
                    // 这个break语句只能跳出最内一层循环
                }
                if (flag)
                    break;     // 这个break语句跳出最外一层循环
            }
            Console.WriteLine("Cock={0}  Hen={1}  Chick={2}", x, y, z);
            Console.Read();
        }
    }
}
