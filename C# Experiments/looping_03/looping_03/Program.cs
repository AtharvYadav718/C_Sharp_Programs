using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace looping_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 18; int t = 1; do
            {
                Console.WriteLine("{0} * {1} = {2}", i, t, i * t); t++;
            }
            while (t <= 10); 
            Console.ReadKey();
        }
    }
}


