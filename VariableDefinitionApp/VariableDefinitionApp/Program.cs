using System;

namespace VariableDefinitionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable definitions
            int i;
            double d;
            bool b;
            char c;

            //initializing varaibles
            i = 5;
            d = 7.65;
            b = false;
            c = 'g';

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);

            //accept input from user
            Console.WriteLine("Enter a number: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: {0}", i);

            

        }
    }
}
