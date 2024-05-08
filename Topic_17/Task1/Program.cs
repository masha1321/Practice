public abstract class Shape
{
    public abstract double Perimeter();
    public abstract double Area();
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Perimeter()
    {
        return SideA + SideB + SideC;
    }

    public override double Area()
    {
        double s = Perimeter() / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public string Type()
    {
        if (SideA == SideB && SideB == SideC)
            return "Равносторонний";
        else if (SideA == SideB || SideB == SideC || SideC == SideA)
            return "Равнобедренный";
        else
            return "Разносторонний";
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }

    public override double Area()
    {
        return Length * Width;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("Треугольник:");
        Console.WriteLine("Периметр: " + triangle.Perimeter());
        Console.WriteLine("Площадь: " + triangle.Area());
        Console.WriteLine("Тип: " + triangle.Type());

        Rectangle rectangle = new Rectangle(4, 5);
        Console.WriteLine("\nПрямоугольник:");
        Console.WriteLine("Периметр: " + rectangle.Perimeter());
        Console.WriteLine("Площадь: " + rectangle.Area());
    }
}
