using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_10
{
    class Myclass
    {
        public void SortArray(int[] a)
        {
            int i, j, pos, tmp;
            for (i = 0; i < a.Length - 1; i++)
            {
                for (pos = j = i; j < a.Length; j++)
                    if (a[pos] > a[j]) pos = j;
                if (pos != i)
                {
                    tmp = a[i];
                    a[i] = a[pos];
                    a[pos] = tmp;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            int[] score = { 87, 89, 56, 90, 100, 75, 64, 45, 80, 84 };
            m.SortArray(score);
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("score[{0}]={1}, ", i, score[i]);
                if (i == 4) Console.WriteLine();
            }
            Console.Read();
        }
    }
}
