var numbers = new List<int>() { 1, 2, 3, 4 };
numbers.Add(1);
numbers.AddRange(new int[3] { 5, 6, 7 });

foreach (int n in numbers)
{
    Console.WriteLine(n);
}

int index = numbers.IndexOf(1);
Console.WriteLine("First 1: " + index);

int lastIndex = numbers.LastIndexOf(1);
Console.WriteLine("Last 1: " + lastIndex);

int count = numbers.Count();
Console.WriteLine("Count: " + count);

numbers.Remove(1);

Console.WriteLine("Removed 1: ");
foreach (int n in numbers)
{
    Console.WriteLine(n);
}

numbers.Clear();
Console.WriteLine("Count: " + count);

