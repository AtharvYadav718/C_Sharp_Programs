using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = new string[5];
            book[0] = "SONG OF ICE AND FIRE"; book[1] = "THE WHITCHER";
            book[2] = "ALL OF US ARE DEAD"; book[3] = "HOUSE OF DRAGON"; book[4] = "MAN ME HAIN VISHWAAS";
            Console.WriteLine("All the book names are :\n"); for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} ", book[i]);
            }
            Console.ReadKey();
        }
    }
}

