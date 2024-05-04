using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        
        int[] sequence = Enumerable.Range(0, 100).ToArray();

        int numThreads = Environment.ProcessorCount;

        int chunkSize = sequence.Length / numThreads;
        int[] sums = new int[numThreads];

        Task[] tasks = new Task[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            int threadIndex = i;
            tasks[i] = Task.Run(() =>
            {
                int start = threadIndex * chunkSize;
                int end = (threadIndex == numThreads - 1) ? sequence.Length : start + chunkSize;
                for (int j = start; j < end; j++)
                {
                    if (sequence[j] % 2 == 0)
                    {
                        sums[threadIndex] += sequence[j];
                    }
                }
            });
        }

        Task.WaitAll(tasks);

        int totalSum = sums.Sum();

        Console.WriteLine("Сумма четных чисел в последовательности равна " + totalSum);
    }
}
