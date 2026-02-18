public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // Empty constructor body
    }

    // Awards points
    public override int RecordEvent()
    {
        return _points;
    }

    // An EternalGoal is never complete, so this method always returns false
    public override bool IsComplete()
    {
        return false;
    }

    // Returns the details of the goal as a string
    // to save and load from a file
    public override string GetStringRepresentation()
    {
        return $"{_shortName} ({_points} points)\n  {_description}";
    }
}