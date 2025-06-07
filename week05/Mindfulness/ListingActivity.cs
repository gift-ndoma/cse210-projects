public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "What are things you are grateful for today?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string desc, int duration) : base(name, desc, duration)
    {
        _count = 0; 
    }

    public void Run()
    {
        DisplayStartingMessage();

        _count = 0;

        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        Console.WriteLine("List as many as you can to the following prompt:");
        
        string prompt = GetRandomPrompt();
        Console.WriteLine($"-- {prompt} --");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            if (DateTime.Now < endTime)
            {
                string input = Console.ReadLine();

                if (DateTime.Now >= endTime)
                    break;

                if (!string.IsNullOrWhiteSpace(input))
                {
                    userList.Add(input.Trim());
                    _count++;
                }
            }
        }

        return userList;
    }
}