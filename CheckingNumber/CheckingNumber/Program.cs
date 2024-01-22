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

        switch (op)
        {

            case '+':
                result = n1 + n2;
                break;

            case '-':
                result = n1 - n2;
                break;

            case '*':
                result = n1 * n2;
                break;

            case '/':
                result = n1 / n2;
                break;
        }

        

        result2 = Math.Floor(result);
        Console.WriteLine("Number 1: " + n1);
        Console.WriteLine("Number 2: " + n2);
        Console.WriteLine("Result: " + result);

        Console.WriteLine("Result after Math.Floor operation: " + result2);

        if (result == result2)
        {
            message = "The result is integer";
            if (result % 2 == 0)
            {
                message = message+", even"; 
            }
            else
            {
                message = message + ", odd";
            }
        }
        else
        {
            message = "The result is decimal";

        }

        if (result > 0)
        {
            message = message + ", positive";
        }
        else
        {
            message = message + ", negative";

        }

        Console.WriteLine(message);

    }
}