//using is used to include namespaces in your application
using System;

namespace RectangleApplication
{
    //class declaration
    class Rectangle
    {
        //member variable
        double width;
        double length;

        public void acceptDetails() {
            width = 4.9;
            length = 5.4;
        }

        public double getArea()
        {
            return width * length;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
        }

    }

    //class with main
    //main is entry point of program
    //where code starts execution
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate object from class Rectangle
            Rectangle rect = new Rectangle();
            //call on method members of object rect
            rect.acceptDetails();
            rect.display();
            //waits until enter is pressed to end program
            Console.ReadLine();
        }
    }
}
