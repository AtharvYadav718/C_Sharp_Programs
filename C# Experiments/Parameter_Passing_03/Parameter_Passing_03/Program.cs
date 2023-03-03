using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameter_Passing_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Addition(out i);
            Console.WriteLine("Addition is :- " + i); Console.ReadKey();
        }
        static void Addition(out int i)
        {
            i = 10;
            i += i;
        }
    }
}

