using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_Statement_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthno;
            Console.WriteLine("Enter the month number :- ");
            monthno = Convert.ToInt32(Console.ReadLine()); 
            switch (monthno)
            {
                case 1:
                    Console.WriteLine("JANUARY"); break;
                case 2:
                    Console.WriteLine("FEBRUARY"); break;
                case 3:
                    Console.WriteLine("MARCH"); break;
                case 4:
                    Console.WriteLine("APRIL"); break;
                case 5:
                    Console.WriteLine("MAY"); break;
                case 6:
                    Console.WriteLine("JUNE"); break;
                case 7:
                    Console.WriteLine("JULLY"); break;
                case 8:
                    Console.WriteLine("AUGUST"); break;
                case 9:
                    Console.WriteLine("SEPTEMBER"); break;
                case 10:

                    Console.WriteLine("OCTOBER"); break;
                case 11:
                    Console.WriteLine("NOVEMBER"); break;
                case 12:
                    Console.WriteLine("DECEMBER"); break;
                default:
                    Console.WriteLine("PLEASE ENTER VALID NUMBER.");
                    break;
            }
            Console.ReadKey();
        }

    }
}
