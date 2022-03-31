using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Ex8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"c:\temp\MyTest.txt";
            string path2 = @"c:\temp\MyTest";
            string path3 = @"temp";
            if (Path.HasExtension(path1))
            {
                Console.WriteLine("{0} has an extension.", path1);
            }
            if (!Path.HasExtension(path2))
            {
                Console.WriteLine("{0} has no extension.", path2);
            }
            if (!Path.IsPathRooted(path3))
            {
                Console.WriteLine("The string {0} contains no root information.", path3);
            }
            Console.WriteLine("{0} is the location for temporary files.", Path.GetTempPath());
            Console.WriteLine("{0} is a file available for use.", Path.GetTempFileName());
            Console.Read();

        }
    }
}
