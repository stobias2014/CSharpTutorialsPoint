//virtual function is used when you want derived class to implement the function

using System;

namespace VirtualFuntionApp
{
    public class Shape
    {
        protected int length, height;

        public Shape(int length = 0, int height = 0)
        {
            this.length = length;
            this.height = height;
        }

        public virtual int area()
        {
            Console.WriteLine("Shape area: ");
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b) { }

        public override int area()
        {
            Console.WriteLine("Rectangle area: ");
            return length * height;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }

        public override int area()
        {
            Console.WriteLine("Triangle area: ");
            return (length * height) / 2;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Triangle t = new Triangle();

            r.area();
            t.area();

        }
    }
}
