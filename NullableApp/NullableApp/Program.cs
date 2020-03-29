//nullable type - you can assign regular data type as well as null value (?)

using System;

namespace NullableApp
{
    class Nullables
    {
        static void Main(string[] args)
        {
            //syntax for nullable types
            int? n1 = null;
            int? n2 = 4;

            double? d1 = new double?();
            double? d2 = 3.43;
            double d3;

            bool? b = new bool?();

            Console.WriteLine("Nullable: {0}, {1}, {2}, {3}", n1, n2, d1, d2);
            Console.WriteLine("Nullable bool: {0}\n", b);

            //5.1 default value
            //?? coelescing operator
            d3 = d1 ?? 5.1;
            Console.WriteLine("?? can be used to assign some default value.");
            Console.WriteLine("d3 = {0}", d3);


        }
    }
}
