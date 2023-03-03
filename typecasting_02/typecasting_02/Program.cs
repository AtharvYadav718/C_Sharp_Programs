using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace typecasting_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 785.45;
            int i = (int)d;

            Console.WriteLine("Double value is : " + d); 
            Console.WriteLine("Int value is : " + i); 
            Console.ReadKey();
        }
    }
}

