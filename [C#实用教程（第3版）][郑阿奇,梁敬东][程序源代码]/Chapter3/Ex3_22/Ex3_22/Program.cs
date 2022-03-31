using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_22
{
    class Course
    {
        string courseName;    	// 课程名 
        int courseMark;      	// 课程学分
        public Course()
        {
        }
        public Course(string Name, int Mark)
        {
            courseName = Name;
            courseMark = Mark;
        }
        public string Name     	// Name属性，课程名可读可写
        {
            get
            { return courseName; }
            set
            { courseName = value; }
        }
        public int Mark    		// Mark属性，课程学分可读可写
        {
            get
            { return courseMark; }
            set
            { courseMark = value; }
        }

    }
    class Student
    {
        string stuName;           	// 学生姓名
        string stuID;               	// 学生学号
        static int numberOfCourse;   	// 加static修饰表明这个域为所有学生类对象共享。
        static Course[] list;        	// Course类对象数组，用于设置每门课程名、课程学分
        int[] stuScore;            	// 每个学生对象要填写的各课程成绩
        double stuGPA;           	// GPA值
        public Student()
        {    // 当第一次创建Student对象时，创建list对象数组，并初始化。
            list = new Course[numberOfCourse];
            for (int i = 0; i < numberOfCourse; i++)
                list[i] = new Course();
            stuScore = new int[numberOfCourse];
        }
        // 将CourseNum定义成静态属性是因为它只对静态域进行操作
        public static int CourseNum
        {
            get
            { return numberOfCourse; }
            set
            { numberOfCourse = value; }
        }
        public double GPA    // GPA属性是只读属性
        {
            get
            { return stuGPA; }
        }
        public string Name     // Name属性可读可写
        {
            get
            { return stuName; }
            set
            { stuName = value; }
        }
        // 将SetCourse设为静态方法，是因为它仅访问静态数据域，
        // 不需要创建Student类对象就可直接用Student类名调用。
        // 它的形参是一个参数数组，这样调用时就可根据实际选修的课程数来设置。
        public static void SetCourse(params Course[] topic)
        {
            for (int i = 0; i < topic.Length; i++)
            {
                list[i].Name = topic[i].Name;
                list[i].Mark = topic[i].Mark;
            }
        }
        // AddData方法将一个学生的数据添加到学生类对象数组中
        public void AddData(string name, string Id, int[] score)
        {
            stuName = name;
            stuID = Id;
            for (int i = 0; i < score.Length; i++)
                stuScore[i] = score[i];
        }
        public void ComputeGPA()    // 根据课程的学分以及学生成绩计算GPA
        {
            int i;
            double sMark, sumMark = 0, sumGP = 0;
            for (i = 0; i < stuScore.Length; i++)
            {
                if (stuScore[i] >= 95)
                    sMark = 4.5;
                else if (stuScore[i] >= 90)
                    sMark = 4;
                else if (stuScore[i] >= 85)
                    sMark = 3.5;
                else if (stuScore[i] >= 80)
                    sMark = 3;
                else if (stuScore[i] >= 75)
                    sMark = 2.5;
                else if (stuScore[i] >= 70)
                    sMark = 2;
                else if (stuScore[i] >= 65)
                    sMark = 1.5;
                else if (stuScore[i] == 60)
                    sMark = 1;
                else
                    sMark = 0;
                sumGP += list[i].Mark * sMark;
                sumMark += list[i].Mark;
            }
            stuGPA = sumGP / sumMark;
        }
        // stuSwap方法提供两个Student类对象的交换操作，注意它们的形参被修饰为ref
        public void stuSwap(ref Student stu1, ref Student stu2)
        {
            string name, Id;
            int i;
            int[] score = new int[Student.CourseNum];
            double gpa;
            name = stu1.Name;
            Id = stu1.stuID;
            gpa = stu1.GPA;
            for (i = 0; i < Student.CourseNum; i++)
                score[i] = stu1.stuScore[i];
            stu1.stuName = stu2.stuName;
            stu1.stuID = stu2.stuID;
            stu1.stuGPA = stu2.stuGPA;
            for (i = 0; i < Student.CourseNum; i++)
                stu1.stuScore[i] = stu2.stuScore[i];
            stu2.stuName = name;
            stu2.stuID = Id;
            stu2.stuGPA = gpa;
            for (i = 0; i < Student.CourseNum; i++)
                stu2.stuScore[i] = score[i];
        }
    }
    class Test
    {
        static void Main(string[] args)
        {

            Test T = new Test();
            int i, j, Num, Mark;
            string sline, Name, Id;
            double sMax, sMin;
            Console.Write("请输入学生总人数");
            sline = Console.ReadLine();         	// 从控制台接受学生总人数
            Num = int.Parse(sline);             	// 将string类型转换成int类型
            Console.Write("请输入选修课程总数");
            sline = Console.ReadLine();
            Student.CourseNum = int.Parse(sline);  	// CourseNum是Student的静态属性   
            Student[] Stu = new Student[Num];   	// 根据输入的学生总人数，动态地创建对象
            for (i = 0; i < Num; i++)            	//  对Student类的对象数组做初始化
                Stu[i] = new Student();
            Course[] tp = new Course[Student.CourseNum];  // 根据课程数创建Course类对象数组
            int[] score = new int[Student.CourseNum];
            for (i = 0; i < Student.CourseNum; i++)  	// 具体输入每门课名称、学分
            {
                Console.Write("请输入选修课程名");
                Name = Console.ReadLine();
                Console.Write("请输入选修课程学分");
                sline = Console.ReadLine();
                Mark = int.Parse(sline);
                tp[i] = new Course(Name, Mark);  // 根据课程名、学分对Course数组做初始化
            }
            Student.SetCourse(tp);             	// 用类名调用Student的静态方法SetCouse
            for (i = 0; i < Num; i++)              	// 输入学生姓名、学号、各门课成绩
            {
                Console.Write("请输入学生姓名");
                Name = Console.ReadLine();
                Console.Write("请输入学号");
                Id = Console.ReadLine();
                for (j = 0; j < Student.CourseNum; j++)
                {
                    Console.Write("请输入{0}课程的成绩", tp[j].Name);
                    sline = Console.ReadLine();
                    score[j] = int.Parse(sline);
                }
                Stu[i].AddData(Name, Id, score);  	// 将当前输入的一个学生数据加到对象数组中
                Stu[i].ComputeGPA();         	// 计算当前这个学生的GPA
                Console.WriteLine("你的GPA值是：{0:F2}", Stu[i].GPA);
            }
            T.MaxMinGPA(out sMax, out sMin, Stu);   // 计算GPA的最大值和最小值
            Console.WriteLine("GPA最高为{0:F2}, 最低为：{1:F2}", sMax, sMin);
            Console.WriteLine("按GPA从高到低输出：");
            T.SortGPA(ref Stu);
            for (i = 0; i < Num; i++)
                Console.WriteLine(" {0}  ，{1:F2}", Stu[i].Name, Stu[i].GPA);
            Console.Read();

        }
        // MaxMinGPA方法用于计算Student类对象数组中GPA的最大值和最小值
        // 它的形参max和min被修饰为out型，表明它的实参不需要做初始化，
        // 它会从方法中获得返回值
        public void MaxMinGPA(out double max, out double min, Student[] stu)
        {
            if (stu.Length == 0)
            {
                max = min = -1;
                return;
            }
            max = min = stu[0].GPA;
            for (int i = 1; i < stu.Length; i++)
            {
                if (max < stu[i].GPA) max = stu[i].GPA;
                if (min > stu[i].GPA) min = stu[i].GPA;
            }
        }
        // SortGPA方法按选择排序法对Student类对象数组排序，
        // 当需要交换时，再调用Student的stuSwap方法。
        // 请注意它的形参被修饰为ref，而在方法体内调用stuSwap方法时实参也要修饰ref
        public void SortGPA(ref Student[] stu)
        {
            int i, j, pos;
            for (i = 0; i < stu.Length - 1; i++)
            {
                for (j = (pos = i) + 1; j < stu.Length; j++)
                    if (stu[pos].GPA < stu[j].GPA)
                        pos = j;
                if (pos != i)
                    stu[i].stuSwap(ref stu[i], ref stu[pos]);
            }
        }
    }
}
