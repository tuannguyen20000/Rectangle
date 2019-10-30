using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine("Circumference of Circle is " + c.getCircumference());
            Console.WriteLine(c.ToString());

            Rectangle r = new Rectangle();
            r.setLength(5);
            r.setWidth(5);
            Console.WriteLine("perimeter Rectangle is " + r.getPerimeter());
            Console.WriteLine("area Rectangle is " + r.getArea());
            Console.WriteLine(r.ToString());
        }
    }
}
    

