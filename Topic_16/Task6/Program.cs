using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();
           
        string result = new string(sentence.Where(c => !Char.IsDigit(c)).ToArray());
            
        File.WriteAllText("output.txt", result);

        string fileContent = File.ReadAllText("output.txt");
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(fileContent);
    }
}
