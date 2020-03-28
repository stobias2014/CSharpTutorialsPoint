using System;

namespace DeclaringConstantsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of a constant
            const double pi = 3.14;
            double r;
            double area;

            Console.WriteLine("Enter a radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            //error in compilation beacuse pi is constant
            //pi = 5.667;

            area = r * pi;

            Console.WriteLine("pi = {0}, r = {1}", pi, r);
            Console.WriteLine("area = {0}", area);

        }
    }
}
