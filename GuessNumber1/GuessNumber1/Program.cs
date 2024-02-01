using System;

class Program
{
    static void Main(String[] args)
    {
        int secretNumber;
        int userNumber=0;

        Random rnd = new Random();
        secretNumber = rnd.Next(1,1001);
        while (userNumber!= secretNumber)
        {
            Console.WriteLine("Type a number: ");
            userNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You won!!");
        
    }
}