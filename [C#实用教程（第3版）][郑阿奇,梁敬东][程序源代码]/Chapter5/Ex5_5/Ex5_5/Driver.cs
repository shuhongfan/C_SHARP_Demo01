﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_5
{
    public delegate void PrintCallback(int number);
    public class Printer
    {
        //委托定义
        private PrintCallback _print;
        //委托将要依附的属性
        public PrintCallback PrintCallback
        {
            get { return _print; }
            set { _print = value; }
        }
    }

    class Driver
    {
        //将要委托的方法
        private void PrintInteger(int number)
        {
            Console.WriteLine("From PrintInteger:The number is {0}.", number);
        }

        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Printer printer = new Printer();
            //将委托绑定到属性
            printer.PrintCallback = new PrintCallback(driver.PrintInteger);
            //使用属性触发委托事件
            printer.PrintCallback(10);
            printer.PrintCallback(100);
            Console.WriteLine("press Enter to exit");
            Console.ReadLine();

        }
    }
}
