using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            while(true)
            {
                String s = Console.ReadLine();
                if (s == "exit") break;
                try
                {
                    int i = 10 / Int32.Parse(s);
                    Console.WriteLine("结果是" + i);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.Read();
        }
    }
}
