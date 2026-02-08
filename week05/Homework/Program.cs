using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Assignment assignment = new Assignment("John Smith", "Derivatives");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Brigham Young", "Integrals", "13.6", "17-27");
        Console.WriteLine($"\n{mathAssignment.GetSummary()}\n");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"\n{writingAssignment.GetSummary()}\n");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        Console.WriteLine();
    }
}