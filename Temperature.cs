using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Temperature
    {
        public double degrees { get; set; }
        public TemperatureScale temperatureScale { get; }

        public Temperature(double degrees, TemperatureScale temperature)
        {
            this.degrees = degrees;
            this.temperatureScale = temperature;
        }

    }
    public enum TemperatureScale
    {
        Farenheit,
        Celsius,
        Kelvin

    }
    public class Fahrenheit : Temperature
    {
        public Fahrenheit(int input, TemperatureScale temperature) : base(input, temperature) { }

        public double ConvertToCelsius()
        {
            Console.WriteLine("Fahrenheit to Celsius conversion");
            int result = (5 * (this.degrees - 32) / 9);
            return result;
        }
        public double ConvertToKelvin()
        {

            Console.WriteLine("Fahrenheit to Celsius conversion");
            int result = (5 * (this.degrees - 32) / 9);
            return result;
        }
    }


    public class Kelvin : Temperature
    {
        public Kelvin(int input, TemperatureScale temperature) : base(input, temperature) { }
        public double ConvertToFarenheit()
        {
            Console.WriteLine("Kelvin to Farenheit conversion");
            int result = (this.degrees − 273.15)× 9)/5 + 32);
            return result;
        }
        public decimal ConvertToCelcius()
        {
            Console.WriteLine("Kelvin to Celsius conversion");
            decimal result = (this.degrees−273.15); 
            return result;
        }
    }

    public class Celsius : Temperature
    {
        public Celsius(int input, TemperatureScale temperature) : base(input, temperature) { }

        public double ConvertToFarenheit()
        {
            Console.WriteLine("Celcius to Fahrenheit conversion");
            int result = ((this.degrees * 9) / 5) + 32;
            return result;
        }
        public double ConvertToKelvin()
        {
            Console.WriteLine("Celcius to Fahrenheit conversion");
            int result = ((this.degrees * 9) / 5) + 32;
            return result;
        }
    }

}
