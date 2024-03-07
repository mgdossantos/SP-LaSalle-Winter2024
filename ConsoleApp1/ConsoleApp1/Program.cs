using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables!!!
        int TotalGrade = 0;         // The sum of all the grades!
        int Pass = 0;               // Number of students who passed!
        int Fail = 0;               // Number of students who failed!
        string BestStudent = "";    // Highest grade student name!
        int BestGrade = int.MinValue;   // Highest grade obtained!
        string WorstStudent = "";   // Lowest grade student name!
        int WorstGrade = int.MaxValue;  // Lowest grade obtained!

        // Input for each student!
        for (int i = 1; i <= 5; i++) // 5 Students!
        {
            // Enter the name of each student!
            Console.WriteLine($"Enter the name for student {i}:");
            string StudentName = Console.ReadLine(); // Reads the student's name!

            // Enteer the grade for each student!
            Console.WriteLine($"Enter the grade for student {i}:");
            int Grade = int.Parse(Console.ReadLine()); // Reads the student's grade!

            // The sum of all student grades to calculate the average!
            TotalGrade += Grade;

            // Check if the student passed or failed! (60% or more to pass!)
            if (Grade >= 60)
            {
                Pass++; // Increases the "Pass" variable by one! (indicating the student passed!)
            }
            else
            {
                Fail++; // Increases the "Fail" variable by one! (indicating the student failed!)
            }

            // Student with the highest grade!
            if (Grade > BestGrade)
            {
                BestGrade = Grade;          // Highest grade!
                BestStudent = StudentName;  // Name of the student with the highest grade!
            }

            // Student with the lowest grade!
            if (Grade < WorstGrade)
            {
                WorstGrade = Grade;         // Lowest grade!
                WorstStudent = StudentName; // Name of the student with the lowest grade!
            }
        }

        // Now calculate the average grade of the class!
        double AverageGrade = (double)TotalGrade / 5;

        // Display grades!!
        Console.WriteLine("Grades");
        Console.WriteLine($"Total grade obtained by all students! {TotalGrade}");
        Console.WriteLine($"Class average! {AverageGrade}");
        Console.WriteLine($"Number of students who passed! {Pass}");
        Console.WriteLine($"Number of students who failed! {Fail}");
        Console.WriteLine($"Student with the best grade! {BestStudent} - {BestGrade}");
        Console.WriteLine($"Student with the worst grade! {WorstStudent} - {WorstGrade}");
    }
}

