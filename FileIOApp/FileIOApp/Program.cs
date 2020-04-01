//file is a collection of data stored in disk with a name and directory path
//when file opened for reaading or writing, becomes a stream
//stream is a sequence of bytes passing thru communication path
//input and output stream( readin and writing operation)
//FileStream parent is Stream 

using System;
using System.IO;

namespace FileIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int i = 0; i <= 20; i++)
            {
                //writes bytes to file
                fs.WriteByte((byte)i);
            }

            //sets position property to zero
            //start at beginning of file
            fs.Position = 0;

            for(int i =0; i <= 20; i++)
            {
                Console.Write(fs.ReadByte() + " ");
            }

            //close file stream when don ewith operations
            fs.Close();
            Console.WriteLine("\nDone with RW Operations");
        }
    }
}
