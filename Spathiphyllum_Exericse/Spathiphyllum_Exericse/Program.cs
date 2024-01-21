using System;

class Program
{
    static void Main(String[] args)
    {
        String plant="";
        Console.WriteLine("Type the input: ");
        plant=Console.ReadLine();
      
        if ( plant == "Spathiphyllum")
        {
            Console.WriteLine("Spathiphyllum is the best plant ever!");
        }
        else
        {
            if (plant == "spathiphyllum")
            {
                Console.WriteLine("No, I want a big Spathiphyllum!");

            }
            else
            {
                Console.WriteLine("Spathiphyllum! Not "+plant+"!");
            }
        }
    }
       
}