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
            Console.Clear();

            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an option (1-4): ");
            option = int.Parse(Console.ReadLine());

            // Breathing activity
            if (option == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            // Reflecting activity
            else if (option == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            // Listing activity
            else if (option == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            // Exit program
            else
            {
                Console.WriteLine("\nExiting Mindfulness Program\n");
                break;
            }
        } while (option != 4);
    }
}