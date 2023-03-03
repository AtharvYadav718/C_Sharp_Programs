using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace looping_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; while (a <= 9)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
