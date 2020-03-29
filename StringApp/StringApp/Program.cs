//different ways to create and use string

using System;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Saul";
            lname = "Tobias";

            char[] letters = { 'h', 'e', 'l', 'l', 'o'};
            string[] words = { "These", "are", "words", "in", "array" };

            //concatenation
            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fname);

            //string constructor
            string greeting = new string(letters);
            Console.WriteLine("Greeting: {0}", greeting);

            //methods that return string
            string message = String.Join(" ", words);
            Console.WriteLine("Message: {0}", message);

            //formatting methods
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}\n", chat);

        }
    }
}
