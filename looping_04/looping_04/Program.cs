using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace looping_04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}



