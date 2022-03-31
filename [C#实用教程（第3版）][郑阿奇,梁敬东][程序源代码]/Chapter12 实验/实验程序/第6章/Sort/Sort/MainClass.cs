using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sort
{
    // 插入排序
    public class InsertionSorter
    {
        public int[] list;
        public void Sort()
        {
            for (int i = 1; i < list.Length; i++)
            {
                int t = list[i];
                int j = i;
                while ((j > 0) && (list[j - 1] > t))
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = t;
            }
            Console.Write("Insertion done.");
        }
    }
    // 冒泡排序
    public class BubbleSorter
    {
        public int[] list;
        public void Sort()
        {
            int i, j, temp;
            bool done = false;
            j = 1;
            while((j<list.Length)&&(!done))
            {
                done = true;
                for (i = 0; i < list.Length - j; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        done = false;
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                j++;
            }
            Console.Write("Bubble done.");
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            InsertionSorter Sorter1=new InsertionSorter();
            BubbleSorter Sorter2=new BubbleSorter();
            // 生成随机元素的数组
            int iCount=10000;
            Random random = new Random();
            Sorter1.list=new int[iCount];
            Sorter2.list=new int[iCount];
            for(int i=0; i< iCount; ++i)
            {
                Sorter1.list[i]=Sorter2.list[i]=random.Next();
            }
            Thread sortThread1 = new Thread(new ThreadStart(Sorter1.Sort));
            Thread sortThread2 = new Thread(new ThreadStart(Sorter2.Sort));
            sortThread1.Start();
            sortThread2.Start();
            Console.Read();
        }
    }
}
