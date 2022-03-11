using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class sy2_5
    {
        static void Main(String[] args)
        {
            int[,] num = new int[2, 3];
            Console.WriteLine("请输入6个数组元素：");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("输入二维数组：");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
