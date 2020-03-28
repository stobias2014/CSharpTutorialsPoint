using System;

namespace LoopsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string beer;
            bool isNotAvailable = true;
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 21)
            {
                Console.WriteLine("You are {0}, a legal age to purchase alcohol\n", age);
                
                while(isNotAvailable)
                {
                    Console.WriteLine("What beer would you like to purchase");
                    beer = Console.ReadLine();
                    switch (beer.ToUpper())
                    {
                        case "CORONA":
                            Console.WriteLine("{0} is available", beer.ToUpper());

                            isNotAvailable = false;
                            break;
                        case "MODELO":
                            Console.WriteLine("{0} is available.", beer.ToUpper());
                            isNotAvailable = false;
                            break;
                        case "BUD LIGHT":
                            Console.WriteLine("{0} is available.", beer.ToUpper());
                            isNotAvailable = false;
                            break;
                        default:
                            Console.WriteLine("{0} is not available. Please try again. ", beer.ToUpper());
                            break;
                    }
                }
                
            } else
            {
                Console.WriteLine("You are {0}, an age below the legal requirement to purchase alcohol.",age);
            }
        }
    }
}
