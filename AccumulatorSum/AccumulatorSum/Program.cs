using System;

public class Program
{
    static void Main(String[] args)
    {
        //Sum of Natural Numbers: Calculate and print the sum
        //of the first 100 natural numbers using a while loop.
        int n;
        n = 0;
        int sum;
        sum = 0;

        while (n<=100)
        {
            sum = sum +n;
            n++;
        }
        Console.WriteLine(sum);
    }
}