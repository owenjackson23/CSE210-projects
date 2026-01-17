public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is one thing that you learned today?");
        _prompts.Add("What is one way that you can improve for tomorrow?");
        _prompts.Add("What is one thing that made you smile today?");
        _prompts.Add("How did you see God's hand in your life today?");
        _prompts.Add("What is a challenge that you faced today and how did you overcome it?");
        _prompts.Add("What did you have for dinner? Rate it on a scale of 1-10.");
        _prompts.Add("What is one thing that you wish that you had more time for today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}