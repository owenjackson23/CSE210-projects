public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // TODO: Implement method
    }

    public override bool IsComplete()
    {
        // TODO: Implement method
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // TODO: Implement method
        return "";
    }
}