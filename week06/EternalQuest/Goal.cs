public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    // Returns the details of the goal as a string
    public virtual string GetDetailsString()
    {
        string details = $"{_shortName} ({_points} points): {_description}";

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

    public abstract string GetStringRepresentation();
}