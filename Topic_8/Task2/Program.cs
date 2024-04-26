using System;
using System.Linq;
namespace Task2
{
    public struct MARSH
    {
        public string StartPoint;
        public string EndPoint;
        public int RouteNumber;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MARSH[] marshes = new MARSH[8];

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите название начального пункта маршрута:");
                string startPoint = Console.ReadLine();

                Console.WriteLine("Введите название конечного пункта маршрута:");
                string endPoint = Console.ReadLine();

                Console.WriteLine("Введите номер маршрута:");
                int routeNumber;
                while (!int.TryParse(Console.ReadLine(), out routeNumber))
                {
                    Console.WriteLine("Пожалуйста, введите действительный номер маршрута:");
                }

                marshes[i] = new MARSH { StartPoint = startPoint, EndPoint = endPoint, RouteNumber = routeNumber };
            }

            marshes = marshes.OrderBy(m => m.RouteNumber).ToArray();

            Console.WriteLine("Введите номер маршрута для поиска:");
            int searchRouteNumber;
            while (!int.TryParse(Console.ReadLine(), out searchRouteNumber))
            {
                Console.WriteLine("Пожалуйста, введите действительный номер маршрута:");
            }

            var foundMarsh = marshes.FirstOrDefault(m => m.RouteNumber == searchRouteNumber);
            if (foundMarsh.Equals(default(MARSH)))
            {
                Console.WriteLine("Маршрут с таким номером не найден.");
            }
            else
            {
                Console.WriteLine($"Начальный пункт: {foundMarsh.StartPoint}\nКонечный пункт: {foundMarsh.EndPoint}\nНомер маршрута: {foundMarsh.RouteNumber}");
            }
        }
    }
}