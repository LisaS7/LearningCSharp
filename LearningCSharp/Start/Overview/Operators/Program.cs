using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x = 10, y = 5;
            string a = "abcd", b = "efgh";

            // TODO: Basic math operators are +, -, /, *
            // Console.WriteLine("----- Basic Math -----");
            // Console.WriteLine((x / y) * x);
            // Console.WriteLine(a + b);

            // TODO: Increment / decrement operators
            // Console.WriteLine("----- Shorthand -----");
            x++;
            y--;
            // System.Console.WriteLine(x);
            // System.Console.WriteLine(y);

            // TODO: Operators can be shorthand: a = a + b
            a += b;
            // System.Console.WriteLine(a);

            // TODO: Logical operators &&, ||
            // Console.WriteLine("----- Logic Operators -----");
            // System.Console.WriteLine(x > y && y >= 5);
            // System.Console.WriteLine(x > y || y >= 5);

            // null-coalescing operators
            string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            System.Console.WriteLine(str ?? "Unknown");

            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            str ??= "new string";
            System.Console.WriteLine(str);
        }
    }
}
