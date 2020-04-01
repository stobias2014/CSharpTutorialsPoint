//regular expression is a pattter that could be matched against an input

using System;
using System.Text.RegularExpressions;

namespace RegularExpressionApp
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The expression: {0}", expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "A Thousand Splendid Suns";

            Console.WriteLine("Matching words with S ");
            showMatch(str, @"\bS\S*");
        }
    }
}
