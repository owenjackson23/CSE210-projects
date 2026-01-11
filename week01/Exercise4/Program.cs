using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        int sum = 0;
        float average;
        int largest = -1;
        int smallest = int.MaxValue;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                break;
            }
        } while (userNumber != 0);

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }

        average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
    }
}