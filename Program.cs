using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperature = new Temperature(5.25, TemperatureScale.Celsius);
            Console.WriteLine(temperature.degrees + "," + temperature.temperatureScale);
            Console.Read();
        }
    }
}
