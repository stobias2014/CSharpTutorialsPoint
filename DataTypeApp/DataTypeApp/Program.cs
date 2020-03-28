//Application shows available data types


using System;

namespace DataTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolType = false;
            char charType = 'a';
            double doubleType = 4.5;
            float floatType = 4.5f;
            int intType = 6;
            long longType = 4575993903;

            Console.WriteLine("These are some data types in C# \n");

            Console.WriteLine("bool: {0}", boolType);
            Console.WriteLine("char: {0}", charType);
            Console.WriteLine("double: {0}", doubleType);
            Console.WriteLine("float: {0}", floatType);
            Console.WriteLine("int: {0}", intType);
            Console.WriteLine("long: {0}", longType);

            Console.WriteLine();

            Console.WriteLine("Showcasing method sizeof() for data types \n");

            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of double: {0}", sizeof(double));
            Console.WriteLine("Size of float: {0}", sizeof(float));
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of ling: {0}", sizeof(long));


        }
    }
}
