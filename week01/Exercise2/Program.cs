using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercent = int.Parse(input);
        string letter;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if ((gradePercent % 10 >= 7) && !(letter == "A" || letter == "F"))
        {
            letter += "+";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}