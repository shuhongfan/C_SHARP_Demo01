using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_13
{
    class Myclass
    {
        public void Swap1(string s, string t)
        {
            string tmp;
            tmp = s;
            s = t;
            t = tmp;
        }
        public void Swap2(ref  string s, ref  string t)
        {
            string tmp;
            tmp = s;
            s = t;
            t = tmp;
        }
    }     
    class Test
    {
        static void Main(string[] args)
        {
            Myclass m = new Myclass();
            string s1 = "ABCDEFG", s2 = "134567";
            m.Swap1(s1, s2);
            Console.WriteLine("s1={0}", s1);    // s1,s2的引用并没有改变
            Console.WriteLine("s2={0}", s2);
            m.Swap2(ref s1, ref s2);        		// s1,s2的引用互相交换了
            Console.WriteLine("s1={0}", s1);
            Console.WriteLine("s2={0}", s2);
            Console.Read();
        }
    }
}
