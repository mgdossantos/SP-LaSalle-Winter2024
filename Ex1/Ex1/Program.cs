using System;

class Program
{
    static void Main(string[] args)
    {
        double[] temperature = new double[12];
        string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        double sum = 0;
        double average;

        for(int i = 0; i < temperature.Length; i++)
        {
            Console.WriteLine("Input tempature for :" + month[i]);
            temperature[i] = double.Parse(Console.ReadLine());
            sum = sum + temperature[i];

        }
        average = sum/ temperature.Length;
        Console.WriteLine("The average temperature of the year is " + average);
        for(int i = 0; i < temperature.Length;i++)
        {
            if (temperature[i] > average)
            {
                Console.WriteLine(month[i] + "is hotter than the average" + temperature[i]);
            }
        }

    }
}
