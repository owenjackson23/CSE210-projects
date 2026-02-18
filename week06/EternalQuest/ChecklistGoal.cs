public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        int totalPoints = _points;

        if (IsComplete())
        {
            totalPoints += _bonus;
        }

        return totalPoints;
    }

    // If the goal is completed enough times, return true
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Returns the details of the goal as a string
    public override string GetDetailsString()
    {
        string details = $"{_shortName} ({_points} points): {_description}";

        details = $"[{_amountCompleted}/{_target}] " + details;

        return details;
    }

    // Returns the details of the goal as a string
    // to save and load from a file
    public override string GetStringRepresentation()
    {
        string details = $"{_shortName} ({_points} points)\n  {_description}";

        details = $"[{_amountCompleted}/{_target}] " + details;

        return details;
    }
}