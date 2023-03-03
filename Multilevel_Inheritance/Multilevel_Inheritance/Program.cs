using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{

    public class A
    {
        public void show()
        {
            Console.WriteLine("Hello from class A,Batch 1");
        }
    }
    public class B : A
    {
        public void display()
        {
            Console.WriteLine("Hello from class B,Batch 2");
        }
    }

    public class C : B
    {
        public void greet()
        {
            Console.WriteLine("Hello from class C,Batch 3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.show();
            c1.display();
            c1.greet();
            Console.ReadKey();
        }
    }
}
