using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_9
{
    class Sun100
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for (int i = 1; i <= 100; i++)      		//  i只在这个for循环中有效
                Sum += i;
            Console.WriteLine("i = " + i);    	        // 编译出错，i这时已经无效
            Console.WriteLine("Sum is " + Sum);
            Console.ReadLine();
        }
    }
}
