// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Employee e = new Employee("Spock", "Steven", 27)
{
    StartDate = new DateOnly(2023, 06, 03)
};

Console.WriteLine($"From {e.FirstName}, hello world");
