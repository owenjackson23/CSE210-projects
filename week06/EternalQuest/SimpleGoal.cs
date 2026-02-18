public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Updates the progress of the goal
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Returns the details of the goal as a string
    // to save and load from a file
    public override string GetStringRepresentation()
    {
        string details = $"{_shortName} ({_points} points)\n  {_description}";

        // If the goal is complete, check it off
        if (IsComplete())
        {
            details = "[X] " + details;
        }
        else
        {
            details += "[] " + details;
        }

        return details;
    }
}