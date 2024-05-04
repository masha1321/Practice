using System;
using System.Threading;
using System.Threading.Tasks;
namespace Task3
{
    class Program
    {
        static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        static double A;
        static int N;

        static void Main()
        {
            Console.WriteLine("Введите значение A:");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            N = Convert.ToInt32(Console.ReadLine());

            Task task1 = Task.Run(() => Method1());
            Task task2 = Task.Run(() => Method2());

            Task.WaitAll(task1, task2);
        }

        static void Method1()
        {
            double result = 0;
            for (int i = 0; i <= N; i++)
            {
                result += Math.Pow(A, i);
            }
            Console.WriteLine($"Результат первого метода: {result}");
        }

        static void Method2()
        {
            semaphore.Wait();
            try
            {
                double result = 1;
                for (int i = 1; i <= N; i++)
                {
                    result *= Math.Pow(A, i);
                }
                Console.WriteLine($"Результат второго метода: {result}");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}