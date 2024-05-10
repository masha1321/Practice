using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] array = { 65, 2, 6, 87 }; 
        int sumLimit = 100; 
        int productLimit = 1000; 

        Parallel.ForEach(array, (n, state) =>
        {
            int sum = 0;
            int product = 1;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
                product *= i > 0 ? i : 1;

                
                if (sum > sumLimit || product > productLimit)
                {
                    Console.WriteLine($"Прерывание выполнения для N = {n}. Сумма = {sum}, Произведение = {product}");
                    state.Break();
                    return;
                }
            }

            Console.WriteLine($"N = {n}. Сумма = {sum}, Произведение = {product}");
        });
    }
}
