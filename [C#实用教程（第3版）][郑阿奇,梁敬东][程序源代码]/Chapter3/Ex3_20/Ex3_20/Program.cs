﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_20
{
    class TextBox
    {
        private string text;
        private string fontname;
        private int fontsize;
        private bool multiline;
        public TextBox()
        {
            text = "text1";
            fontname = "宋体";
            fontsize = 12;
            multiline = false;
        }
        public string Text
        {    // Text属性，可读可写
            get
            { return text; }
            set
            { text = value; }
        }
        public string FontName
        {    // FontName属性，只读属性
            get
            { return fontname; }
        }
        public int FontSize
        {    // FontSize属性，可读可写
            get
            { return fontsize; }
            set
            { fontsize = value; }
        }
        public bool MultiLine
        {    // MultiLine属性，只写
            set
            { multiline = value; }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            TextBox Text1 = new TextBox();
            // 调用Text属性的get访问器
            Console.WriteLine("Text1.Text= {0} ", Text1.Text);
            Text1.Text = "这是文本框";     // 调用Text属性的set访问器
            Console.WriteLine("Text1.Text= {0} ", Text1.Text);
            Console.WriteLine("Text1.Fontname= {0} ", Text1.FontName);
            Text1.FontSize = 36;
            Text1.MultiLine = true;
            Console.WriteLine("Text1.FontSize= {0} ", Text1.FontSize);
            Console.Read();
        }
    }
}
