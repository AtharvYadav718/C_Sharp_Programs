using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typecasting_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            long l = i;
            long f = l;

            Console.WriteLine("Int value is : " + i);
            Console.WriteLine("Long value is : " + l); 
            Console.WriteLine("Floating value is : " + f); 
            Console.ReadKey();
        }
    }
}

