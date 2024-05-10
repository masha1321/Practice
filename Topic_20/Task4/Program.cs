using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double A = 0; 
        double B = 10; 
        int N = 1000; 

        double dx = (B - A) / (N - 1); 

        double[] results = new double[N]; 

        Parallel.For(0, N, i =>
        {
            double x = A + dx * i;
            results[i] = x * Math.Sin(x);
        });

        
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"f({A + dx * i}) = {results[i]}");
        }
    }
}
