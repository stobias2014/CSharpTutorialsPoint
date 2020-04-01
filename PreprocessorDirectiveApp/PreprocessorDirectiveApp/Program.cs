//preprocessor directive used to give instructions to compiler to preprocess info before comp
//used to help conditional compilation

//preprocessor declarations
#define DEBUG
#define VC_V10

using System;

namespace PreprocessorDirectiveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //only true will compile
#if (DEBUG && !VC_V10)
            Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
            Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
            Console.WriteLine("DEBUG and VC_V10 are defined");
#else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif
        }
    }
}
