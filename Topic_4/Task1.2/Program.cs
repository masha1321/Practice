namespace Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
double y;
            try
            {
                if (Math.Tan(x - 1) == 0)
                    throw new DivideByZeroException();
                y = 1 / Math.Pow(Math.Tan(x - 1), 2);
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