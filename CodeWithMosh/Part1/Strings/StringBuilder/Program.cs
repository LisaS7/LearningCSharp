using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new StringBuilder("0000000");
        builder.Append('-', 10)
        .AppendLine()
        .Append("Header")
        .AppendLine()
        .Append('-', 10)

        .Replace('-', '=')
        .Remove(0, 5)
        .Insert(0, new string('-', 5));
        Console.WriteLine(builder);
    }
}