using System;
using System.Collections.Generic;


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { -1, 2, -3, 4, -5, 6 }; 

            if (IsAlternating(sequence))
            {
                Console.WriteLine("Исходная последовательность чередует положительные и отрицательные числа.");
                PrintSequence(sequence);
            }
            else
            {
                Console.WriteLine("Исходная последовательность не чередует положительные и отрицательные числа. Выводим все отрицательные числа:");
                PrintSequence(GetNegativeNumbers(sequence));
            }
        }

        static bool IsAlternating(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] * sequence[i + 1] > 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] GetNegativeNumbers(int[] sequence)
        {
            List<int> negativeNumbers = new List<int>();
            foreach (int number in sequence)
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
            }
            return negativeNumbers.ToArray();
        }

        static void PrintSequence(int[] sequence)
        {
            foreach (int number in sequence)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}