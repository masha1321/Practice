using System;
using System.Collections.Generic;
namespace Task5
{
    internal class Program
    {
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

   
}
public class Car
{
    public string Number { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }
    public bool IsPresent { get; set; }

    public Car(string number, string color, string owner, bool isPresent)
    {
        Number = number;
        Color = color;
        Owner = owner;
        IsPresent = isPresent;
    }
}

public class ParkingLot
{
    private List<Car> Cars { get; set; }

    public ParkingLot()
    {
        Cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        if (car != null)
        {
            Cars.Add(car);
        }
    }

    public Car FindCar(string number)
    {
        return Cars.FirstOrDefault(car => car.Number == number);
    }

    public List<Car> GetPresentCars()
    {
        return Cars.Where(car => car.IsPresent).ToList();
    }

    public List<Car> GetAbsentCars()
    {
        return Cars.Where(car => !car.IsPresent).ToList();
    }
}
