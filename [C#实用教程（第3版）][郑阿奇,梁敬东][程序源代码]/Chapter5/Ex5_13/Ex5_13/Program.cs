﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_13
{
    public class Student<N, A>          		// 定义泛型类
    {
        // 泛型类的类型参数可用于类成员
        private N _n;
        private A _a;
        private double _j;
        public Student(N n, A a)        		// 构造函数
        {
            this._n = n;
            this._a = a;
            int thesco = Convert.ToInt32(a);
            if (thesco >= 90)
            {
                _j = 4;
            }
            else if (thesco >= 85)
            {
                _j = 3.7;

            }
            else if (thesco >= 82)
            {
                _j = 3.3;
            }
            else if (thesco >= 78)
            {

                _j = 3;
            }
            else if (thesco >= 75)
            {
                _j = 2.7;
            }
            else if (thesco >= 72)
            {
                _j = 2.3;
            }
            else if (thesco >= 68)
            {
                _j = 2;
            }
            else if (thesco >= 64)
            {
                _j = 1.5;
            }
            else if (thesco >= 60)
            {
                _j = 1;
            }
            else
            {
                _j = 0;
            }
        }
        public void SetValue()          		// 定义方法
        {
            Console.WriteLine(_n.ToString() + ",你好，你输入的分数为：" + _a.ToString());
        }
        public string Process<W>(W w)  		// 定义泛型函数
        {
            return w.ToString() + _j.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入姓名和成绩");
            string name = Console.ReadLine();
            int sco = Convert.ToInt32(Console.ReadLine());
            // 使用string,int来实例化Student<N, A>类
            Student<string, int> s1 = new Student<string, int>(name, sco);
            s1.SetValue();            		// 调用泛型类中的方法
            Console.WriteLine(s1.Process<string>("绩点为："));  // 调用泛型函数
            Console.Read();

        }
    }
}
