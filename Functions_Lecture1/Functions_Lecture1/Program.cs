using System;

class Program
{
    static void positiveNegative(int n)
    {
        if (n > 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }

    static int inputNumber()
    {
        Console.WriteLine("Type a number: ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }

    static void Main(string[] args)
    {


        positiveNegative(inputNumber());
        positiveNegative(inputNumber());
        positiveNegative(inputNumber());
        positiveNegative(inputNumber());
        int a = inputNumber();
        Console.WriteLine(a);

    }
}