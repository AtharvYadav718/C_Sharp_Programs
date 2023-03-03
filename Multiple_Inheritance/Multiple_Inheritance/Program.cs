using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    class Program
    {
        public class Shape
        {
            public void getlength(int l)
            {
                this.length = l;
            }
            public void getwidth(int w)
            {
                this.width = w;
            }
            protected int length;
            protected int width;
        }
        public interface Paintcost
        {
            int getcost(int area);
        }
        public class Rectangle : Shape, Paintcost
        {
            public int getArea()
            {
                return length * width;
            }
            public int getcost(int area)
            {
                return area * 70;
            }
        }
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle();
            obj1.getlength(10);
            obj1.getwidth(15);
            Console.WriteLine("Area Of Rectangle Is : " + obj1.getArea());
            Console.WriteLine("Cost Of Paint Is : " + obj1.getcost(20));
            Console.ReadKey();
        }
    }
}
