using System.Text;

// function to reverse string
static string ReverseString(string inputStr)
{
    char[] charArray = inputStr.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

// function isPalindrome, returns bool and int
static (bool, int) IsPalindrome(string inputStr)
{
    inputStr = inputStr.ToLower();
    var sb = new StringBuilder();

    foreach (char c in inputStr)
    {
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
        {
            sb.Append(c);
        }
    }

    string formattedString = sb.ToString();
    string reversedString = ReverseString(formattedString);

    return formattedString == reversedString ? (true, formattedString.Length) : (false, 0);

}

string userInput = null;
while (userInput != "exit")
{
    System.Console.WriteLine("Enter text: ");
    userInput = Console.ReadLine();
    (bool check, int length) result = IsPalindrome(userInput);
    System.Console.WriteLine($"Is it a palindrome? {result.check}. Length: {result.length}");
}
