using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_18
{
    class YH_tri
    {
        static void Main(string[] args)
        {
            int i, j, k;
            k = 7;
            int[][] Y = new int[k][];      // 定义二维锯齿状数组
            for (i = 0; i < k; i++)
            {
                Y[i] = new int[i + 1];
                Y[i][0] = 1;
                Y[i][i] = 1;
            }
            for (i = 2; i < k; i++)
                for (j = 1; j < i; j++)
                    Y[i][j] = Y[i - 1][j - 1] + Y[i - 1][j];
            for (i = 0; i < k; i++)
            {
                for (j = 0; j <= i; j++)
                    Console.Write("{0,5:d}", Y[i][j]);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
