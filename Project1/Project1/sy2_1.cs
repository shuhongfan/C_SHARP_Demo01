using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy2_1
    {
        static void Main(string[] args)
        {
            Console.Write("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            if((year %4 ==0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0}是闰年.", year);
            } 
            else
            {
                Console.WriteLine(year + "不是闰年.");
            }
        }
    }
}
