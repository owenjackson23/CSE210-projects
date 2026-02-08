public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Think of a time when you reached a goal you set for yourself.",
        "Think of a time when you put others before yourself.",
        "Think of a time when you did the right thing, even though it was difficult."
    };
    private List<string> _questions = new List<string>
    {
        ""
    };

    public ReflectingActivity(string name = "Reflection Activity", string description = "This activity will help you to remember how you have shown strength and resilience in the past. Reflecting on those times can help you recognize you strengths and how you can use them in the future.")
        : base(name, description)
    {
        _name = name;
        _description = description;
    }
}