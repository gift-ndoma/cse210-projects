public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string desc, int duration) : base(name, desc, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            double remainingSeconds = (endTime - DateTime.Now).TotalSeconds;

            if (remainingSeconds < 10)
                break;

            DisplayQuestions();

            int spinnerTime = Math.Min(10, (int)remainingSeconds);
            ShowSpinner(spinnerTime);
            
            DisplayEndingMessage();
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt");

        Console.WriteLine();
        Console.WriteLine($"-- {prompt} --");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine();
        Console.WriteLine($"> {question}");
    }
}