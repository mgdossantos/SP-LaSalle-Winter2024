using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int op = -1;
        int[] ex1 = {1,2,3,4,5};
        string[] ex2 = { "Ferrari", "Toyota"};
        double[] ex3 = new double[4];
        


        
        do
        {
            Console.WriteLine("\n*** Menu ***\n");
            Console.WriteLine("1 - Show elements");
            Console.WriteLine("2 - Input values(user) in an array");
            Console.WriteLine("3 - Input values(random) in an array");
            Console.WriteLine("4 - Show an array in reverse order");
            Console.WriteLine("5 - Calculate sum and average");
            Console.WriteLine("6 - Show the highest and lowest number");
            Console.WriteLine("7 - How many times? ");
            Console.WriteLine("8 - Palindrome");

            op = int.Parse(Console.ReadLine());
            

            switch (op)
            {
                case 1:
                    for (int i = 0; i < ex1.Length; i++)
                    {
                        Console.WriteLine("ex1["+i+"]:"+ex1[i]);
                    }

                    foreach(int numb in ex1)
                    {
                        Console.Write(numb + " ");
                    }

                    break;

                case 2:
                    

                    // for (int i = 0; i < ex2.Length; i++)
                    //{
                    //    Console.WriteLine("Enter your name");
                    //   ex2[i]= Console.ReadLine();
                    //} 
                    foreach (string numb in ex2)
                    {
                        Console.WriteLine(numb);
                    }

                    break;
                case 3:
                    Random random = new Random();
                   for (int i = 0; i < ex3.Length; i++)
                    {
                        ex3[i] = random.NextDouble();
                    }
                   foreach (double numb in ex3)
                    {
                        Console.WriteLine(numb);
                    }
                
                    break;

                case 4:
                    //for (int i = ex1.Length - 1; i > -1; i--)
                    // {
                    //     Console.WriteLine(ex1[i]);
                    // }
                    Array.Reverse(ex1);
                    for (int i = 0; i < ex1.Length; i++)
                    {
                        Console.WriteLine(ex1[i]);
                    }

                    break;

                case 5:
                    double sum = 0;
                    double average;
                    for (int i = 0;i < ex3.Length;i++ )
                    {
                        sum += ex3[i];

                    }
                    Console.WriteLine(sum);
                    average = sum / ex3.Length;
                    Console.WriteLine(average);

                    break;
                case 6:
                    double max = Double.MinValue, min = Double.MaxValue;
                    Console.WriteLine("This is with functions: ");
                    Console.WriteLine(ex3.Max());
                    Console.WriteLine(ex3.Min());

                    for (int i = 0; i < ex3.Length; i++)
                    {
                        if (ex3[i] > max)
                        {
                            max = ex3[i];
                            
                        }
                        if (ex3[i] < min)
                        {
                            min = ex3[i];
                        }
                    }
                    Console.WriteLine("This is with forloop");
                    Console.WriteLine("This is max: " + max);
                    Console.WriteLine("This is min: " + min);



                    break;

                case 7:
                    


                    break;

                case 8:
                    // A palindrome is a word, number, phrase, or " +
                    // other sequence of symbols that reads the " +
                    // same backwards as forwards, such as madam or racecar,"
                    
                    break;
            }
        }
        while (op != 0);

    }
}
