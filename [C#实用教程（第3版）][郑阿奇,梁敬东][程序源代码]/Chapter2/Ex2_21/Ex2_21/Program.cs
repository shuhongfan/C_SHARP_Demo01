using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_21
{
    class YH_tri
    {
        static void Main(string[] args)
        {
            int i, j, k, m;
            k = 7;
            int[][] Y = new int[k][];      		// 定义二维锯齿状数组Y
            for (i = 0; i < Y.Length; i++)      	 	// Y.Length返回的是Y数组的长度，7
            {
                Y[i] = new int[i + 1];
                Y[i][0] = 1;
                Y[i][i] = 1;
            }
            for (i = 2; i < Y.Length; i++)
                for (j = 1; j < Y[i].Length - 1; j++)  	// Y[i].Length是Y[i]这个数组的长度
                    Y[i][j] = Y[i - 1][j - 1] + Y[i - 1][j];
            for (i = 0; i < Y.Length; i++)
            {
                for (j = 0; j < Y[i].Length; j++)
                    Console.Write("{0,5:d}", Y[i][j]);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
