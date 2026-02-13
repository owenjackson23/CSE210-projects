public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // TODO: Implement method
    }

    public override bool IsComplete()
    {
        // TODO: Implement method
        return _amountCompleted >= _target;
    }

    // Returns the details of the goal as a string
    public override string GetDetailsString()
    {
        // TODO: Implement method
        return "";
    }

    public override string GetStringRepresentation()
    {
        // TODO: Implement method
        return "";
    }
}