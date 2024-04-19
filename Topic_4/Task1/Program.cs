namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 9;
            double y;
            try
            {
                if (Math.Sin(x) == 0)
                    throw new DivideByZeroException();
                y = 2 * x / Math.Sin(x) - 4 * x;
                Console.WriteLine(y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат");
            }
        }
    }
}