using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace looping_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int factorial = 1;
            Console.WriteLine("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of number is : " + factorial); Console.ReadKey();
        }
    }
}

