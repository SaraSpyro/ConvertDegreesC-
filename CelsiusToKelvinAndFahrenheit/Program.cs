using System;

namespace CelsiusToKelvinAndFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Enter the amount of celsius: ");
                byte celsius = Convert.ToByte(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($" Kelvin = { celsius + 273}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Fahrenheit = {celsius * 18 / 10 + 32}");
                Console.ReadKey();
            }

        }
    }
}
