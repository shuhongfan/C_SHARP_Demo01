using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_19
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
            multiline = true;
        }
        public void set_text(string str)
        {
            text = str;
        }
        public string get_text()
        {
            return text;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            TextBox Text1 = new TextBox();
            Console.WriteLine("Text1.text= {0} ", Text1.get_text());
            Text1.set_text("这是文本框");
            Console.WriteLine("Text1.text= {0} ", Text1.get_text());
            Console.Read();
        }
    }
}
