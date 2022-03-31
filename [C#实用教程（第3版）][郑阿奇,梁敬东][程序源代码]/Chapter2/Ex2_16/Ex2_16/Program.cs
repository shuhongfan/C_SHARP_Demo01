﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_16
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            int max, min;
            int[] queue = new int[10] { 89, 78, 65, 52, 90, 92, 73, 85, 91, 95 };
            max = min = queue[0];
            for (int i = 1; i < 10; i++)
            {
                if (queue[i] > max) max = queue[i];
                if (queue[i] < min) min = queue[i];
            }
            Console.WriteLine("最大数是{0}，最小数是{1}", max, min);
            Console.Read();
        }
    }
}
