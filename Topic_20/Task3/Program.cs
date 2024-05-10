using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = 123; 

        Task<int> task1 = Task.Run(() =>
        {
            Console.WriteLine("Задача 1 запущена");
            int product = 1;
            while (number != 0)
            {
                product *= number % 10;
                number /= 10;
            }
            Console.WriteLine("Задача 1 завершена");
            return product;
        });

        Task task2 = task1.ContinueWith((t) =>
        {
            Console.WriteLine("Задача 2 запущена");
            Console.WriteLine($"Произведение цифр числа: {t.Result}");
            Console.WriteLine("Задача 2 завершена");
        });

        Task.WhenAll(task1, task2).Wait();
    }
}
