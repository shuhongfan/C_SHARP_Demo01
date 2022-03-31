using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 3.14;
            double d2 = d1;
            Console.WriteLine("d1与d2内存地址是否相同：" + ((object)d1 == (object)d2));
            object o1 = d1;              //装箱操作
            object o2 = o1;
            Console.WriteLine("o1与o2是否指向同一个内存地址：" + ((object)o1 == (object)o2));
            d1 = 3.1415;
            Console.WriteLine((double)o1); //d1改变不影响o1的值，说明o1不是指向d1的内存地址

            string s1 = "Visual C#";
            string s2 = s1;
            Console.WriteLine("s1与s2是否指向同一个内存地址：" + ((object)s1 == (object)s2));
            s1 = "C#";		//修改字符串，在内存中创建新的内存位置，创建了新的s1实例
            Console.WriteLine("改变s1后，s1与s2是否指向同一个地址：" + ((object)s1 == (object)s2));
            s2 = "C#";		//修改字符串，在内存中创建新的内存位置，但与s1内存位置不同
            Console.WriteLine(s1 == s2);	//说明string类型只判断值
            Console.ReadLine();
        }
    }
}
