using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(50m));

            Console.WriteLine(TempConverter.FahrenheitToCelsius(50m));
        }

    }
}
