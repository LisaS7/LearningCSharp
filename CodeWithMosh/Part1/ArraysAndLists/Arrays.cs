int[] numbers = new[] { 2, 6, 9, 2, 4, 0 };

// Length
Console.WriteLine("Length: " + numbers.Length);

// IndexOf()
int index = Array.IndexOf(numbers, 9);
Console.WriteLine("Index of 9: " + index);


// Clear (note that this sets the values to 0 (or the default for the given data type), it does not shorten the array)
Console.WriteLine("\nCLEAR");
Array.Clear(numbers, 0, 2);
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

// Copy
Console.WriteLine("\nCOPY");
int[] anotherArray = new int[3];
Array.Copy(numbers, anotherArray, 3);
foreach (int n in anotherArray)
{
    Console.WriteLine(n);
}

// Sort
Console.WriteLine("\nSORT");
Array.Sort(numbers);
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

// Reverse
Console.WriteLine("\nREVERSE");
Array.Reverse(numbers);
foreach (int n in numbers)
{
    Console.WriteLine(n);
}