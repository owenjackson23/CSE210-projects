// Author: Owen Jackson
// Project: W05 Mindfulnes Project
// CSE210

// Exceeding Requirements:
// I added multiple breathing activities depending on the duration set
// I added several helper methods
// The prompts and questions will only be displayed once

using System;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an option (1-4): ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (option == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (option == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else
            {
                break;
            }
        } while (option != 4);
    }
}