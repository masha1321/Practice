using System.Text.RegularExpressions;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ваш США, ООН, НАТО и т.д.";
            string pattern = @"\b[A-ZА-ЯЁ]{2,}\b";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}