public class BreathingActivity : Activity
{
    public BreathingActivity(string name = "Breathing Activity", string description = "This activity will guide you through controlled breathing to help you relax.")
        : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        DisplayStartingMessage();

        if (!IsTooShort())
        {
            // Box breathing activity
            BoxBreathing();
        }
        else
        {
            // Alternate breathing activity
            AlternateBreathing();
        }

        DisplayEndingMessage();
    }

    // If the duration is less than 16 seconds, box breathing will not be effective
    // Returns true if duration is less than 16 seconds, false otherwise
    public bool IsTooShort()
    {
        if (_duration < 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Box breathing for durations of 16 seconds or more
    public void BoxBreathing()
    {
        int seconds = 4;

        DateTime startTime = DateTime.Now;

        // Repeat box breathing for duration
        while (!isTimeUp(startTime))
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(seconds);
            if (isTimeUp(startTime))  // Break if duration has been reached
            {
                break;
            }

            Console.Write("\nHold...");
            ShowCountDown(seconds);
            if (isTimeUp(startTime))
            {
                break;
            }

            Console.Write("\nBreathe out...");
            ShowCountDown(seconds);
            if (isTimeUp(startTime))
            {
                break;
            }

            Console.Write("\nHold...");
            ShowCountDown(seconds);
        }

        // for (int i = 0; i < _duration / (seconds * 4); i += seconds)
        // {
        //     Console.WriteLine("Breathe in...");
        //     ShowCountDown(seconds);
        //     i += seconds;
        //     if (i >= _duration)
        //     {
        //         break;
        //     }

        //     Console.WriteLine("Hold...");
        //     ShowCountDown(seconds);
        //     i += seconds;
        //     if (i >= _duration)
        //     {
        //         break;
        //     }

        //     Console.WriteLine("Breathe out...");
        //     ShowCountDown(seconds);
        //     i += seconds;
        //     if (i >= _duration)
        //     {
        //         break;
        //     }

        //     Console.WriteLine("Hold...");
        //     ShowCountDown(seconds);
        // }
    }
    // Alternate breathing for shorter durations
    public void AlternateBreathing()
    {
        int seconds;

        // If duration is less than 10 seconds,
        // use 3 second intervals.
        // Otherwise, use 5 second intervals.
        if (_duration < 10)
        {
            seconds = 3;
        }
        else
        {
            seconds = 5;
        }

        DateTime startTime = DateTime.Now;

        // Repeat alternate breathing for duration
        while (!isTimeUp(startTime))
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(seconds);
            if (isTimeUp(startTime))  // Break if duration has been reached
            {
                break;
            }

            Console.Write("\nBreathe out...");
            ShowCountDown(seconds);
        }
    }
}