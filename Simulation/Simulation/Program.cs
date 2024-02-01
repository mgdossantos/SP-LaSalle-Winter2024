using System;

public class Program
{
    static void Main(string[] args)
    {
        string answer;
        answer = " ";
        while (answer!="n" && answer!="no")
        {
            //should allow the user to enter a series of integers
            //The program must use a loop to allow the user to enter
            //multiple numbers until he wants to stop
            int number = 0;
            int cont = 0;
            int sum = 0;
            int odd = 0;
            int even = 0;

            Console.WriteLine("type a number: ");
            number = int.Parse(Console.ReadLine());


            int largest = number;
            int lowest = number;

            // I will use -1 to finish 
            while (number != -1)
            {

                if (number != -1)
                {
                    sum = sum + number;
                    cont++;

                    //Number of even and odd numbers entered.

                    if (number % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }

                    //Largest number entered.
                    if (number > largest)
                    {
                        largest = number;
                    }

                    //Lowestnumber entered.
                    if (number < lowest)
                    {
                        lowest = number;
                    }

                }

                Console.WriteLine("type a number: ");
                number = int.Parse(Console.ReadLine());



            }

            double average;
            if (cont > 0)
            {
                average = sum / cont;
                Console.WriteLine("Average: " + average);
                Console.WriteLine("Largest: " + largest);
                Console.WriteLine("Lowest: " + lowest);
                Console.WriteLine("Number of odd numbers: " + odd);
                Console.WriteLine("Number of even numbers: " + even);

            }
            else
            {
                Console.WriteLine("You did not type any number!");
            }
            Console.WriteLine("Do you want to enter another list of number? ");
            answer= Console.ReadLine();

        }



    }
}
