public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "What are your favorite qualities that you posses?",
        "Who are the most important people in your life?",
        "What have you improved at this month?",
        "What do you appreciate about the person you are closest with?",
        "What spiritual experiences have you had this month?"
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
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        // Get user input until duration reached
        GetListFromUser();

        // Display number of items listed
        Console.WriteLine($"\nYou listed {_count} items!\n");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);  // Remove the prompt so it is not used again
        Console.WriteLine($" --- {prompt} --- ");
    }
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;

        // Get user input until duration reached
        while (!isTimeUp(startTime))
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
            _count++;
        }
        return items;
    }
}