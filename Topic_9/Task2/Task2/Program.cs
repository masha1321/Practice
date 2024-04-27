using System;
using System.Collections.Generic;

public class Plane : IComparable<Plane>
{
    private string destination;
    private string flightNumber;
    private DateTime departureTime;

    public Plane(string destination, string flightNumber, DateTime departureTime)
    {
        this.destination = destination;
        this.flightNumber = flightNumber;
        this.departureTime = departureTime;
    }

    public string Destination { get { return destination; } }
    public string FlightNumber { get { return flightNumber; } }
    public DateTime DepartureTime { get { return departureTime; } }

    public int CompareTo(Plane other)
    {
        return flightNumber.CompareTo(other.flightNumber);
    }
}

public class Airport
{
    private List<Plane> planes;

    public Airport()
    {
        planes = new List<Plane>();
    }

    public void AddPlane(Plane plane)
    {
        planes.Add(plane);
        planes.Sort();
    }

    public Plane this[string flightNumber]
    {
        get
        {
            return planes.Find(plane => plane.FlightNumber == flightNumber);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Airport airport = new Airport();

        airport.AddPlane(new Plane("Москва", "123456", DateTime.Now));
        airport.AddPlane(new Plane("Санкт-Петербург", "654321", DateTime.Now));

        Plane plane = airport["123456"];
        if (plane != null)
        {
            Console.WriteLine($"Номер рейса: {plane.FlightNumber}, Пункт назначения: {plane.Destination}, Время отправления: {plane.DepartureTime}");
        }
        else
        {
            Console.WriteLine("Самолет с таким номером рейса не найден.");
        }
    }
}
