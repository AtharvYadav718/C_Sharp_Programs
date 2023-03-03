using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Statement_04
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 120; if (a > 10)
            {
                if (a < 100)
                {
                    Console.WriteLine(a + " is less than 100.");
                }
                else
                {
                    Console.WriteLine(a + " is greater than 100.");
                }
            }
            else
            {
                Console.WriteLine(a + " is less than 10.");
            }
            Console.ReadKey();
        }
    }
}
