//struct is value data type
//single variable that holds related data
//used to represent record


//features of struct
//can have methods, fields, properties, etc.
//defined constructor, but not destructor - cannot define default constructor though
//cannot inherit other strcuts or classes
//cannot be used as base
//can implement one or more interfaces
// members cannot be defined as abstract, virtual, protected
//using new will create strcut with appro call to constructor
//can be instantiated without constructor specific call
//if new used, members are unassigned and cannot be used until initialized

using System;

namespace StructApp
{
    struct Book {
        public string title;
        public string author;
        public string genre;
        public long bookId;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // declare variables of Book type
            Book b1;
            Book b2;

            //initialize members of struct
            b1.title = "A title";
            b1.author = "An Author";
            b1.genre = "Horror";
            b1.bookId = 178394839749;

            b2.title = "Another Title";
            b2.author = "Another Author";
            b2.genre = "Romance";
            b2.bookId = 343898023;

            Console.WriteLine("Book 1 Title: {0}", b1.title);
            Console.WriteLine("Book 1 Author: {0}", b1.author);
            Console.WriteLine("Book 1 Genre: {0}", b1.genre);
            Console.WriteLine("Book 1 ID: {0}\n", b1.bookId);

            Console.WriteLine("Book 2 Title: {0}", b2.title);
            Console.WriteLine("Book 2 Author: {0}", b2.author);
            Console.WriteLine("Book 2 Genre: {0}", b2.genre);
            Console.WriteLine("Book 2 ID: {0}", b2.bookId);

        }
    }
}
