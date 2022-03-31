using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Function;

namespace Ex5_12
{
    class FunctionClient
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("请输入字符串:");
            s = Console.ReadLine();
            Console.WriteLine("The Digit Count for String [{0}] is [{1}]", s, DigitCount.NumberOfDigits(s));
            Console.Read();

        }
    }
}
