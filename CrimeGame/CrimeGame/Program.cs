using System;

class Program
{
    static void Main(String[] args)
    {
        int yes = 0;
        string answer="";

        Console.WriteLine("Did you call the victim?");
        answer = Console.ReadLine();

        if(answer == "Yes" || answer== "yes"|| answer =="Y" || answer == "y")
        {
            yes++;
        }
        answer = "";

        Console.WriteLine("Were you at the crime scene?");
        answer = Console.ReadLine();

        if (answer.ToLower() == "yes" || answer.ToLower() == "y")
        {
            yes++;
        }
        answer = "";

        Console.WriteLine("Do you live near the victim?");
        answer = Console.ReadLine();
        

        if (answer.ToLower() == "yes" || answer.ToLower() == "y")
        {
            yes++;
        }
        answer = "";
        Console.WriteLine("Owed to the victim?");
        answer = Console.ReadLine();
      

        if (answer.ToLower() == "yes" || answer.ToLower() == "y")
        {
            yes++;
        }
        answer = "";
        Console.WriteLine("Have you ever worked with the victim?");
        answer = Console.ReadLine();
        

        if (answer.ToLower() == "yes" || answer.ToLower() == "y")
        {
            yes++;
        }

        Console.WriteLine(yes);

        if(yes == 2)
        {
            Console.WriteLine("You are Suspect!!");
        }
        else
        {
            if(yes==3 || yes == 4)
            {
                Console.WriteLine("Accomplice");

            }
            else
            {
                if (yes == 5)
                {
                    Console.WriteLine("You are Murderer");

                }
                else
                {
                    Console.WriteLine("You are Innocent!!");

                }
            }
        }
    }
}
