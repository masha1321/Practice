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
        // Массивы чисел
        int[] f1 = { 1, 2, 3, 4, 5 };
        int[] f2 = { 5, 4, 3, 2, 1 };

        // Запись массивов в файлы
        File.WriteAllLines("f1.dat", f1.Select(x => x.ToString()));
        File.WriteAllLines("f2.dat", f2.Select(x => x.ToString()));

        // Чтение чисел из файлов
        int[] file1 = File.ReadAllLines("f1.dat").Select(int.Parse).ToArray();
        int[] file2 = File.ReadAllLines("f2.dat").Select(int.Parse).ToArray();

        // Нахождение числа, ближайшего к минимальному во втором файле
        int minInFile2 = file2.Min();
        int closest = file2.OrderBy(item => Math.Abs(minInFile2 - item)).First();
        Console.WriteLine($"Ближайшее к минимальному в f2.dat: {closest}");

        // Сравнение количества положительных, отрицательных и нулевых чисел в файлах
        CompareCounts(file1, file2);

        // Проверка, упорядочены ли числа в первом файле по возрастанию
        bool isOrdered = file1.SequenceEqual(file1.OrderBy(x => x));
        Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isOrdered}");

        // Проверка, образуют ли числа в первом файле знакопеременную последовательность
        bool isAlternating = IsAlternating(file1);
        Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isAlternating}");
    }

    /// <summary>
    /// Метод для сравнения количества положительных, отрицательных и нулевых чисел в двух массивах.
    /// </summary>
    static void CompareCounts(int[] file1, int[] file2)
    {
        int pos1 = file1.Count(x => x > 0);
        int pos2 = file2.Count(x => x > 0);
        Console.WriteLine($"Больше положительных чисел в файле: {(pos1 > pos2 ? "f1.dat" : "f2.dat")}");

        int neg1 = file1.Count(x => x < 0);
        int neg2 = file2.Count(x => x < 0);
        Console.WriteLine($"Больше отрицательных чисел в файле: {(neg1 > neg2 ? "f1.dat" : "f2.dat")}");

        int zero1 = file1.Count(x => x == 0);
        int zero2 = file2.Count(x => x == 0);
        Console.WriteLine($"Больше нулевых чисел в файле: {(zero1 > zero2 ? "f1.dat" : "f2.dat")}");
    }

    /// <summary>
    /// Метод для проверки, образует ли массив знакопеременную последовательность.
    /// </summary>
    static bool IsAlternating(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] * arr[i + 1] >= 0)
                return false;
        }
        return true;
    }
}
