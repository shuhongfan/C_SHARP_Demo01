using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5_4
{
    public class SpellingList
    {
        protected string[] words = new string[size];
        static public int size = 10;
        public SpellingList()
        {
            for (int x = 0; x < size; x++)
                words[x] = String.Format("Word{0}", x);
        }
        // 索引器，根据下标访问 words
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                    tmp = words[index];
                else
                    tmp = "";
                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    words[index] = value;
            }
        }
    }

    class TestApp
    {
        static void Main(string[] args)
        {
            SpellingList myList = new SpellingList();
            myList[3] = "=====";
            myList[4] = "Brad";
            myList[5] = "was";
            myList[6] = "Here!";
            myList[7] = "=====";
            for (int x = 0; x < SpellingList.size; x++)
                Console.WriteLine(myList[x]);
            Console.Read();

        }
    }
}
