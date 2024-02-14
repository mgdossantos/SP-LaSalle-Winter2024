using System;

class Program
{
    static void Main(string[] args)
    {
        string[] options = { "paper", "scissor", "stone" };
        int opMenu;
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Finish");
            opMenu = int.Parse(Console.ReadLine());
            if (opMenu == 1)
            {
                Random random = new Random();
                int player1 = random.Next(options.Length);
                Console.WriteLine(options[player1]);
                int player2 = random.Next(options.Length);
                Console.WriteLine(options[player2]);

                if (player1 == 1)
                {
                    if (player2 == 1)
                    {
                        Console.WriteLine("We have an tie!!");
                    }
                    if (player2 == 2)
                    {
                        Console.WriteLine("Player 2 win!!!!!");
                    }

                    if (player2 == 3)
                    {
                        Console.WriteLine("Player 1 win!!!!!");
                    }
                }

                if (player1 == 2)
                {
                    if (player2 == 2)
                    {
                        Console.WriteLine("We have an tie!!");
                    }
                    if (player2 == 1)
                    {
                        Console.WriteLine("Player 1 win!!!!!");
                    }

                    if (player2 == 3)
                    {
                        Console.WriteLine("Player 2 win!!!!!");
                    }
                }

                if (player1 == 3)
                {
                    if (player2 == 3)
                    {
                        Console.WriteLine("We have an tie!!");
                    }
                    if (player2 == 1)
                    {
                        Console.WriteLine("Player 2 win!!!!!");
                    }

                    if (player2 == 2)
                    {
                        Console.WriteLine("Player 1 win!!!!!");
                    }
                }
            }
            else
            {
                break;
            }
        } while (true);
        

        
    }
}