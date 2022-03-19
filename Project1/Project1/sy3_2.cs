using System;

// (1) 在项目中添加一个Person类，该类有name和age两个公有字段；
// (2) 为Person类添加一个构造函数（带两个参数，分别对应name和age）；
// (3) 为Person类编写方法ShowInfo，显示Person类的信息；
// (4) 增加一个学生Student类，该类从Person类的派生，Student类有一个新的私有的学号字段number；
// (5) 为Student类添加一个三个参数的构造函数，并调用父类的构造函数辅助实现对name和age字段的初始化。
// (6) 在Student类中为学号number字段添加一个属性；
// (7) 在Student类中增加ShowNumber方法用于显示学号信息；
// (8) 在Student类中隐藏基类中的ShowInfo方法，方法的功能是输出学生的所有信息，其中name和age的信息要求调用基类的ShowInfo方法输出，学号信息调用ShowNumber方法输出。
// (9) 在Main()方法中创建Student的一个实例student，并调用ShowInfo方法输出学生的所有信息。

namespace Project1
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.Write("姓名：{0}\n年龄：{1}",this.name,this.age);
        }
    }

    public class Student:Person
    {
        private string number;
        public Student(string name, int age,string number) : base(name, age)
        {
            this.number = number;
        }

        public void ShowNumber()
        {
            Console.WriteLine("\n学号:{0}",this.number);
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            ShowNumber();
        }
    }

    public class sy3_2
    {
        static void Main(string[] args)
        {
            Student student = new Student("李四",3,"18766");
            student.ShowInfo();
        }
    }
}