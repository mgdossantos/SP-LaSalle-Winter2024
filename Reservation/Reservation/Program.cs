using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int op;
        int t2, t4, t6,number=0;
        string date="", hour="";
        bool occasion=false;
        char children=' ';
        string answer;
        bool status=false;

        t2 = 5;
        t4 = 7;
        t6 = 3;

       
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Reservation");
            Console.WriteLine("2 - Administration");
            Console.WriteLine("3 - Finish");

            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("How many people?");
                    number = int.Parse(Console.ReadLine());

                    if (number > 0)
                    {
                        Console.WriteLine("Date: ");
                        date = Console.ReadLine();
                        Console.WriteLine("Hour: ");
                        hour = Console.ReadLine();
                        Console.WriteLine("Is it an special occasion? yes or no? ");
                      
                        answer = Console.ReadLine();
                        //ternary operator
                        occasion = answer == "yes"? true :false;

                        Console.WriteLine("Are there children? y or n");
                        children = char.Parse(Console.ReadLine());
                        if (number <= 2)
                        {
                           if (t2 > 0)
                            {
                                t2--;
                                status = true;
                            }
                                
                           else
                                Console.WriteLine("Sorry, we do not have table for 2 available!!");
                        }
                        else {
                            if (number <= 4)
                            {
                                if (t4 > 0)
                                {
                                    t4--;
                                    status = true;
                                }
                                else
                                    Console.WriteLine("Sorry, we do not have table for 4 available!!");
                            }
                            else
                            {
                                if (number <= 6)
                                {
                                    if (t6 > 0)
                                    {
                                        t6--;
                                        status = true;
                                    }
                                    else
                                        Console.WriteLine("Sorry, we do not have table for 6 available!!");
                                }
                                else
                                {
                                    Console.WriteLine("Call to the restaurant!");
                                }
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid!!");
                    }
                    if (status == true){
                        Console.WriteLine("How many person: " + number);
                        Console.WriteLine("Date: " + date);
                        Console.WriteLine("Hour: " + hour);
                        Console.WriteLine("Special occasion: " + occasion);
                        Console.WriteLine("Children: " + children);
                    }
                  

                    break;

                case 2:
                    Console.WriteLine("Table for 2 left: "+t2);
                    Console.WriteLine("Table for 4 left: " + t4);
                    Console.WriteLine("Table for 6 left: " + t6);
                    break;
            }
            





        }
        while (op != 3) ;
     }
}
