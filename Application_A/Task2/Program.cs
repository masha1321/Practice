namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Введено некорректное число. Пожалуйста, введите четырехзначное число.");
                return;
            }

            int digit1 = number % 10;
            int digit2 = (number / 10) % 10;
            int digit3 = (number / 100) % 10;
            int digit4 = (number / 1000) % 10;

            
            int reversedNumber = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {reversedNumber}");
        }
    }
}