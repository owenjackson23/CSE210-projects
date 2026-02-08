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
        // Provides name, description, and asks for and sets duration
        // Prepare to begin
        // Pause
    }
    public void DisplayEndingMessage()
    {
        // Congratulate user
        // Pause
        // Display name and duration
        // Pause
    }

    public void ShowSpinner(int seconds)
    {
        // A pause animation for several seconds
    }
    public void ShowCountDown(int seconds)
    {
        // A countdown timer animation
    }
}