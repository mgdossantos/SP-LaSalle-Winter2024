using System;

class Program
{
    static void Main(String[] args)
    {
        int amount, amount100, amount50, amount20,amount10, amount5, amount2, amount1;
        bool valid;
        valid = true;

        amount = 0;
        amount100 = 0;
        amount50 = 0;
        amount20 = 0;
        amount10 = 0;
        amount5 = 0;
        amount2 = 0;
        amount1 = 0;



        Console.WriteLine("Type the amount");
        amount= int.Parse(Console.ReadLine());
        if(amount > 0)
        {
           
            amount100 = amount / 100;
            amount = amount % 100;

            
            amount50 = amount / 50;
            amount = amount % 50;

           
            amount20 = amount / 20;
            amount = amount % 20;

            
            amount10 = amount / 10;
            amount = amount % 10;

            amount5 = amount / 5;
            amount = amount % 5;

            
            amount2 = amount / 2;
            amount = amount % 2;

            
            amount1 = amount;
        }
        else
        {
            valid = false;
        }

        if (valid==true){
            Console.WriteLine("$100="+amount100);
            Console.WriteLine("$50=" + amount50);
            Console.WriteLine("$20=" + amount20);
            Console.WriteLine("$10=" + amount10);
            Console.WriteLine("$5=" + amount5);
            Console.WriteLine("$2=" + amount2);
            Console.WriteLine("$1=" + amount1);

        }
        else
        {
            Console.WriteLine("Invalid amount!!");
        }




    }
}
