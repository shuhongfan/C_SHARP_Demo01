using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_5
{
    class Sum100 
    {
        static void Main(string[] args)
        {
           int Sum ,  i ;
           Sum=0;  i=1;
           do
           {
               Sum += i;
               i++;
           }
           while (i <= 100);
           Console.WriteLine ("Sum is " + Sum);
           Console.ReadLine();
        }
    }
}
