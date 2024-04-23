using System;
using System.Text.RegularExpressions;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Информатика - это наука, изучающая методы обработки, хранения и передачи информации с помощью компьютеров. Она играет важную роль в современном мире, поскольку практически все аспекты нашей жизни теперь связаны с использованием цифровых технологий."; 
            string pattern = @"(?<=^|\.\s)Информатика\b";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("Количество предложений, начинающихся со слова 'Информатика': {0}", matches.Count);
        }
    }
}