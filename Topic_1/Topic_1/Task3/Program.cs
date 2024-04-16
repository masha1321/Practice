namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер масти (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            switch (m)
            {
                case 1:
                    Console.WriteLine("Пики");
                    break;
                case 2:
                    Console.WriteLine("Трефы");
                    break;
                case 3:
                    Console.WriteLine("Бубны");
                    break;
                case 4:
                    Console.WriteLine("Червы");
                    break;
                default:
                    Console.WriteLine("Номер масти должен быть в диапазоне от 1 до 4.");
                    break;
            }
        }
    }
}