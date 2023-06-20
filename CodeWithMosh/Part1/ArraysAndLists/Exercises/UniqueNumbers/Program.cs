//  Write a program and ask the user to enter 5 numbers. 
//  If a number has been previously entered, display an error message and ask the user to re-try. 
//  Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


var numbers = new List<int>();


while (numbers.Count < 5)
{
    Console.WriteLine("Please enter a number: ");
    int number = Int32.Parse(Console.ReadLine());
    int index = numbers.IndexOf(number);

    if (index == -1)
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Sorry, that number has already been entered!");
    }

}

numbers.Sort();
foreach (int i in numbers)
{
    Console.WriteLine(i);
}