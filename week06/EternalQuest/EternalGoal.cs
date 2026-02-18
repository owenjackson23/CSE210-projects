public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // Empty constructor body
    }

    public override void RecordEvent()
    {
        // TODO: Implement method
    }

    // An EternalGoal is never complete, so this method always returns false
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        // TODO: Implement method
        return "";
    }
}