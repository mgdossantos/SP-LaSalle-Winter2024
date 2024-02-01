using System;

class Program
{
    static void Main(string[] args)
    {
        double grade,sum=0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Type your grade: ");
            grade=int.Parse(Console.ReadLine());
            sum = sum + grade;

        }
        Console.WriteLine(sum);
        double average;
        average = sum / 5;
        Console.WriteLine(average);

        
    }
}