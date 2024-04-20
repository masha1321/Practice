using System;
using System.Linq;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0 };
            int index = Array.IndexOf(array, array.Max());

            Console.WriteLine("Порядковый номер максимального элемента: " + (index + 1));
        }
    }
}