using System;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //use try catch when doing rw operations
            string[] names = new string[] { "NAME1", "NAME2" };

            //write to file
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach(string s in names) {
                    sw.WriteLine(s);
                }
            }

            //read file
            using (StreamReader sr = new StreamReader("names.txt")) {
                string line;

                while((line = sr.ReadLine()) != null) {
                    Console.WriteLine("Name: {0}", line);
                }

            }



        }
    }
}
