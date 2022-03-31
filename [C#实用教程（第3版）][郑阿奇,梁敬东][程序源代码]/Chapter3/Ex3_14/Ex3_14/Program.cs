using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_14
{
    class Myclass
    {
        public void MaxMin(out int max, out int min, params int[] a)
        {
            if (a.Length == 0)  // 如果可变参数为零个，可以取一个约定值或产生异常
            {
                max = min = -1;
                return;
            }
            max = min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            int[] score = { 87, 89, 56, 90, 100, 75, 64, 45, 80, 84 };
            int smax, smin;
            m.MaxMin(out smax, out smin);    			// 可变参数的个数可以是零个
            Console.WriteLine("Max={0}, Min={1} ", smax, smin);
            m.MaxMin(out smax, out smin, 45, 76, 89, 90);  	// 在四个数之间找最大、最小
            Console.WriteLine("Max={0}, Min={1} ", smax, smin);
            m.MaxMin(out smax, out smin, score);   		// 可变参数也可接受数组对象
            Console.WriteLine("Max={0}, Min={1} ", smax, smin);
            Console.Read();
        }
    }
}
