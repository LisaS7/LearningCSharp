using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKm(float miles)
{
    float result = miles * 1.6f;
    return result;
}

// TODO: A function with no return value has a 'void' type
void PrintWithPrefix(string theStr)
{
    System.Console.WriteLine($"::> {theStr}");
}


// TODO: Call first function
System.Console.WriteLine($"The result is {MilesToKm(8.0f)}");
System.Console.WriteLine($"The result is {MilesToKm(52.0f)}");


// TODO: Call second function
PrintWithPrefix("Test string");
PrintWithPrefix("abc");

