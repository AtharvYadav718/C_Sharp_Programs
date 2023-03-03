using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameter_Passing_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number :-"); a = Convert.ToInt32(Console.ReadLine()); squareRef(ref a);
            Console.WriteLine(a); Console.ReadKey();
        }
        static void squareRef(ref int refpar)
        {
            refpar *= refpar;
        }
    }
}

