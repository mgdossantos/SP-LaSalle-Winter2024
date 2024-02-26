using System;

class Program
{
    static void Main(String[] args)
    {
         // create an empty matrix
         //int[,] matrix2 = new int[2, 3];


         // Two-dimensional array.
         int[,] matrix2 = { { 1, 2, 3 }, { 3, 4, 5 } };

         foreach (int element in matrix2)
         {
             Console.WriteLine(element);
         }

         int rows = matrix2.GetLength(0);
         int columns = matrix2.GetLength(1);

        Console.WriteLine("Row: "+rows);
        Console.WriteLine(columns);

        for (int i = 0; i < rows; i++)
         {
             for (int j = 0; j < columns; j++)
             {
                 if (j == (columns - 1))
                 {
                    Console.Write("[" + i + "," + j + "]"); 
                    Console.WriteLine(matrix2[i, j]);
                 }
                 else
                 {
                    Console.Write("[" + i + "," + j + "]");
                    Console.Write(matrix2[i, j] + "-");

                 }
             }
             Console.WriteLine();
         }

        

    }

}