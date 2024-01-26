using System;
class Program
{    static void Main(String[] args)
    {
        int op;
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Cappuccino");
        Console.WriteLine("2 - Mocha");
        Console.WriteLine("3 - Chocolate");
        Console.WriteLine("4 - Exit");

        op= int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Console.WriteLine("Your cappuccino is ready");
                break;
            case 2:
                Console.WriteLine("Your mocha is ready");
                break;
            case 3:
                Console.WriteLine("Your chocolate is ready");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("invalid option");
                break;


        }

        //is it an invalid option?
        /* if(op > 0 && op < 5)
         {
              if (op == 1)
              {
                  Console.WriteLine("Your cappuccino is ready");
              }

              if (op == 2)
              {
                  Console.WriteLine("Your mocha is ready");
              }

              if (op == 3)
              {
                  Console.WriteLine("Your chocolate is ready");
              }

              if (op == 4)
              {
                  Console.WriteLine("Exit!!");
              }
          }
          else
          {
              Console.WriteLine("invalid option!!");
          }
        if (op == 1)
        {
            Console.WriteLine("Your cappuccino is ready");
        }
        else
        {
            if (op == 2)
            {
                Console.WriteLine("Your mocha is ready");
            }
            else
            {
                if (op == 3)
                {
                    Console.WriteLine("Your chocolate is ready");
                }
                else
                {
                    if (op == 4)
                    {
                        Console.WriteLine("Exit!!");
                    }
                    else
                    {
                        Console.WriteLine("invalid option!!");
                    }
                }
            }
        }*/

       


        
  }
}