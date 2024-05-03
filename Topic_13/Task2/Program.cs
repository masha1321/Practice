namespace Task2
{
    class Program
    {
        delegate double TriangleDelegate(double side);

        static void Main()
        {
            try
            {
                double side = 5.0;

                CallDelegate(Perimeter, side);
                CallDelegate(Area, side);
                CallDelegate(Side, side);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static double Perimeter(double side)
        {
            return 3 * side;
        }

        static double Area(double side)
        {
            return Math.Sqrt(3) / 4 * Math.Pow(side, 2);
        }

        static double Side(double side)
        {
            return side;
        }

        static void CallDelegate(TriangleDelegate triangleDelegate, double side)
        {
            double result = triangleDelegate(side);
            Console.WriteLine($"Результат: {result}");
        }
    }
}