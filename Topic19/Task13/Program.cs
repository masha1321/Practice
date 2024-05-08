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
        // Чтение строк из файла
        var lines = File.ReadAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\1.txt");

        // Запись в файл 2.txt строк с нечетными индексами
        File.WriteAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\2.txt", lines.Where((line, index) => index % 2 != 0));

        // Запись в файл 3.txt строк с четными индексами
        File.WriteAllLines("D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task4\\files\\3.txt", lines.Where((line, index) => index % 2 == 0));
    }
}
