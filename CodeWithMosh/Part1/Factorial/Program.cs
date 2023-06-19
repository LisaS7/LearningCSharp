Console.Write("Choose a number: ");
int number = Int32.Parse(Console.ReadLine());

int factorial = 1;
int current = number;
while (current > 0)
{
    factorial *= current;
    current--;
}

Console.WriteLine($"{number}! = {factorial}");
