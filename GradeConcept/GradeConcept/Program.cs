using System;

class Program
{
    static void Main(string[] args)
    {
        double g1, g2, average;
        string concept="",message="";

        Console.WriteLine("Type the first grade: ");
        g1= double.Parse(Console.ReadLine());

        Console.WriteLine("Type the second grade: ");
        g2 = double.Parse(Console.ReadLine());

        average = (g1 + g2) / 2;

        if (average >= 9)
        {
            concept = "A";
        }
        else
        {
            if (average >=7.5 && average<9) {
            concept = "B";
            }
            else
            {
                if(average >=6 && average < 7.5)
                {
                    concept= "C";
                }
                else
                {
                    if(average>=4 && average < 6)
                    {
                        concept= "D";
                    }
                    else
                    {
                        if(average>0 && average < 4)
                        {
                            concept= "E";
                        }
                        else
                        {
                            concept = "I";
                        }
                    }
                }
            }
        }
        if (concept == "A" ||concept== "B" || concept == "C"){
            message = "PASSED";
        }

        if (concept == "D" || concept == "E") { 
            message = "FAIL";
        }

        Console.WriteLine("Final result = " + message);


    }
}