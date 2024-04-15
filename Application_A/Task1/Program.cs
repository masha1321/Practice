namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первое вещественное число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе вещественное число: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = num2 / num1;


            Console.WriteLine($"Результат деления: {result:F2}");
        }
    }
}