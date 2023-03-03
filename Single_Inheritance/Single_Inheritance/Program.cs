using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer obj1 = new Programmer();
            Console.WriteLine("Salary : " + obj1.salary);
            Console.WriteLine("Bonus : " + obj1.bonus);
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public float salary = 40000;
    }
    public class Programmer : Employee
    {
        public float bonus = 1000;
    }
}
