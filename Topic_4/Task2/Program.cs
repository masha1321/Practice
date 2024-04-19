using System;
namespace Task2
{
    class Program
    {
        static double CalculateFunction(double x)
        {
            if (x <= -4)
            {
               
                if (Math.Abs(2 * x + 1) < double.Epsilon)
                {
                    throw new DivideByZeroException("Division by zero");
                }
                return x / (2 * x + 1);
            }
            else if (x > -1)
            {
                return x + 3;
            }
            else
            {
                return x; 
            }
        }

        static void Main()
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());

                double result = CalculateFunction(x);
                Console.WriteLine($"Значение функции f({x}) = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата ввода. Введите вещественное число.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}