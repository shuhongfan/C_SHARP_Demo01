using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_3
{
    class MyClass
    {
        private string[] data = new string[5];
        // 索引器定义，根据下标访问data
        public string this[int index]
        {
            get
            { return data[index]; }
            set
            { data[index] = value; }
        }
    }

    class MyClient
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            // 调用索引器 set 赋值
            mc[0] = "Rajesh";
            mc[1] = "A3-126";
            mc[2] = "Snehadara";
            mc[3] = "Irla";
            mc[4] = "Mumbai";
            // 调用索引器 get 读出
            Console.WriteLine("{0},{1},{2},{3},{4}", mc[0], mc[1], mc[2], mc[3], mc[4]);
            Console.Read();

        }
    }
}
