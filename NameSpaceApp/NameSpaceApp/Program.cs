//namespace is area to keep one set of names separate from others
//avoids name clashing

//using keyword states the namespace you are using
//don't have to use fully qualified name

//nested namespaces can also be used

using System;
using space_1;
using space_2;

namespace space_1
{
    class c1
    {
        public void function1()
        {
            Console.WriteLine("Inside namespace 1");
        }
    }
}

namespace space_2
{
    class c2
    {
        public void function1()
        {
            Console.WriteLine("Inside namespace 2");
        }
    }
}


class Program
    {
        static void Main(string[] args)
        {
        //space_1.c1 firstClass = new space_1.c1();
        c1 firstClass = new space_1.c1();
        //space_2.c1 secondClass = new space_2.c1();
        c2 secondClass = new space_2.c2();

        firstClass.function1();
        secondClass.function1();
        }
    }

