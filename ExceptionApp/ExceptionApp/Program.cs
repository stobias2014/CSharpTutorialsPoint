//an exception is a proble that may occur during execution of program
//exception handling deals with these propblems without having to crash the program
//exceptions provide a way to transfer control from one part of program to another
// use try catch block
//try,catch,finally, throw

using System;

namespace ExceptionApp
{
    class DivNumbers
    {
        private int result;

        public DivNumbers() {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try {
                result = num1 / num2;
            } catch (DivideByZeroException de) 
            {
                Console.WriteLine("Exception caught: {0}", de);
            } finally
            {
                Console.WriteLine("Result: {0}", result);
            }

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers dv = new DivNumbers();

            dv.division(26, 0);
        }
    }
}
