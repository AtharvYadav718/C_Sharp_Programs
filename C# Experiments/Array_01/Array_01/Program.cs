using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] language;
            language = new string[5] { "C", "C++", "JAVA", "C#", "DBMS" }; 
            Console.WriteLine("COMPUTER LANGUAGES ARE :"); 
            foreach (string lang in language)
            {
                Console.WriteLine(lang);
            }
            Console.ReadKey();
        }
    }
}

