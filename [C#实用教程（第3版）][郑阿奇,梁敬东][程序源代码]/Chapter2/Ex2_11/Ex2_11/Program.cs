using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_11
{
    class Prime
    {
        static void Main(string[] args)
        {
            int  m ,  k ,  n=0 ;
            for (m = 2; m < 100; m++)
            {
                for (k = 2; k < m; k++)
                    if (m % k == 0)
                        break;          //它从内循环语句中跳出，进入外循环的下一轮  
                if (k >= m)
                {
                       Console.Write("{0,-4}", m);
                       if (++n % 10 == 0)
                            Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
