public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long would you like for your session? ");

        string input = Console.ReadLine();
        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        Console.WriteLine($" You have completed another {_duration} seconds of your {_name} Activity.");
        ShowSpinner(5);
        Console.WriteLine("“Gratitude turns what we have into enough.” – Anonymous");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}