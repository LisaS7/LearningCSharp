using System;

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix = "")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hey dude");
PrintWithPrefix("Hey dude", "__ >");

// TODO: Call with named params
PrintWithPrefix(prefix: "_-_-_ ", thestr: "Hey dude");
