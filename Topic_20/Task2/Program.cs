using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double m = 1; 

        Task[] tasks = new Task[2];

        tasks[0] = Task.Run(() =>
        {
            Console.WriteLine("Задача 1 запущена");
            double z1 = Math.Sqrt(((3 * m + 2) * (3 * m + 2) - 24 * m) / (3 * Math.Sqrt(m) - Math.Sqrt(m)));
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine("Задача 1 завершена");
        });

        tasks[1] = Task.Run(() =>
        {
            Console.WriteLine("Задача 2 запущена");
            double z2 = -Math.Sqrt(m);
            Console.WriteLine($"z2 = {z2}");
            Console.WriteLine("Задача 2 завершена");
        });

        
        Task.WhenAll(tasks).Wait();

        // Для ожидания завершения хотя бы одной задачи вы можете использовать:
        // int taskIndex = Task.WaitAny(tasks);
    }
}
