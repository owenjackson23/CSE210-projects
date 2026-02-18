public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private int _levelPoints = 0;
    private int _levelTarget = 99999;

    public void Start()
    {
        // TODO: Implement method
    }

    // Displays the player's score and level
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}\nLevel: {_level}");
    }

    // Lists the names of the goals in the _goals list
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"\n{goal.GetName()}");
        }
    }

    // Lists the details of the goals in the _goals list
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"\n{goal.GetDetailsString()}");
        }
    }

    // Prompts the user to create a new goal
    // and adds it to the _goals list
    public void CreateGoal()
    {
        // TODO: Implement method
    }

    public void RecordEvent()
    {
        // TODO: Implement method
    }

    // Save the goals to a file in JSON format
    public void SaveGoals(string filename)
    {
        // TODO: Implement method
    }

    // Load the goals from a JSON file
    // and add them to the _goals list
    public void LoadGoals(string filename)
    {
        // TODO: Implement method
    }
}