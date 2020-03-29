//enumaration is a set of named integer constant
//value data type -  contains its own values
//cannot inherit or pass inheritance


using System;

namespace EnumApp
{
    class Program
    {
        //each symbol represents an integer
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        static void Main(string[] args)
        {
            //constant
            int WeekDayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0} {1}", WeekDayStart, Days.Mon);
            Console.WriteLine("Sunday: {0} {1}", WeekDayEnd, Days.Fri);
        }
    }
}
