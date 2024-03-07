using System;

class Program
{
    static string sortCoin()
    {
        Random rnd = new Random();
        int coin= rnd.Next(1,3);
        Console.WriteLine(coin);
        if (coin == 1)
            return "Head";
        else
            return "Tail";
    }

    static void Main(string[] args)
    {
        char op='y';
        while (op!='n')
        {
            Console.WriteLine(sortCoin());
            Console.WriteLine("Play again? n(no) y(yes)");
            op=char.Parse(Console.ReadLine());
        }
    }
}