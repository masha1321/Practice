namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину стороны b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину стороны c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (IsRightTriangle(a, b, c))
                Console.WriteLine("Треугольник является прямоугольным.");
            else
                Console.WriteLine("Треугольник не является прямоугольным.");
        }

        static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}