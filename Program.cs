
using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelcius(68); 
            var fahrenheit = TempConverter.CelciusToFahrenheit(20);

            Console.WriteLine($"Celcius: {celsius}");
            Console.WriteLine($"Fahrenheit: {fahrenheit}");
        }
    }
}