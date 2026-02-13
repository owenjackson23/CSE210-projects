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

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    // Returns the details of the goal as a string
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}\n({_points} points)";
    }

    public abstract string GetStringRepresentation();
}