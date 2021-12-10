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
        public Fahrenheit(double input, TemperatureScale temperature) : base(input, temperature) { }

        public double ConvertToCelsius()
        {
            Console.WriteLine("Fahrenheit to Celsius conversion");
            double result = (5 * (this.degrees - 32) / 9);
            return result;
        }
        public double ConvertToKelvin()
        {

            Console.WriteLine("Fahrenheit to Kelvin conversion");
            double result = (5 * (this.degrees * 32) - 32) / 9 + 273.15;
            return result;
        }
    }


    public class Kelvin : Temperature
    {
        public Kelvin(double input, TemperatureScale temperature) : base(input, temperature) { }
        public double ConvertToFarenheit()
        {
            Console.WriteLine("Kelvin to Farenheit conversion");
            double result = (1.8 * (this.degrees - 273) + 32);
            return result;
        }
        public double ConvertToCelcius()
        {
            Console.WriteLine("Kelvin to Celsius conversion");
            double result = this.degrees - 273;
            return result;
        }
    }

    public class Celsius : Temperature
    {
        public Celsius(double input, TemperatureScale temperature) : base(input, temperature) { }

        public double ConvertToFarenheit()
        {
            Console.WriteLine("Celcius to Fahrenheit conversion");
            double result =((this.degrees * 9) / 5)+32;
            return result;
        }
        public double ConvertToKelvin()
        {
            Console.WriteLine("Celcius to Kelvin conversion");
            double result = this.degrees + 273;
            return result;
        }
    }

}
