//dynamic poly occurs at runtime
//occurs with inheritance
//abstract classes provide partial implementation
//cannot be instantiated
//comtain abstarct method that are implemeted by derived class
//cannot be declared as saealed(not being able to be inherited)

using System;

namespace DynamicPolymorphismApp
{
    //declaration of an abstract class
    public abstract class Shape
    {
        //override function - same function name, different implementation
        //must be implemented by derived class
        public abstract double area();
        public abstract void display();
    }

    class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        //implements inherited method from abstract class
        //use of override keyword to override parent method
        public override double area()
        {
            return length * width;
        }

        public override void display()
        {
            Console.WriteLine("Rectangle Area: {0}", area());
        }
    }

    public class Circle : Shape
    {
        private const double PI = 3.14;
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override double area()
        {
            return r * PI;
        }

        public override void display()
        {
            Console.WriteLine("Circle Area: {0}", area());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3, 4);
            Circle c = new Circle(3.45);

            r.display();
            c.display();
        }
    }
}
