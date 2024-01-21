using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int year,age;

        Console.WriteLine("What is your name?");

        name = Console.ReadLine();

        Console.WriteLine( name + ", what is the year that you were born? ");
        year = int.Parse(Console.ReadLine());

        age = 2023 - year;

        Console.WriteLine(name + " you are " + age + " years old!!");
        
    }
}