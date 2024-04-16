namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x >= 0.1 && x <= 1.5)
            {
                y = Math.Log(Math.Pow(Math.E, x + 4)) - 2 * x;
            }
            else if (x > 1.5)
            {
                y = Math.Pow(x, 2) - 1;
            }
            else
            {
                Console.WriteLine("Значение x вне определенного диапазона.");
                return;
            }

            Console.WriteLine($"Значение y для данного x равно: {y}");
        }
    }
}