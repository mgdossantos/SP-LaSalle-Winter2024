using System;

public class Program
{
    static void Main(String[] args)
    {
        /*Sum of Even Numbers: Calculate and 
         * print the sum of the first 50 
         * even numbers using a for loop*/
        int evenNumber,sum;
        evenNumber = 0;
        sum = 0;
        for (int i = 0; i < 50; i ++)
        {
           evenNumber = 2 * i;
           Console.WriteLine(i+":"+evenNumber);
            sum = sum + evenNumber;
        }
        Console.WriteLine(sum);

    }
}
