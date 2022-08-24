using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        //public TempConverter()
        //{
        //}

        public static double FahrenheitToCelcius( double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
            
        }

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}

