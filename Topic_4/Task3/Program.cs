using System;
namespace Task3
{
    public class MyCustomException : Exception
    {
        public MyCustomException() { }
        public MyCustomException(string message) : base(message) { }
        public MyCustomException(string message, Exception inner) : base(message, inner) { }
        protected MyCustomException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                double A = 1.0, B = 2.0, C = 3.0, D = 4.0;

                int result = Divide(10, 0);
                Console.WriteLine($"Результат деления: {result}");

                Swap(ref A, ref B);
                Swap(ref C, ref D);
                Swap(ref B, ref C);

                Console.WriteLine($"Новые значения: A={A}, B={B}, C={C}, D={D}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Поймано пользовательское исключение: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Поймано другое исключение: {ex.Message}");
            }
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new MyCustomException("Деление на ноль недопустимо");
            }
            return a / b;
        }

        static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}