namespace Task1
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод для обмена значений двух переменных, если первая больше второй.
        /// </summary>
        /// <param name="X">Первое число.</param>
        /// <param name="Y">Второе число.</param>
        static void Minmax(ref double X, ref double Y)
        {
            if (X > Y)
            {
                double temp = X;
                X = Y;
                Y = temp;
            }
        }
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        static void Main()
        {
            double A = 10, B = 20, C = 30, D = 40;
            Minmax(ref A, ref B);
            Minmax(ref A, ref C);
            Minmax(ref A, ref D);
            Minmax(ref B, ref C);
            Minmax(ref B, ref D);
            Minmax(ref C, ref D);

            Console.WriteLine("Минимальное число: " + A);
            Console.WriteLine("Максимальное число: " + D);
        }
    }
}
