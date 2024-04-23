using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В глубине леса, где деревья тянутся к небу, живет маленький заяц. Заяц любит прыгать по лесу, искать вкусные листья и играть с друзьями. Однажды заяц нашел большую морковку. \"Какая вкусная морковка!\" - подумал заяц. Заяц решил поделиться морковкой с друзьями. И так заяц, держа вкусную морковку, прыгал по лесу, ища своих друзей."; 
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (Match match in Regex.Matches(text, @"\b\w+\b"))
            {
                string word = match.Value;

                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach (KeyValuePair<string, int> pair in wordCount)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("Слово '{0}' повторяется {1} раз(а)", pair.Key, pair.Value);
                }
            }
        }
    }
}