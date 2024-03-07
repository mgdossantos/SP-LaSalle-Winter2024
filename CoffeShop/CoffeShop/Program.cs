using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] coffes = new int[3,6];
        int totalchocolate = 0, totalcappucino = 0,totalmocha = 0;

        int rows= coffes.GetLength(0);
        int cols= coffes.GetLength(1);
        String day="";
        String type = "";

        for(int j = 0; j < cols; j++)
        {         
           if (j == 0) day= "Monday";
           if (j == 1) day = "Tuesday";
           if (j == 2) day = "Wednesday";
           if (j == 3) day = "Thursday";
           if (j == 4) day = "Friday";
           if (j == 5) day = "Saturday";
          
           Console.WriteLine("\n*** "+day+ " ***\n");


            for (int i=0;i <rows; i++)
            {
                if (i == 0) type = "chocolate";
                if (i == 1) type = "cappuccino";
                if (i == 2) type = "mocha";
                
            
                Console.Write("How many "+type+" was sold? ");
                coffes[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(coffes[i, j]+" ");
            }
            Console.WriteLine();
        }

        for (int j = 0; j < cols; j++)
        {
            
            for (int i = 0; i < rows; i++)
            {
                if (i == 0)
                {
                    totalchocolate = totalchocolate + coffes[i, j];
                }
                if (i == 1)
                {
                    totalcappucino = totalcappucino + coffes[i, j];
                }
                if (i == 2)
                {
                    totalmocha = totalmocha + coffes[i, j];
                }


                
            }
        }
        Console.WriteLine(totalchocolate);
        Console.WriteLine(totalcappucino);
        Console.WriteLine(totalmocha);
          

    }
}
