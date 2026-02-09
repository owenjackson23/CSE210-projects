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
        "What was the first step you took?",
        "How did it make you feel?",
        "If you did it again, what would you do different?",
        "What did you learn about yourself?",
        "What made it so memorable for you?",
        "How has that experience helped you to be a better person?",
        "What parts were easiest? What parts were the most difficult?",
        "How has this experience shaped how you make decisions today?",
        "How has this experience helped you to learn your strengths?"
    };

    public ReflectingActivity(string name = "Reflection Activity", string description = "This activity will help you to remember how you have shown strength and resilience in the past. Reflecting on those times can help you recognize you strengths and how you can use them in the future.")
        : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Display prompt and pause for 5 seconds
        DisplayPrompt();
        ShowSpinner(5);

        Console.WriteLine("\nReflect on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.Clear();

        DateTime startTime = DateTime.Now;

        // Display questions at intervals of 10 seconds until duration reached
        while (!isTimeUp(startTime))
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }

        // for (int i = 5; i < _duration / 10; i += 10)
        // {
        //     DisplayQuestion();
        //     ShowSpinner(10);
        // }

        DisplayEndingMessage();
    }

    // Returns a random prompt from the _prompts list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);  // Remove the prompt so it is not used again
        return prompt;
    }
    // Returns a random question from the _questions list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);  // Remove the question so it is not used again
        return question;
    }
    // Gets a random prompt and displays it
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider this prompt:\n");

        // Display a prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- ");

        Console.Write("\nPress 'Enter' when your are ready to continue. ");
        Console.ReadLine();
    }
    // Gets a random question and displays it
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"{question} ");
    }
}