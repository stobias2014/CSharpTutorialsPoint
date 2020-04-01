//reads data from text files
//

using System;
using System.IO;

namespace StreamReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //create instance of streamreader
                //using statement closes streamreader
                using (StreamReader sr = new StreamReader("/Users/saultobias/Desktop/jamaica.rtf"))
                {
                    //to store line that is being read
                    string line;

                    //read and display file lines
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e) {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }

        }
    }
}
