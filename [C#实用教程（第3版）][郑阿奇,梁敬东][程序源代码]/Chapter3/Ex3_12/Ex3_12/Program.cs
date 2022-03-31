using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_12
{
    class Myclass
    {
        public void MaxMinArray(int[] a, out int max, out int min, out double avg)
        {
            int sum;
            sum = max = min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
                sum += a[i];
            }
            avg = sum / a.Length;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            int[] score = { 87, 89, 56, 90, 100, 75, 64, 45, 80, 84 };
            int smax, smin;
            double savg;
            m.MaxMinArray(score, out smax, out smin, out savg);
            Console.Write("Max={0}, Min={1}, Avg={2} ", smax, smin, savg);
            Console.Read();
        }
    }
}
