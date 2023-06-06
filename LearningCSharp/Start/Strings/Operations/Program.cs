using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = { "one", "two", "three", "four" };

            // TODO: Length of a string 
            System.Console.WriteLine(str1.Length);

            // TODO: Access individual characters
            System.Console.WriteLine(str1[14]);

            // TODO: iterate over a string like any other sequence of values
            foreach (char ch in str1)
            {
                System.Console.Write(ch);
                if (ch == 'b')
                {
                    System.Console.WriteLine();
                    break;
                }
            }

            // TODO: String Concatenation         
            outstr = String.Concat(strs);
            System.Console.WriteLine(outstr);

            // TODO: Joining strings together with Join
            outstr = String.Join('.', strs);
            System.Console.WriteLine(outstr);

            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = String.Compare(str2, "This is a string");
            System.Console.WriteLine(result);

            // TODO: Equals just returns a regular Boolean
            bool isEqual = str2.Equals(str3);
            System.Console.WriteLine(isEqual);

            // TODO: String Searching
            System.Console.WriteLine(str1.IndexOf('e'));
            System.Console.WriteLine(str1.IndexOf("fox"));
            System.Console.WriteLine(str1.LastIndexOf('e'));
            System.Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("fox", "cat");
            System.Console.WriteLine(outstr);

        }
    }
}
