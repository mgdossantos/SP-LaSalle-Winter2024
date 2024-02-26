using System;


class Program
{
    static void Main(String[] args)
    {
        int[] racers = new int[5];
        double sum=0,average;

        for(int j = 0; j < racers.Length; j++) { 
            Console.WriteLine("Type the time in min for the race " + (j + 1) + " :");
            racers[j] = int.Parse(Console.ReadLine());
            sum = sum + racers[j]; 
        }
        average = sum / racers.Length;
       Array.Sort(racers);

        for(int i = 0; i < racers.Length; i++)
        {
            Console.WriteLine("["+i+"]:" +racers[i]);
        }
        Console.WriteLine("Average: "+average);

        int element;
        Console.WriteLine("Element to search: ");
        element= int.Parse(Console.ReadLine());
        int index = Array.IndexOf(racers, element);
        Console.WriteLine(index);


    }
}