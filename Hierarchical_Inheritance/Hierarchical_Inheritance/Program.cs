using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    public class A
    {
        public void show()
        {
            Console.WriteLine("Welcome To BCS III");
        }
    }

    public class B : A
    {
        public void display()
        {
            Console.WriteLine("Welcome To BCS III,Batch 1");
        }
    }

    public class C : A
    {
        public void greet()
        {
            Console.WriteLine("Welcome To BCS III,Batch 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            C c1 = new C();
            b1.show();
            b1.display();
            c1.show();
            c1.greet();
            Console.ReadKey();
        }
    }
}


