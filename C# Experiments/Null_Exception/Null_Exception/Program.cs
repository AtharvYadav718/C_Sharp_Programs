using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Exception
{
    internal class Program
    {
        static void Main()
        {
            string str = null;
            if (str.Length > 0)
            {
                Console.WriteLine(str);
                Console.ReadLine();
            }
        }
    }
}

