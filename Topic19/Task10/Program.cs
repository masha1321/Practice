using System;
using System.IO;
using System.Linq;

class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        // Путь к файлу
        string filePath = "D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task1\\files\\f.txt";

        // Чтение чисел из файла и преобразование их в список
        var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

        // Вычисление суммы чисел
        double sum = numbers.Sum();

        // Вычисление разности первого и последнего числа
        double difference = numbers.First() - numbers.Last();

        // Вывод результатов
        Console.WriteLine("Сумма чисел: " + sum);
        Console.WriteLine("Разность первого и последнего числа: " + difference);
    }
}
