using System;

class Program
{
    static char positiveNegative(int n)
    {
        if (n > 0)
        {
            return 'P';
        }
        else
        {
           return 'N';
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

        int a = inputNumber();
        Console.WriteLine(a);
        positiveNegative(a);
       
       

    }
}