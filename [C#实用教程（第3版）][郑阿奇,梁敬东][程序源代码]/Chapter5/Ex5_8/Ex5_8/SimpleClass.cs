﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_8
{
    class SimpleClass
    {
        public class WorkerClass
        {
            // 委托引用的非静态方法
            public int InstanceMethod(int nID, string sName)
            {
                int retval = 0;
                retval = nID * sName.Length;
                Console.WriteLine("调用InstanceMethod方法");
                return retval;
            }
            // 委托引用的静态方法
            static public int StaticMethod(int nID, string sName)
            {
                int retval = 0;
                retval = nID * sName.Length;
                Console.WriteLine("调用StaticMethod方法");
                return retval;
            }
        }
        // 定义委托，签名与上面两个方法相同
        public delegate int SomeDelegate(int nID, string sName);

        static void Main(string[] args)
        {
            // 调用实例方法
            WorkerClass wr = new WorkerClass();
            SomeDelegate d1 = new SomeDelegate(wr.InstanceMethod);
            Console.WriteLine("Invoking delegate InstanceMethod, return={0}", d1(5, "aaa"));
            // 调用静态方法
            SomeDelegate d2 = new SomeDelegate(WorkerClass.StaticMethod);
            Console.WriteLine("Invoking delegate StaticMethod, return={0}", d2(5, "aaa"));
            // 多播
            Console.WriteLine();
            Console.WriteLine("测试多播…");
            // 多播d3由两个委托d1和d2组成
            SomeDelegate d3 = d1 + d2;
            Console.WriteLine("Invoking delegate(s) d1 AND d2 (multi-cast), return={0} "
                                                            , d3(5, "aaa"));
            // 委托中的方法个数
            int num_method = d3.GetInvocationList().Length;
            Console.WriteLine("Number of methods referenced by delegate d3: {0}", num_method);
            // 多播d3减去委托d2
            d3 = d3 - d2;
            Console.WriteLine("Invoking delegate(s) d1 (multi-cast), return={0} ", d3(5, "aaa"));
            // 委托中的方法个数
            num_method = d3.GetInvocationList().Length;
            Console.WriteLine("Number of methods referenced by delegate d3: {0}", num_method);
            Console.Read();

        }
    }
}
