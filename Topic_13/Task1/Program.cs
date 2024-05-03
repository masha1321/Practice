namespace Task1
{
    class Program
    {
        
        delegate double TriangleDelegate(double side);

        static void Main()
        {
            try
            {
                double side = 5.0;

                TriangleDelegate triangleDelegate = Perimeter;
                Console.WriteLine($"Периметр равностороннего треугольника со стороной {side} равен {triangleDelegate(side)}");

                triangleDelegate = Area;
                Console.WriteLine($"Площадь равностороннего треугольника со стороной {side} равна {triangleDelegate(side)}");

                triangleDelegate = Side;
                Console.WriteLine($"Сторона равностороннего треугольника равна {triangleDelegate(side)}");
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
    }
}