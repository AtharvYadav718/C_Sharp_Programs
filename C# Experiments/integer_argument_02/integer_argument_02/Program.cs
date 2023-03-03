using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace integer_argument_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(args[0]); 
            Console.WriteLine("Arguments in integers : " + args[0]);
            double b = Convert.ToDouble(args[1]); 
            Console.WriteLine("Arguments in doubles : " + args[1]); 
            Console.ReadKey();
        }
    }
}

