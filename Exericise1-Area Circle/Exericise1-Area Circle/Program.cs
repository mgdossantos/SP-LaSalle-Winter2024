using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        double area;
        Console.WriteLine("Enter the radius for the circle: ");
        double radius = double.Parse(Console.ReadLine());
        area= Math.PI * Math.Pow(radius,2);
        Console.WriteLine(area);

    }
}