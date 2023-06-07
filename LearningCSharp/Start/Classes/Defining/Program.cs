using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("Clean Code", "Uncle Bob", 500);
            Book b2 = new Book("The Pragmatic Programmer", "David Thomas & Andrew Hunt", 400);

            // TODO: Call a method on the object
            System.Console.WriteLine(b1.GetDescription());
            System.Console.WriteLine(b2.GetDescription());


            // TODO: try to set one of the properties -- 
            // this will result in an error
            b1._name = "nope, can't do this";

        }
    }
}
