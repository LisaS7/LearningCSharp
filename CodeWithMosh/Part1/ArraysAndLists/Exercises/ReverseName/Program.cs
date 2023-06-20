// Write a program and ask the user to enter their name. 
// Use an array to reverse the name and then store the result in a new string. 
// Display the reversed name on the console.

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
var letters = new char[name.Length];

for (int i = 0; i < name.Length; i++)
{
    letters[i] = name[i];
}
Array.Reverse(letters);

string reversedName = string.Join("", letters);

Console.WriteLine("Your name backwards is " + reversedName);


