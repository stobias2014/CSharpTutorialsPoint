//an exception is a proble that may occur during execution of program
//exception handling deals with these propblems without having to crash the program
//exceptions provide a way to transfer control from one part of program to another
// use try catch block
//try,catch,finally, throw

using System;

namespace ExceptionApp
{
    public class DivNumbers
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

    public class TemperatureIsZeroException : Exception {
        public TemperatureIsZeroException(string message) : base(message) {}
    }


    public class Temperature {
        int temp = 0;

        public void showTemp()
        {
            if (temp == 0) {
                throw new TemperatureIsZeroException("Zero Temperature Found");
            } else {
                Console.WriteLine("Temperature: {0}", temp);
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DivNumbers dv = new DivNumbers();
            Temperature t = new Temperature();

            dv.division(25, 5);
            try
            {
                t.showTemp();
            } catch (TemperatureIsZeroException te)
            {
                Console.WriteLine("TemperatureIsZeroException: {0}", te);
            }
        }
    }
}
