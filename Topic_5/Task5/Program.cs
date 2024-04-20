namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = Calculate(n);
            Console.WriteLine($"Результат: {result}");
        }

        static double Calculate(int n)
        {
            if (n == 0 || n == 1)
                return 3; 
            else
            {
                double factorial = Factorial(n);
                return (factorial + 2) / factorial;
            }
        }

        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}