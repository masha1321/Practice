using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "D:\\с рабочего стола\\Практика C#\\Practice\\Topic_16\\Task1\\files\\f.txt"; 
        var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

        double sum = numbers.Sum();
        double difference = numbers.First() - numbers.Last();

        Console.WriteLine("Сумма чисел: " + sum);
        Console.WriteLine("Разность первого и последнего числа: " + difference);
    }
}
