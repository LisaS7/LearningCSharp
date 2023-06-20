var fullName = "   Lisa Steven  ";

Console.WriteLine($"Trim: {fullName.Trim()}");
Console.WriteLine($"Upper: {fullName.Trim().ToUpper()}");
Console.WriteLine($"Lower: {fullName.Trim().ToLower()}");

// Substring
fullName = fullName.Trim();
var index = fullName.IndexOf(" ");
var firstName = fullName.Substring(0, index);
var lastName = fullName.Substring(index + 1);
Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);

// Split
string[] names = fullName.Split(' ');
Console.WriteLine("First Name: " + names[0]);
Console.WriteLine("Last Name: " + names[1]);

// Replace
string newName = fullName.Replace("Lisa", "Alec");
Console.WriteLine("Replace: " + newName);

// Null check
string userInput = " ";
if (string.IsNullOrWhiteSpace(userInput)) { Console.WriteLine("Oops, you need to enter a value!"); }

// Convert
string age = "34";
int ageConverted = Convert.ToByte(age);
Console.WriteLine("Converted age: " + ageConverted);

float price = 29.95f;
string formatted = price.ToString("C");
Console.WriteLine("Formatted price: " + formatted);
