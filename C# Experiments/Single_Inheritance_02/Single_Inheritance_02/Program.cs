using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_02
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

    public class Rectangle : Shape
    {
        public int Area()
        {
            int area = length * width;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle();
            obj1.getlength(10);
            obj1.getwidth(15);
            Console.WriteLine("Area of Rectange is : " + obj1.Area());
            Console.ReadKey();
        }
    }
}

