using System;

class Program
{
    static void Main(String[] args)
    {
        int number, result, count = 0;

        // Console.WriteLine("Type a number to know if it is prime or not: ");

        number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        if (count > 2)
        {
            Console.WriteLine("The number is not a prime number");
        }
        else
        {
            Console.WriteLine("The number is a prime number");
        }
    }
}