//shows example of types of conversion

//implicit type conversion - type safe, small to big
//explicit type conversion - not type safe, done explicitly by user, requires cast operator
using System;

namespace TypeConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 5.673883;
            int i;

            int myInt = 5;
            double myDouble = 5.674;
            bool b = true;

            //explicit cast
            //cast double to integer type
            i = (int) d;

            Console.WriteLine("Casting double to int: {0} \n", i);
            

            Console.WriteLine("Casting different types to string");

            Console.WriteLine("integer to string: {0}", myInt.ToString());
            Console.WriteLine("double to string: {0}", myDouble.ToString());
            Console.WriteLine("bool to string: {0}", b.ToString());

            Console.ReadKey();
        }
    }
}
