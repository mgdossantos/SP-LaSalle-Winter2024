using System;

    class Program
{
    static void Main (string[] args)
    {
        string name;
        int year,age;

        Console.WriteLine("Type your name: ");
        name = Console.ReadLine();

        Console.WriteLine(name + ", what is the year that you were born:");
        year = int.Parse(Console.ReadLine());

        age = 2024 - year;

        Console.WriteLine (age);
    }
}