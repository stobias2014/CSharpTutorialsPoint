using System;

namespace OperatorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Please enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter another number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arithmetic operations");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
            Console.WriteLine("++x = {0}", ++x);
            Console.WriteLine("--y = {0} \n", --y);

            Console.WriteLine("Relational Operations");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
            Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
            
        }
    }
}
