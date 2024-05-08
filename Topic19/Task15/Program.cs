using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        // Запрос предложения от пользователя
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        // Удаление всех цифр из предложения
        string result = new string(sentence.Where(c => !Char.IsDigit(c)).ToArray());

        // Запись результата в файл
        File.WriteAllText("output.txt", result);

        // Чтение содержимого файла
        string fileContent = File.ReadAllText("output.txt");

        // Вывод содержимого файла
        Console.WriteLine("Содержимое файла:");
        Console.WriteLine(fileContent);
    }
}
