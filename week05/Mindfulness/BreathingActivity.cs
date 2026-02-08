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

        // Repeat box breathing for duration
        for (int i = 0; i < _duration / (seconds * 4); i += seconds)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(seconds);
            i += seconds;
            if (i >= _duration)  // Break if duration has been reached
            {
                break;
            }

            Console.WriteLine("Hold...");
            ShowCountDown(seconds);
            i += seconds;
            if (i >= _duration)
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            ShowCountDown(seconds);
            i += seconds;
            if (i >= _duration)
            {
                break;
            }

            Console.WriteLine("Hold...");
            ShowCountDown(seconds);
        }
    }
    // Alternate breathing for shorter durations
    public void AlternateBreathing()
    {
        int seconds;

        // If duration is less than 8 seconds,
        // use 2 second intervals.
        // Otherwise, use 4 second intervals.
        if (_duration < 8)
        {
            seconds = 2;
        }
        else
        {
            seconds = 4;
        }

        // Repeat alternate breathing for duration
        for (int i = 0; i < _duration / (seconds * 2); i += seconds)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(seconds);
            i += seconds;
            if (i >= _duration)  // Break if duration has been reached
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            ShowCountDown(seconds);
        }
    }
}