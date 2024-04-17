namespace Task1
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public double[] MedianIntersectionPoint()
        {
            double[] point = new double[2];
            point[0] = (A + B) / 3;
            point[1] = (A + C) / 3;
            return point;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Периметр: " + triangle.Perimeter());
            Console.WriteLine("Площадь: " + triangle.Area());
            double[] point = triangle.MedianIntersectionPoint();
            Console.WriteLine("Точки пересечения мередиан: (" + point[0] + ", " + point[1] + ")");
        }
    }
}