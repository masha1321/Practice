namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену 1 кг конфет: ");
            double price = Convert.ToDouble(Console.ReadLine());

            for (double weight = 0.1; weight <= 1; weight += 0.1)
            {
                Console.WriteLine("Стоимость {0} кг конфет: {1}", weight, weight * price);
            }
        }
    }
}