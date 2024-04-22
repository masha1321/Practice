namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Маша ела кашку";
            string[] words = text.Split(' ');
            string longestWord = words.OrderByDescending(s => s.Length).First();
            Console.WriteLine("Слово максимальной длины: " + longestWord);
            Console.WriteLine("Количество символов в слове: " + longestWord.Length);
        }
    }
}