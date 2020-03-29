//class is a blueprint from where objects can be created
//has attributes and actions
//constructor is default if no user defined
//used to initialize member vaiables
//access specifies: private, public, protected
//static keyword means only one copy for the class

using System;

namespace BoxApp
{
    public class Box
    {
        //static member
        //only one copy
        public static int count;

        //member variables
        private int length;
        private int width;
        private int height;

        //default constructor
        public Box() {
            Console.WriteLine("Box object created");
            count++;
        }

        //user defined for initialization
        //overloaded constructor
        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            count++;
        }

        //method members
        public void setLength(int length)
        {
            this.length = length;
        }

        public int getLength()
        {
            return this.length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getWidth()
        {
            return this.width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getHeight()
        {
            return this.height;
        }

        public int getVolume()
        {
            return length * width * height;
        }


        ~Box()
        {
            Console.WriteLine("Box object deleted.");
        }

    }

    class BoxTester
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box(3, 5, 7);

            b1.setLength(5);
            b1.setWidth(3);
            b1.setHeight(9);

            Console.WriteLine("Box 1 Dimensions");
            Console.WriteLine("Length = {0}, Width = {1}, Height = {1}", b1.getLength(), b1.getWidth(), b1.getHeight());
            Console.WriteLine("Volume for Box 1: {0}\n", b1.getVolume());
            Console.WriteLine("Box 2 Dimensions");
            Console.WriteLine("Length = {0}, Width = {1}, Height = {1}", b2.getLength(), b2.getWidth(), b2.getHeight());
            Console.WriteLine("Volume for Box 2: {0}\n", b2.getVolume());


            Console.WriteLine("Boxes created: {0}", Box.count);
        }
    }
}
