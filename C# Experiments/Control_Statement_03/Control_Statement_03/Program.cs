using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Statement_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter the three numbers :- ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine()); if (a > b && a > c)
            {
                Console.WriteLine(a + " is bigest number.");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is bigest number.");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is bigest number.");
            }
            else
            {
                Console.WriteLine("All numbers are equals.");
            }
            Console.ReadKey();
        }
    }
}
