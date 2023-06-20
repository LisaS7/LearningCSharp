namespace CSharpFundamentals
{
    public class StringUtility
    {
        public static string SummariseText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;


            string[] words = text.Split(' ');
            int totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return string.Join(" ", summaryWords) + "...";

        }
    }
}