using System;

class Program
{
    static void Main(string args)
    {
        double c,f;
        Console.WriteLine("Type the temperature in C: ");
        c = double.Parse(Console.ReadLine());

        //(0 °C × 9/5) + 32 = 32 °F
        f = (c * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + f);

    }
}