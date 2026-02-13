public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
        // TODO: Implement method
    }

    public abstract bool IsComplete();

    // Returns the details of the goal as a string
    public string GetDetailsString()
    {
        return $"{_shortName}: {_description}\n({_points} points)";
    }

    public string GetStringRepresentation()
    {
        // TODO: Implement method
        return "";
    }
}