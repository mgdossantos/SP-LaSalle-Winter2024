using System;

class Program
{
    static void Main(String[] args)
    {
        //Countdown: Write a program that uses a
        //while loop to count down from 10 to 1
        //and then prints "Blastoff!".
        int n;
        n = 10;

        while (n>0)
        {
            Console.WriteLine(n);
            n--;
        }
        Console.WriteLine("Blastoff");
        

    }
}