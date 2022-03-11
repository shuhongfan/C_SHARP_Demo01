using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy2_4
    {
        static void Main(string[] args)
        {
            int[] a;
            Console.Write("请输入数组的长度：");
            int n = int.Parse(Console.ReadLine());
            a=new int[n];
            for(int i=0; i<n; i++)
            {
                Console.Write("请输入第{0}个数组元素的值：",i+1);
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("数组元素值如下：");
            foreach(int i in a)
            {
                Console.WriteLine(i+"\t");
            }
            Console.WriteLine();
        }
    }
}
