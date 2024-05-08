using Task2;

namespace Task2
{
    public class Weather
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public string Condition { get; set; }

        public Weather(string city, double temperature, double humidity, string condition)
        {
            City = city;
            Temperature = temperature;
            Humidity = humidity;
            Condition = condition;
        }

        public override string ToString()
        {
            return $"Погода в городе {City}: Температура {Temperature}°C, Влажность {Humidity}%, Состояние: {Condition}";
        }
    }

    public class WeatherLibrary
    {
        private List<Weather> weatherData = new List<Weather>();

        public void AddWeatherData(Weather weather)
        {
            weatherData.Add(weather);
        }

        public void DisplayWeatherData()
        {
            foreach (var weather in weatherData)
            {
                Console.WriteLine(weather.ToString());
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        WeatherLibrary weatherLibrary = new WeatherLibrary();

        weatherLibrary.AddWeatherData(new Weather("Минск", 20.5, 65, "Ясно"));
        weatherLibrary.AddWeatherData(new Weather("Гродно", 18.3, 70, "Облачно"));

        weatherLibrary.DisplayWeatherData();

        Console.ReadKey();
    }
}
