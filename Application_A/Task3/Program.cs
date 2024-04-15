namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = Math.Pow(x, 2) * Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2)) * Math.Exp(4 * Math.PI * x) / Math.Cos(2 * Math.PI / 3);
            Console.WriteLine("Значение функции равно: " + y);
        }
    }
}