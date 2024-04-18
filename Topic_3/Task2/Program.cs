namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше или равно b.");
                return;
            }

            Console.Write("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            if (h <= 0)
            {
                Console.WriteLine("Ошибка: h должно быть больше нуля.");
                return;
            }

            for (double x = a; x <= b; x += h)
            {
                double y;

                if (x < -1)
                {
                    y = a * x - b;
                }
                else if (x >= -1 && x <= 1)
                {
                    y = Math.Pow(x, 2) * a;
                }
                else
                {
                    if (b * x <= 0)
                    {
                        Console.WriteLine("Ошибка: невозможно вычислить логарифм от неположительного числа.");
                        return;
                    }

                    y = Math.Pow(x, 2) + a * x + Math.Log(b * x);
                }

                Console.WriteLine($"x = {x}, y = {y}");
            }
        }
    }
}