using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Ex6_8
{
    class Program
    {
        public class Student
        {
            private string _name;           // 姓名
            private string _number;         // 学号
            private bool isRun = false;
            public void Add(string name, string number)
            {
                Monitor.Enter(this);
                if (isRun)
                {
                    Monitor.Wait(this);
                }
                this._name = name;
                this._number = number;

                this.isRun = true;
                Thread.Sleep(1000);
                Monitor.Pulse(this);
                Monitor.Exit(this);
            }
            public void GetInfo()
            {
                Monitor.Enter(this);
                if (!isRun)
                {
                    Monitor.Wait(this);
                }
                Console.Write("姓名：" + _name);
                Console.WriteLine(" 学号：" + _number.ToString());
                this.isRun = false;
                Monitor.Pulse(this);
                Monitor.Exit(this);
            }
        }
        public class Thread1
        {
            private Student student;
            public Thread1(Student student)
            {
                this.student = student;
            }
            public void run()
            {
                int i = 0;
                while (true)
                {
                    i++;
                    student.Add("学生" + i.ToString(), "17110" + i.ToString());
                }
            }
        }
        public class Thread2
        {
            private Student student;
            public Thread2(Student student)
            {
                this.student = student;
            }
            public void run()
            {

                while (true)
                {
                    student.GetInfo();
                }
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student();                                    // 实例化学生类
            new Thread(new ThreadStart(new Thread1(student).run)).Start();          // 添加学生信息
            new Thread(new ThreadStart(new Thread2(student).run)).Start();          // 读取学生信息

        }
    }
}
