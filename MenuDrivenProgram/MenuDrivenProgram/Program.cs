using System;

class Program
{
    static void Main(String[] args)
    {
        double n1=0, n2=0,r=0;
        int op;
        op = 0;

        while(op!=5){
            Console.WriteLine("** Menu **\n");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit\n");

           op = int.Parse(Console.ReadLine());
            if (op == 1 || op == 2 || op == 3 || op == 4)
            {
                Console.Write("Type n1: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Type n2: ");
                n2 = double.Parse(Console.ReadLine());

            }
            switch (op)
            {
                case 1:
                    r = n1 + n2;
                    break;
                case 2:
                    r = n1 - n2;
                    break;
                case 3:
                    r = n1 * n2;
                    break;
                case 4:
                    r = n1 / n2;
                    break;
                case 5:
                    Console.WriteLine("You finished the app.!!");
                    break;
            }
            Console.WriteLine("result: " + r);


        }





    }
}