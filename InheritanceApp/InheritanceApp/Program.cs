//multiple inheritance not supported

using System;

namespace InheritanceApp
{
    public interface PaintCost
    {
        double getCost();
    }

    public class Rectangle
	{
        protected double length;
        protected double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
        }
	}

    public class TableTop : Rectangle, PaintCost
    {
        private double cost;
        //initialize base class through derived member list
        public TableTop(double length, double width) : base(length, width) { }

        public double getCost()
        {
            
            //has access to parent class members
            cost = getArea() * 70;
            return cost;
        }

        //overridden method
        public new void display()
        {
            base.display();
            Console.WriteLine("Cost: {0}", getCost());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TableTop t1 = new TableTop(3.45, 5.67);
            t1.display();
            
        }
    }
}
