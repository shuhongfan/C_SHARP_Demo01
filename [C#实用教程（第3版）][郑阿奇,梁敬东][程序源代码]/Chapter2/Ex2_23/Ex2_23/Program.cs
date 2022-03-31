using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_23
{
    class ForExam
    {
        static void Main(string[] args)
        {
            int count;
            int[,] arrayNum = new int[3, 4] { { 98, 76, 87, 65 }, { 55, 68, 57, 84 }, { 91, 100, 58, 76 } };
            count = 0;
            foreach (int x in arrayNum)
            if (x >= 60)
            {
                count++;
                Console.Write("{0,4:d}", x);
            }
            Console.Read();
        }
    }
}
