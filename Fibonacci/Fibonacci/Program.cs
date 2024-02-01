using System;

public class Program
{
    static void Main(String[] args)
    {

        int first, second;
        first = 0;
        second = 1;
        int third;
        Console.WriteLine(first);
        Console.WriteLine(second);
        for (int i = 3; i < 21; i++)
        {
      
            third = first + second;
            Console.WriteLine(third);
            
            first = second;
            second= third;
        }

    }
}

