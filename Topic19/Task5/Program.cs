using System;
using System.Collections.Generic;

namespace Task5
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
            ParkingLot parkingLot = new ParkingLot();

            Car car1 = new Car("123ABC", "Красный", "МП", true);
            Car car2 = new Car("456DEF", "Синий", "МП", false);
            parkingLot.AddCar(car1);
            parkingLot.AddCar(car2);

            Car foundCar = parkingLot.FindCar("123ABC");
            if (foundCar != null)
            {
                Console.WriteLine($"Поиск авто с номером: {foundCar.Number}");
            }

            List<Car> presentCars = parkingLot.GetPresentCars();
            Console.WriteLine($"Список присутствующих авто: {presentCars.Count}");

            List<Car> absentCars = parkingLot.GetAbsentCars();
            Console.WriteLine($"Список отстствующих авто: {absentCars.Count}");
        }
    }

    /// <summary>
    /// Класс, представляющий автомобиль.
    /// </summary>
    public class Car
    {
        public string Number { get; set; }
        public string Color { get; set; }
        public string Owner { get; set; }
        public bool IsPresent { get; set; }

        /// <summary>
        /// Конструктор класса Car.
        /// </summary>
        public Car(string number, string color, string owner, bool isPresent)
        {
            Number = number;
            Color = color;
            Owner = owner;
            IsPresent = isPresent;
        }
    }

    /// <summary>
    /// Класс, представляющий парковку.
    /// </summary>
    public class ParkingLot
    {
        private List<Car> Cars { get; set; }

        /// <summary>
        /// Конструктор класса ParkingLot.
        /// </summary>
        public ParkingLot()
        {
            Cars = new List<Car>();
        }

        /// <summary>
        /// Метод для добавления автомобиля на парковку.
        /// </summary>
        public void AddCar(Car car)
        {
            if (car != null)
            {
                Cars.Add(car);
            }
        }

        /// <summary>
        /// Метод для поиска автомобиля по номеру.
        /// </summary>
        public Car FindCar(string number)
        {
            return Cars.FirstOrDefault(car => car.Number == number);
        }

        /// <summary>
        /// Метод для получения списка присутствующих автомобилей.
        /// </summary>
        public List<Car> GetPresentCars()
        {
            return Cars.Where(car => car.IsPresent).ToList();
        }

        /// <summary>
        /// Метод для получения списка отсутствующих автомобилей.
        /// </summary>
        public List<Car> GetAbsentCars()
        {
            return Cars.Where(car => !car.IsPresent).ToList();
        }
    }
}
