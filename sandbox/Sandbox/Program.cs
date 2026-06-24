using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Console.Write("\nEnter a string: ");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        Console.WriteLine($"Reversed String: {reversed}");

        bool isPalindrome = CheckPalindrome(input);
        if (isPalindrome)
        {
            Console.WriteLine("Your string is a palindrome!");
        }
        else
        {
            Console.WriteLine("Your string is not a palindrome.");
        }
    }

    // Reverses a given string
    static string ReverseString(string inputString)
    {
        // Converts input string into array
        char[] charArray = inputString.ToCharArray();

        Array.Reverse(charArray);

        // Converts reversed array into string
        string reversed = new string(charArray);

        return reversed;
    }

    // Checks if a string is a palindrome
    static bool CheckPalindrome(string inputString)
    {
        bool isPalindrome = false;

        string reversed = ReverseString(inputString);

        string cleanedInput = Regex.Replace(inputString, @"[^\w]", "");
        string cleanedReversed = Regex.Replace(reversed, @"[^\w]", "");

        if (cleanedInput == cleanedReversed)
        {
            isPalindrome = true;
        }
        else
        {
            isPalindrome = false;
        }

        return isPalindrome;
    }
}