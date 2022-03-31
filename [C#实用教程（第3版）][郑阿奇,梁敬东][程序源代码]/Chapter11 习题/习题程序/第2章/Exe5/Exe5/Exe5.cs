using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exe5
{
    class Exe5
    {
        static void Main(string[] args)
        {
            int[] x;
            x = new int[10];
            int[] y = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            const int SIZE = 10;
            int[] z;
            z = new int[SIZE];
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = i * 2 + 1;
                Console.Write("{0,4}", z[i]);
            }
            Console.Read();
        }
    }
}
