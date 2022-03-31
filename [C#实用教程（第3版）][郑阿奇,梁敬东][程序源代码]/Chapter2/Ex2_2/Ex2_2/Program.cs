using System;

namespace Ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int类型常量22输出结果:" + 22);
            Console.WriteLine("long类型常量22L输出结果:" + 22L);
            Console.WriteLine("uint类型常量228U输出结果:" + 228U);
            Console.WriteLine("ulong类型常量228UL输出结果:" + 228UL);
            Console.WriteLine("十六进制常量0x20输出结果:" + 0x20);
            Console.WriteLine("double类型常量3.14e2输出结果:" + 3.14e2);
            Console.WriteLine("decimal类型常量3.14e-2M输出结果:" + 3.14e-2M);
            Console.WriteLine(@"字符串类型常量C:\\windows\\Microsoft输出结果:" + "C:\\windows\\Microsoft");
            const double PI = 3.14159;						//声明标识符常量
            Console.WriteLine("符号常量PI输出结果:" + PI);
            string Name;        							//定义sting类型变量Name
            Name = "王小明";   		 					//赋值
            Console.WriteLine("string变量类型Name赋值后的值：" + Name);
            Name = "王大明";								//重新赋值
            Console.WriteLine("string变量类型Name重新赋值后的值：" + Name);
            Console.ReadLine();
        }
    }
}
