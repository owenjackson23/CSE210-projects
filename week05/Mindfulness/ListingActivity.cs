public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        ""
    };

    public ListingActivity(string name = "Listing Activity", string description = "This activity will help you focus on positive things as you list as many as you can", int count = 0)
        : base(name, description)
    {
        _name = name;
        _description = description;
        _count = count;
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Display prompt and pause for 5 seconds
        GetRandomPrompt();
        ShowSpinner(5);

        // Get user input until duration reached
        GetListFromUser();

        // Display number of items listed
        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);  // Remove the prompt so it is not used again
        Console.WriteLine(prompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;

        // Get user input until duration reached
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
            _count++;
        }
        return items;
    }
}