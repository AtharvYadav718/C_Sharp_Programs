using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Class
{
 
public abstract class Shape
{
public abstract void draw();
}

public class Rectangle : Shape
{
public override void draw()
{
Console.WriteLine("DRAWING RECTANGLE	");
}
}

public class Circle : Shape
{
public override void draw()
{
Console.WriteLine("DRAWING CIRCLE	");
}
}

public class Myclass
{
public static void Main(string[] args)
{
Shape s;
s = new Rectangle(); s.draw();
s = new Circle();

s.draw(); Console.ReadKey();
}
}
}

