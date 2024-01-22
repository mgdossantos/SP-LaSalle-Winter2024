using System;

class Program
{
    static void Main(string[] args)
    {

        double result = 0, n1, n2;
        char op;
        double result2;

       

        String message;

        Console.WriteLine("Type the first number: ");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Type the first number: ");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose the operation: + - * /");
        op = char.Parse(Console.ReadLine());

        if (op == '+')
        {
            result = n1 + n2;
        }


        if (op == '-')
        {
            result = n1 - n2;
        }

        if (op == '*')
        {
            result = n1 * n2;
        }

        if (op == '/')
        {
            result = n1 / n2;
        }


        if (result > 0)
        {
            result2 = Math.Floor(result);
            Console.WriteLine("Number 1: " + n1);
            Console.WriteLine("Number 2: " + n2);
            Console.WriteLine("Result: " + result);

            Console.WriteLine("Result after Math.Floor operation: " + result2);

            message = "The result is positive";
            if (result == result2)
            {
                message = message +", integer";
                if (result % 2 == 0)
                {
                    message = message + ", even";
                }
                else
                {
                    message = message + ", odd";
                }
            }
            else
            {
                message = message + ", decimal";
            }
        }
        else
        {
            result2 = Math.Ceiling(result);
            Console.WriteLine("Number 1: " + n1);
            Console.WriteLine("Number 2: " + n2);
            Console.WriteLine("Result: " + result);

            Console.WriteLine("Result after Math.Celing operation: " + result2);

            message = "The result is negative";
            
                message = message + ", integer";
                if (result % 2 == 0)
                {
                    message = message + ", even";
                }
                else
                {
                    message = message + ", odd";
                }
            }
            else
            {
                message = message + ", decimal";

            }

        }


        Console.WriteLine(message);

    }
}