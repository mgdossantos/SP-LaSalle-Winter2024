using System;

class Program
{
    static void Main(String[] args)
    {
        int number,sucessor,predecessor;
        Console.WriteLine("Type a number : ");
        number = int.Parse(Console.ReadLine());
        sucessor = number + 1;
        predecessor = number - 1;
        Console.WriteLine("Sucessor: " + sucessor);
        Console.WriteLine("Predecessor: "+ predecessor);
    }
}
