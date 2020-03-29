using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int findMax(int n1, int n2) {
            int max;

            if(n1 > n2) {
                max = n1;
            } else {
                max = n2;
            }

            return max;
        }

        public int fact(int n)
        {
            int result;

            if(n ==1)
            {
                return 1;

            }
            else
            {
                result = fact(n - 1) * n;
                return result;
            }


        }

    }

    class Test
    {
        static void Main(String[] args)
        {
            int n1 = 105;
            int n2 = 340;
            int n3 = 4;
            int max;

            NumberManipulator nm = new NumberManipulator();
            max = nm.findMax(n1, n2);

            Console.WriteLine("Max from {0} and {1} is {2}", n1, n2, max);
            Console.WriteLine("Factorial of {0} = {1}", n3, nm.fact(n3));
        }
        
    }

}
