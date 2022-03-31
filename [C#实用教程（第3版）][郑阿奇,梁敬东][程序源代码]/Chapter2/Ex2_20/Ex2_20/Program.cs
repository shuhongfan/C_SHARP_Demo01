﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_20
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int[,] a = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] b = new int[4, 3] { { 12, 11, 10 }, { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] c = new int[3, 3];
            for (i = 0; i < c.GetLength(0); i++)   	// c.GetLength(0)是c数组第一维的长度
                for (j = 0; j < c.GetLength(1); j++)  // c.GetLength(1)是c数组第二维的长度
                    for (k = 0; k < 4; ++k)
                        c[i, j] += a[i, k] * b[k, j];
            for (i = 0; i < 3; ++i)
            {
                for (j = 0; j < 3; ++j)
                    Console.Write("{0,4:d}", c[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("c数组一共有{0}个元素", c.Length);
            // c.Length是c数组的总体长度，即元素总个数（9个），与它的维数无关
            Console.Read();
        }
    }
}
