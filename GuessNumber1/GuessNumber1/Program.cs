using System;

class Program
{
    static void Main(String[] args)
    {
        int secretNumber = 39;
        int userNumber=0;
        
        while (userNumber!= secretNumber)
        {
            Console.WriteLine("Type a number: ");
            userNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You won!!");
        
    }
}