using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("Kiran.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
    }
}

