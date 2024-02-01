using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <20; i++)
        {
            if(i%2 ==0)
            {

                Console.WriteLine("You achieved a even number! We will skip to next iteration");
                continue;
            }
            Console.WriteLine("You achieved a odd number!!!");
        }
       



    }
}