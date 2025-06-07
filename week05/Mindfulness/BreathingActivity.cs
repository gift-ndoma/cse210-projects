public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string desc, int duration) : base(name, desc, duration)
    {
    
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"Breathe in...");
            ShowCountDown(4);

            if (DateTime.Now >= endTime)
                break;

            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}