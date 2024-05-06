using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        
        int[] f1 = { 1, 2, 3, 4, 5 };
        int[] f2 = { 5, 4, 3, 2, 1 };
        File.WriteAllLines("f1.dat", f1.Select(x => x.ToString()));
        File.WriteAllLines("f2.dat", f2.Select(x => x.ToString()));

        int[] file1 = File.ReadAllLines("f1.dat").Select(int.Parse).ToArray();
        int[] file2 = File.ReadAllLines("f2.dat").Select(int.Parse).ToArray();

        int minInFile2 = file2.Min();
        int closest = file2.OrderBy(item => Math.Abs(minInFile2 - item)).First();
        Console.WriteLine($"Ближайшее к минимальному в f2.dat: {closest}");

        CompareCounts(file1, file2);

        bool isOrdered = file1.SequenceEqual(file1.OrderBy(x => x));
        Console.WriteLine($"Числа в f1.dat упорядочены по возрастанию: {isOrdered}");

       
        bool isAlternating = IsAlternating(file1);
        Console.WriteLine($"Числа в f1.dat образуют знакопеременную последовательность: {isAlternating}");
    }

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
