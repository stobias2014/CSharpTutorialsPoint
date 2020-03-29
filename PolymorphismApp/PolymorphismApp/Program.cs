//polymorphism means having many forms
//one interface, multiple functions
//static(compile) and dynamic(runtime) polymorphism
//static - function and operator overloading
//function overloading - same function name, different signature

using System;

namespace PolymorphismApp
{
    public class PrintData
    {
        //function overloading
        //same function name
        //different parameter type

        public void print(int a)
        {
            Console.WriteLine("Integer: {0}", a);
        }

        public void print(double a)
        {
            Console.WriteLine("Double: {0}", a);
        }

        public void print(string a)
        {
            Console.WriteLine("String: {0}", a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintData pd = new PrintData();
            int a = 5;
            double d = 5.6;
            string s = "5.6";

            //depending on the parameter type passed it will call pertaining function
            pd.print(a);
            pd.print(d);
            pd.print(s);
        }
    }
}
