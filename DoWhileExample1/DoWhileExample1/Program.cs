using System;

class Program
{
    static void Main(String[] args)
    {
        //you need to ask 5 number 

        string answer=" ";
        while (answer != 'n')
        {
            Console.WriteLine("Do you want to continue?");
            answer = Console.ReadLine();
        }

        do
        {
            Console.WriteLine("Do you want to continue?");
            answer = Console.ReadLine();
        }
        while (answer != "n");



    }
}