using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Exception
{
    internal class Program : Exception
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception Has Occured : {0}", e.Message);
                Console.ReadLine();
            }
        }
    }
}

