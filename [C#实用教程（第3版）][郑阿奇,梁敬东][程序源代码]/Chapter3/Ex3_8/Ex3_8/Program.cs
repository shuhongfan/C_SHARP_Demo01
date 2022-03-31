using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_8
{
    class StackTp
    {
        int MaxSize;
        int Top;
        int[] StkList;
        public StackTp()         	//  构造函数
        {
            MaxSize = 100;
            Top = 0;
            StkList = new int[MaxSize];
        }
        public StackTp(int size)   		//  构造函数
        {
            MaxSize = size;
            Top = 0;
            StkList = new int[MaxSize];

        }
        public bool isEmptyStack()   	// 方法
        {
            if (Top == 0)
                return true;
            else
                return false;
        }
        public bool isFullStack()
        {
            if (Top == MaxSize)
                return true;
            else
                return false;
        }
        public void push(int x)
        {
            StkList[Top] = x;
            Top++;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            StackTp ST = new StackTp(20);
            string s1;
            if (ST.isEmptyStack())     	// 调用方法isEmptyStack()
                s1 = "Empty";
            else
                s1 = "not Empty";
            Console.WriteLine("Stack is " + s1);
            for (int i = 0; i < 20; i++)
                ST.push(i + 1);
            if (ST.isFullStack())     	// 调用方法isFullStack()
                s1 = "Full";
            else
                s1 = "not Full";
            Console.WriteLine("Stack is " + s1);
            Console.Read();
        }
    }
}
