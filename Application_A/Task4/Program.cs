namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус основания цилиндра: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту цилиндра: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(r, 2) * h;
            double surfaceArea = 2 * Math.PI * r * (r + h);

            Console.WriteLine($"Объем цилиндра: {volume}");
            Console.WriteLine($"Площадь поверхности цилиндра: {surfaceArea}");
        }
    }
}