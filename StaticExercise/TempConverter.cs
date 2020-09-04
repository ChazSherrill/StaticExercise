using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static decimal FahrenheitToCelsius(decimal fahren)
        {
            return Decimal.Divide(((fahren - 32) * 5) , 9);
        }

        public static decimal CelsiusToFahrenheit(decimal cels)
        { 
            return (cels * Decimal.Divide(9 , 5)) + 30;
        }
    }
}
