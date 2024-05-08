using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double a = 10; 
        double b = 20; 

        string path = "D:\\с рабочего стола\\Практика C#\\Practice\\Topic_18\\Task2\\numbers.txt"; 

        var numbers = File.ReadAllLines(path)
                          .SelectMany(line => line.Split(' '))
                          .Select(double.Parse)
                          .ToList();

        var inRange = new List<double>();
        var lessThanA = new List<double>();
        var greaterThanB = new List<double>();

        foreach (var number in numbers)
        {
            if (number >= a && number <= b)
            {
                inRange.Add(number);
            }
            else if (number < a)
            {
                lessThanA.Add(number);
            }
            else
            {
                greaterThanB.Add(number);
            }
        }

        Console.WriteLine("Числа из интервала [a, b]: " + string.Join(", ", inRange));
        Console.WriteLine("Числа меньше a: " + string.Join(", ", lessThanA));
        Console.WriteLine("Числа больше b: " + string.Join(", ", greaterThanB));
    }
}
