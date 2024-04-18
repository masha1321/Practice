namespace Task4
{
    internal class Program
    {
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

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static int Mult(int a, int b, int c)
        {
            return a * b * c;
        }

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