// Write a program and ask the user to enter a series of numbers separated by comma. 
// Find the maximum of the numbers and display it on the console. 
// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

Console.Write("Enter list of numbers, separated by commas: ");
string input = Console.ReadLine();
string[] strings = input.Split(",");
int[] numbers = Array.ConvertAll(strings, s => int.Parse(s));

int currentMax = 0;
foreach (int number in numbers)
{
    if (number > currentMax)
    {
        currentMax = number;
    }
}

Console.WriteLine($"The maximum number is {currentMax}");
