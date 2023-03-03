using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prameter_Passing_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15; squareVal(a);
            Console.WriteLine("square of number is : " + a); Console.ReadKey();
        }

        static void squareVal(int valParameter)
        {
            valParameter *= valParameter;
        }
    }
}

    
