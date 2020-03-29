using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //different ways to intialize array
            int[] intArray = new int[10];
            double[] balance = { 5.4, 2.3, 3.7, 4.8 };
            int[] marks = new int[5] {1, 2, 3, 4, 5 };
            double[] price = new double[] { 2.4, 3.6, 2.7, 4.3, 3.3 };

            intArray[0] = 200;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("index {0} = {1}", i, intArray[i]);
            }

            Console.WriteLine();

            foreach(double b in balance) {
                Console.WriteLine("{0}", b);
            }


        }
    }
}
