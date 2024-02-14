using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for a number and
        // give one of the message
        // the largest number
        // the lowest number
        // you haven't entered any number

        int largest = Int32.MinValue;
        int lowest = Int32.MaxValue;

        int number,counter=0;
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            number=int.Parse(Console.ReadLine());
            if (number != -1)
            {
                counter++ ;
                if (number > largest)
                {
                    largest = number;
                   
                }

                if (number < lowest)
                {
                    lowest = number;
                    
                }
            }
            else
                break;
           
        }
        if (counter == 0)
        {
            Console.WriteLine("You haven't entered any number!!");
        }
        else
        {
            Console.WriteLine("The largest number is: " + largest);
            Console.WriteLine("The lowest number is: " + lowest);
        }


    }
}
