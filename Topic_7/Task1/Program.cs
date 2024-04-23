using System.Text.RegularExpressions;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Очень красивые поля и виды, горы и массивы 12 34 217";

            var words = Regex.Matches(text, @"\b\w+\b");

            Console.WriteLine("Слова с четным количеством букв:");
            foreach (Match word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine(word.Value);
                }
            }

            Console.WriteLine("\nСлова с нечетным количеством цифр:");
            foreach (Match word in words)
            {
                var digitCount = Regex.Matches(word.Value, @"\d").Count;
                if (digitCount % 2 != 0)
                {
                    Console.WriteLine(word.Value);
                }
            }
        }
    }
}