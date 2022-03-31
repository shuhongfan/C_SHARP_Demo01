﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_1
{
    // 定义集合中的元素 MyClass 类
    class MyClass
    {
        public string Name;
        public int Age;
        // 带参构造器
        public MyClass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    // 实现接口 IEnumerator 和 IEnumerable 的类 Iterator
    class Iterator:IEnumerator,IEnumerable
    {
        // 初始化 MyClass 类型的集合
        private MyClass[] ClassArray;
        int Cnt;
        public Iterator()
        {
			// 使用带参构造器赋值
			ClassArray = new MyClass[4];
            ClassArray[0] = new MyClass("Kith",23);
			ClassArray[1] = new MyClass("Smith",30);
			ClassArray[2] = new MyClass("Geo",19);
			ClassArray[3] = new MyClass("Greg",14);
            Cnt = -1;
        }
        // 实现 IEnumerator 的 Reset()方法
        public void Reset()
        {
            // 指向第一个元素之前，Cnt为-1,遍历是从0开始的
            Cnt = -1;
        }
        // 实现 IEnumerator 的 MoveNext()方法
        public bool MoveNext()
        {
            return (++ Cnt < ClassArray.Length);
        }
        // 实现 IEnumerator 的 Current 属性
        public object Current
        {
            get
            {
                return ClassArray[Cnt];
            }
        }
        // 实现 IEnumerable 的 GetEnumerator()方法
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        static void Main(string[] args)
        {
            Iterator It = new Iterator();
            // 像数组一样遍历集合
            foreach (MyClass MY in It)
            {
                Console.WriteLine("Name : " + MY.Name.ToString());
                Console.WriteLine("Age : " + MY.Age.ToString());
            }
            Console.Read();
        }
    }
}
