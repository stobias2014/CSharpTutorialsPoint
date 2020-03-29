//encapsulation - process of enclosing items into a container
//prevents access to members

//abstraction-reveals only essential information
//encapsulation-allows developer to implement desired level of implementation
//implemented by access specifiers: public, private, protected, internal, protected internal

using System;

namespace RectangleEncapsulationApp
{
    class Rectangle {

        //private restricts access to only funtions within class
        private double length;
        private double width;
        //internal gives access to function and objects in the current assembly
        internal string name;

        //public allows access external to the class
        public void getDetails()
        {
            Console.WriteLine("Please enter a length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a width");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", getArea());
            Console.WriteLine("Shape: {0}", name);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //instantiation of object
            Rectangle r = new Rectangle();
            r.getDetails();
            //internal variable accessed from outside class but inside assembly
            r.name = "Rectangle";
            r.display();
        }
    }
}
