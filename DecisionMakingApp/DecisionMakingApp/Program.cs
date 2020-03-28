using System;

namespace DecisionMakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string beerName;

            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(age >= 21)
            {
                Console.WriteLine("You are {0} years old. You can buy alcohol\n", age);
                Console.WriteLine("What would you like to buy?");
                beerName = Console.ReadLine();
                Console.WriteLine();

                switch(beerName.ToUpper())
                {
                    case "CORONA":
                        Console.WriteLine("{0} beer is your option. ", beerName.ToUpper());
                        break;
                    case "BUD LIGHT":
                        Console.WriteLine("{0} beer is your option. ", beerName.ToUpper());
                        break;
                    case "MODELO":
                        Console.WriteLine("{0} beer is your option. ", beerName.ToUpper());
                        break;
                    default:
                        Console.WriteLine("{0} beer is not available. ", beerName.ToUpper());
                        break;
                }
            } else
            {
                Console.WriteLine("You are {0} years old. You cannot buy alcohol.", age);
            }
        }
    }
}
