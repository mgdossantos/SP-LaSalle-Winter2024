using System;


class Program
{
    static void Main(String[] args)
    {
        int secretNumber;
        int userNumber = 0;
        Random rnd = new Random();
        secretNumber = rnd.Next(1,101);
        
        Console.WriteLine("Welcome to the Number Guessing Game!\r\n");
        Console.WriteLine("I've selected a random number between 1 and 1000. Try to guess it!\r\n");
        
        //secretNumber = 39;
        
        int tries;
        tries = 1;
        
        while ((userNumber != secretNumber) && (tries<6))
        {
            Console.WriteLine("Type a number (Attemp" +tries+"): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }

            if (userNumber< secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }

            tries++;

        }

        if (userNumber == secretNumber)
        {
            tries--;
            Console.WriteLine("You won!!.You've guessed the number in "+tries+" attempts!");
        }
        else
        {
            Console.WriteLine("You lose!! The secret nunmber was : "+secretNumber);
        }
        

    }
}
