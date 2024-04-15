using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.FahrenheitToCelsius(55); // 
            double roundedAnswer1 = Math.Round(celsius);
            Console.WriteLine(roundedAnswer1);

            double fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68
            double roundedAnswer2 = Math.Round(fahrenheit);
            Console.WriteLine(roundedAnswer2);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
