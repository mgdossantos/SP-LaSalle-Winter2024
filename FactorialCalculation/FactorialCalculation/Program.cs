using System;

public class Program
{
    static void Main(String[] args)
    {
        int number, fact,mult;
        Console.Write("Enter a number to calculate its factorial: ");
        number=int.Parse(Console.ReadLine());
        fact = number;
        mult = number-1;
        do
        {

            fact = fact * mult;
            mult--;
        }
        while (mult>0);

        Console.WriteLine(number+"!: "+fact);

    }
}