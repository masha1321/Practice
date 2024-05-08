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
        // Массив строк
        string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };

        // Запись строк в файл
        File.WriteAllLines("input.txt", lines);

        // Вывод содержимого файла
        Console.WriteLine(File.ReadAllText("input.txt"));

        // Вывод количества строк
        Console.WriteLine($"Количество строк: {lines.Length}");

        // Вывод количества символов в каждой строке
        foreach (var line in lines)
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }

        // Запись в файл всех строк, кроме последней
        File.WriteAllLines("output.txt", lines.Take(lines.Length - 1));

        // Вывод строк с s1 по s2
        int s1 = 1, s2 = 3;
        Console.WriteLine(string.Join("\n", lines.Skip(s1 - 1).Take(s2 - s1 + 1)));

        // Вывод самой длинной строки
        var longestLine = lines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"Самая длинная строка: '{longestLine}', длина: {longestLine.Length}");

        // Вывод строк, начинающихся с определенного символа
        char startChar = 'В';
        foreach (var line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        // Запись в файл строк в обратном порядке
        File.WriteAllLines("reversed.txt", lines.Reverse());
    }
}
