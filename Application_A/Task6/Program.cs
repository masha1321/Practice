namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            int product = firstDigit * secondDigit * thirdDigit;

            Console.WriteLine("Произведение цифр числа: " + product);
        }
    }
}