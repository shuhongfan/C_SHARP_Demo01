using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test3_1
{
    class Card
    {
        private string title, author;
        private int total;
        public Card()
        {
            title = ""; author = "";
            total = 0;
        }
        public Card(string title, string author, int total)
        {
            this.title = title;
            this.author = author;
            this.total = total;
        }
        public void store(ref Card card)
        {
            title = card.title; author = card.author; total = card.total;
        }
        public void show()
        {
            Console.WriteLine("Title: {0},  Author: {1} ,  Total: {2} ", title, author, total);
        }
        public string Title   	// Title属性可读可写
        {
            get { return title; }
            set { title = value; }
        }
        public string Author  	// Author属性可读可写
        {
            get { return author; }
            set { author = value; }
        }
        public int Total      	// Total属性可读可写
        {
            get { return total; }
            set { total = value; }
        }
    }
    class Test3_1
    {
        static void Main(string[] args)
        {
            Test3_1 T = new Test3_1();
            Card[] books;
            int[] index;
            int i, k;
            Card card = new Card();
            Console.Write("请输入需要入库图书的总数： ");
            string sline = Console.ReadLine();
            int num = int.Parse(sline);
            books = new Card[num];
            for (i = 0; i < num; i++)
                books[i] = new Card();
            index = new int[num];
            for (i = 0; i < num; i++)
            {
                Console.Write("请输入书名： ");
                card.Title = Console.ReadLine();
                Console.Write("请输入作者： ");
                card.Author = Console.ReadLine();
                Console.Write("请输入入库量：");
                sline = Console.ReadLine();
                card.Total = int.Parse(sline);
                books[i].store(ref card);
                index[i] = i;
            }
            Console.Write("请选择按什么关键字排序(1.按书名, 2.按作者, 3.按入库量)");
            sline = Console.ReadLine();
            int choice = int.Parse(sline);
            switch (choice)
            {
                case 1:
                    T.sortTitle(books, index);
                    break;
                case 2:
                    T.sortAuthor(books, index);
                    break;
                case 3:
                    T.sortTotal(books, index);
                    break;
            }
            for (i = 0; i < num; i++)
            {
                k = index[i];
                (books[k]).show();
            }
            Console.Read();
        }
        void sortTitle(Card[] book, int[] index)
        {
            int i, j, m, n, temp;
            for (m = 0; m < index.Length - 1; m++)
                for (n = 0; n < index.Length - m - 1; n++)
                {
                    i = index[n]; j = index[n + 1];
                    if (string.Compare(book[i].Title, book[j].Title) > 0)
                    {
                        temp = index[n]; index[n] = index[n + 1]; index[n + 1] = temp;
                    }
                }
        }
        void sortAuthor(Card[] book, int[] index)
        {
            int i, j, m, n, temp;
            for (m = 0; m < index.Length - 1; m++)
                for (n = 0; n < index.Length - m - 1; n++)
                {
                    i = index[n]; j = index[n + 1];
                    if (string.Compare(book[i].Author, book[j].Author) > 0)
                    {
                        temp = index[n]; index[n] = index[n + 1]; index[n + 1] = temp;
                    }
                }
        }
        void sortTotal(Card[] book, int[] index)
        {
            int i, j, m, n, temp;
            for (m = 0; m < index.Length - 1; m++)
                for (n = 0; n < index.Length - m - 1; n++)
                {
                    i = index[n]; j = index[n + 1];
                    if (book[i].Total > book[j].Total)
                    {
                        temp = index[n]; index[n] = index[n + 1]; index[n + 1] = temp;
                    }
                }
        }
    }
}
