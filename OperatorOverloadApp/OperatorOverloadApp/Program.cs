//able to redifine/overload most built in operators
//overloaded operators - special functions with use of operator
//take in parameters just like regular function

using System;


namespace OperatorOverloadApp
{
    //class declaration
    class Box
    {
        //member variables
        private double length;
        private double width;
        private double height;
        

        //constructor
        public Box() { }

        //overloaded constructor
        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //member function
        public double getVolume()
        {
            return length * width * height;
        }

        //overloaded operator function
        //the (+) has been overloaded for this implementation
        //notice keyword operator followed by operator to overload
        public static Box operator+ (Box b1, Box b2)
        {
            Box b3 = new Box();
            b3.length = b1.length + b2.length;
            b3.width = b1.width + b2.width;
            b3.height = b1.height + b2.height;
            
            return b3;
        }

        //gives warning, override equals and hash code to fix
        //check equality of box dimensions
        public static bool operator ==(Box lhs, Box rhs)
        {
            //set default value
            bool status = false;

            if (lhs.length == rhs.length && lhs.width == rhs.width
                && lhs.height == rhs.height)
            {
                status = true;
            }

            return status;
        }


        //need to define both equal and non equal, else compilation error
        public static bool operator !=(Box lhs, Box rhs)
        {
            //set default value
            bool status = false;

            if (lhs.length != rhs.length && lhs.width != rhs.width
                && lhs.height != rhs.height)
            {
                status = true;
            }

            return status;
        }

        //relational operators need counterpart operator to be defined
        public static bool operator< (Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length < rhs.length && lhs.width < rhs.width
                && lhs.height < rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator> (Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length > rhs.length && lhs.width > rhs.width
                && lhs.height > rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length<=rhs.length && lhs.width<=rhs.width
                && lhs.height<=rhs.height)
            {
                status = true;
            }

            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length >= rhs.length && lhs.width >= rhs.width
                && lhs.height >= rhs.height)
            {
                status = true;
            }

            return status;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(6.0, 7.0, 5.0);
            Box box2 = new Box(12.0, 13.0, 10.0);
            Box box3 = new Box();

            double volume = 0.0;

            volume = box1.getVolume();
            Console.WriteLine("Box1 Volume: {0}", volume);

            volume = box2.getVolume();
            Console.WriteLine("Box2 Volume: {0}", volume);

            //use of overloaded function
            box3 = box1 + box2;

            volume = box3.getVolume();
            Console.WriteLine("Box3 Volume: {0}", volume);

            if(box1 == box2)
            {
                Console.WriteLine("Boxes are equal");
            } else
            {
                Console.WriteLine("Boxes are not equal");
            }

            if(box1 != box2)
            {
                Console.WriteLine("Boxes are not equal");
            } else
            {
                Console.WriteLine("Boxes are equal");
            }

            if(box1 > box2)
            {
                Console.WriteLine("Box1 is greater than Box2");
            } else
            {
                Console.WriteLine("Box1 is not greater than Box2");
            }

            if(box1 < box2)
            {
                Console.WriteLine("Box 1 is less than box2");
            } else
            {
                Console.WriteLine("Box1 is not less than Box2");
            }

            if (box1 >= box2)
            {
                Console.WriteLine("Box1 is greater than or equal than Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not greater than or equal to Box2");
            }

            if (box1 <= box2)
            {
                Console.WriteLine("Box 1 is less than or equal to Box2");
            }
            else
            {
                Console.WriteLine("Box1 is not less than or equal to Box2");
            }

        }
    }
}
