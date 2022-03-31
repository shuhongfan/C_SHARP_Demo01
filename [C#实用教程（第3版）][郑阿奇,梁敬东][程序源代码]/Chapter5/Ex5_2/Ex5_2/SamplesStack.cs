using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_2
{
    class SamplesStack
    {
        static void Main(string[] args)
        {
            // 创建并初始化栈
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            // 显示栈的自身属性和其中的元素
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            PrintValues(myStack);
            Console.Read();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
