﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_17
{
    class Shape
    {
        protected double width;
        protected double height;
        public Shape()
        { width = height = 0; }
        public Shape(double x)
        { width = height = x; }
        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }
        public double area()
        { return width * height; }
    }
    class Triangle : Shape      		// 三角形
    {
        public Triangle(double x, double y)
            : base(x, y)
        {
        }
        new public double area()    	// 派生类方法与基类方法同名，编译时会有警告信息
        {
            return width * height / 2;
        }
    }
    class Trapezia : Shape   			// 梯形
    {
        double width2;
        public Trapezia(double w1, double w2, double h)
            : base(w1, h)
        {
            width2 = w2;
        }
        new public double area()    // 加new隐藏基类的area方法          
        {
            return (width + width2) * height / 2;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Shape A = new Shape(2, 4);
            Triangle B = new Triangle(1, 2);
            Trapezia C = new Trapezia(2, 3, 4);
            Console.WriteLine("A.area= {0} ", A.area());   // 调Shape的area方法
            Console.WriteLine("B.area= {0} ", B.area());   // 调Triangle的area方法
            Console.WriteLine("C.area= {0} ", C.area());   // 调Trapezia的area方法
            A = B;                //  在C#中，基类的引用也能够引用派生类对象
            Console.WriteLine("A.area= {0} ", A.area());   // 调Shape的area方法
            A = C;
            Console.WriteLine("A.area= {0} ", A.area());   // 调Shape的area方法
            Console.Read();
        }
    }
}
