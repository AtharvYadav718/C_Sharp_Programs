using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constrol_Statement_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is even number.");
            }
            else
            {
                Console.WriteLine(a + " is odd number.");
            }
            Console.ReadKey();
        }
    }
}
