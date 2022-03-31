using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入学生百分制的成绩：");
            int Grade = (int)Console.Read();
            switch (Grade/10)
            {
                case 9:
                case 10: Console.WriteLine("你的成绩为：A");
                    break;
                case 8: Console.WriteLine("你的成绩为：B");
                    break;
                case 7: Console.WriteLine("你的成绩为：C");
                    break;
                case 6: Console.WriteLine("你的成绩为：D");
                    break;
                default: Console.WriteLine("你的成绩为：E");
                    break;
            }
        }
    }
}
