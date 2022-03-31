using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum, i;
            for (Sum = 0, i = 1; i <= 100; )    		// 缺省表达式3
                Sum += i++;
            Console.WriteLine("Sum is " + Sum);
            for (Sum = 0, i = 1; ; Sum += i, i++)   	// 缺省表达式2，约定值是true
                if (i > 100) break;        		// 但条件满足时，break语句跳出循环。
            Console.WriteLine("Sum is " + Sum);
            Sum = 0; i = 1;
            for (; ; )             		// 三个表达式都缺省
            {
                Sum += i++;
                if (i > 100)      				// 这种情况一般都会用if语句来设置跳出循环
                    break;
            }
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
        }
    }
}
