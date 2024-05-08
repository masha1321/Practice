namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        static void Main(string[] args)
        {
            int a1 = ReadInteger("Введите a1: ");
            int b1 = ReadInteger("Введите b1: ");
            int a2 = ReadInteger("Введите a2: ");
            int b2 = ReadInteger("Введите b2: ");
            int c2 = ReadInteger("Введите c2: ");

            int result = Mult(a1, b1) - Mult(a2, b2, c2);
            Console.WriteLine($"Результат: {result}");
        }

        /// <summary>
        /// Метод для умножения двух чисел.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        static int Mult(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Метод для умножения трех чисел.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <param name="c">Третий множитель.</param>
        static int Mult(int a, int b, int c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Метод для чтения целого числа из консоли.
        /// </summary>
        /// <param name="prompt">Подсказка для пользователя.</param>
        static int ReadInteger(string prompt)
        {
            int number;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Это не целое число. Попробуйте еще раз: ");
            }
            return number;
        }
    }
}
