using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1005;
            int y = 0;
            int result;

            // TODO: try-catch expressions make error checking easier
            try
            {
                if (x > 1000)
                {
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);

            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine("Oh no!!");
                System.Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine("Sorry, 1000 is the limit");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine("This always runs!");
            }
        }
    }
}
