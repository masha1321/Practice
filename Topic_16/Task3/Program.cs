using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
       
        string[] lines = { "Первая строка", "Вторая строка", "Третья строка", "Четвертая строка", "Пятая строка" };
        File.WriteAllLines("input.txt", lines);

        Console.WriteLine(File.ReadAllText("input.txt"));

        Console.WriteLine($"Количество строк: {lines.Length}");

        foreach (var line in lines)
        {
            Console.WriteLine($"Количество символов в строке '{line}': {line.Length}");
        }

        File.WriteAllLines("output.txt", lines.Take(lines.Length - 1));

        int s1 = 1, s2 = 3;
        Console.WriteLine(string.Join("\n", lines.Skip(s1 - 1).Take(s2 - s1 + 1)));

        var longestLine = lines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"Самая длинная строка: '{longestLine}', длина: {longestLine.Length}");

        char startChar = 'В';
        foreach (var line in lines.Where(line => line.StartsWith(startChar)))
        {
            Console.WriteLine(line);
        }

        File.WriteAllLines("reversed.txt", lines.Reverse());
    }
}
