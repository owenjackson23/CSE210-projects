using System.Runtime.InteropServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        // Provides name and description
        Console.WriteLine($"{_name}:\n\n{_description}\n");

        // Asks for and sets duration
        Console.WriteLine("How long would you like to do this activity?");
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Get ready...");

        // Pause
        ShowSpinner(7);

        // Clear the screen
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great work!");
        ShowSpinner(3);
        Console.WriteLine($"You did the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }

    // A pause animation
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write("|");

            Thread.Sleep(100);

            Console.Write("\b \b");  // This erases the previous character
            Console.Write("/");  // Replace the character

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(100);

            Console.Write("\b \b");
            Console.Write("\\");
        }
    }

    // A countdown timer animation
    public void ShowCountDown(int seconds)
    {
        Console.Write(seconds);

        for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);  //Wait 1 second
            Console.Write("\b \b");
            if ((i - 1) <= 0)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(i - 1);
            }
        }
    }

    // Checks to see if the activity has exceeded its duration
    public bool isTimeUp(DateTime startTime)
    {
        if ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}