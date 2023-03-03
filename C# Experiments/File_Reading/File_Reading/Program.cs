using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Reading
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            String path = @"D:\C.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadLine();
        }
    }
}
